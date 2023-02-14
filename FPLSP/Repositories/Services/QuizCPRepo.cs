using ExcelDataReader;
using FPLSP.Data;
using FPLSP.Pages.DoQuiz;
using FPLSP.Repositories.Interfaces;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos.KindOfQuestionCPDtos;
using FPLSP.Server.Domain.Dtos.QuizCPDtos;
using FPLSP.Server.Domain.Dtos.StudentUPDtos;
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Domain.Entities.UserParts;
using FPLSP.Server.Infrastructure.ViewModels;
using FPLSP.Server.Infrastructure.ViewModels.QuizCPVm;
using FPLSP.Server.Infrastructure.ViewModels.QuizQuestionCPVm;
using FPLSP.Server.Infrastructure.ViewModels.ResourceLink;
using IdentityServer4.Services;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.FileSystemGlobbing.Internal;
using System.Data;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;
namespace FPLSP.Repositories.Services
{
    public class QuizCPRepo : IQuizCPRepo
    {
        private readonly HttpClient _client;
        private readonly JsonSerializerOptions _options;

        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IHostingEnvironment _hostingEnvironment;

        private List<ExcelErrors> _listexcelErrors = new List<ExcelErrors>();
        public List<ExcelQuizQuestion> _excelQuizQuestions = new List<ExcelQuizQuestion>();

        public QuizCPRepo(HttpClient client, IHttpContextAccessor httpContextAccessor, IHostingEnvironment hostingEnvironment)
        {
            _client = client;
            _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            _httpContextAccessor = httpContextAccessor;
            _hostingEnvironment = hostingEnvironment;
        }


        public async Task<List<ExcelQuizQuestion>> LoadingBigData(IBrowserFile file, Guid idQuiz)
        {
            if (file == null)
            {
                return null;
            }
            string fileName = $"{_hostingEnvironment.WebRootPath}\\files\\{file.Name}";

            using (FileStream fileStream = System.IO.File.Create(fileName))
            {
                Stream stream = file.OpenReadStream();

                await stream.CopyToAsync(fileStream);
                fileStream.Flush();
            }
            var lstST = await this.GetListST(file.Name, idQuiz);
            return lstST;
        }
        public async Task<List<ExcelQuizQuestion>> GetListST(string getfileName, Guid idQuiz)
        {


            var fileName = $"{Directory.GetCurrentDirectory()}{@"\wwwroot\files"}" + "\\" + getfileName;
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);


            using (var stream = System.IO.File.Open(fileName, FileMode.Open, FileAccess.Read))
            {
                IExcelDataReader read;

                using (read = ExcelReaderFactory.CreateReader(stream))
                {
                    DataTable dt = new DataTable();


                    var result = read.AsDataSet(new ExcelDataSetConfiguration()
                    {
                        ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                        {
                            UseHeaderRow = true
                        }
                    });

                    var tbl = result.Tables
                     .Cast<DataTable>()
                     .Select(t => new
                     {
                         TableName = t.TableName,
                         Columns = t.Columns.Cast<DataColumn>()
                                            .Select(x => x.ColumnName)
                                            .ToList(),
                         Row = t.Rows
                     });
                    int flag = -1;
                    for (int i = 0; i < tbl.ToList()[0].Row.Count; i++)
                    {
                        var quizQues = new ExcelQuizQuestion();
                        flag = -100;
                        for (int y = 0; y < tbl.ToList()[0].Columns.Count(); y++)
                        {

                            if (flag == -100)
                            {
                                if (!String.IsNullOrEmpty(Convert.ToString(tbl.ToList()[0].Row[i][y])))
                                {
                                    if (tbl.ToList()[0].Row[i][y].ToString().All(char.IsDigit))
                                    {
                                        quizQues.Index = Convert.ToInt32(tbl.ToList()[0].Row[i][y].ToString());
                                        quizQues.IdQuestion = Guid.NewGuid();
                                        quizQues.Id = Guid.NewGuid();
                                        quizQues.IdQuiz = idQuiz;
                                        flag = y;
                                    }
                                    else
                                    {
                                        continue;
                                    }
                                }
                                else
                                {
                                    continue;
                                }
                            }

                            if (y - flag == 1)
                            {
                                quizQues.ContentQuestion = (tbl.ToList()[0].Row[i][y].ToString());
                            }
                            else if (y - flag == 2)
                            {
                                quizQues.QuestionTypeName = tbl.ToList()[0].Row[i][y].ToString().Trim();
                            }

                            if (quizQues.QuestionTypeName == "MatchingItems" || quizQues.QuestionTypeName == "MultipleChoise")
                            {
                                if (y - flag >= 3 && y - flag <= 6)
                                {
                                    var anser = new QuizAnswerExcel();
                                    anser.Id = Guid.NewGuid();
                                    anser.Answer = quizQues.ListAnswer.Count() == 0 ? "A:~" + tbl.ToList()[0].Row[i][y].ToString() : quizQues.ListAnswer.Count() == 1 ? "B:~" + tbl.ToList()[0].Row[i][y].ToString() : quizQues.ListAnswer.Count() == 2 ? "C:~" + tbl.ToList()[0].Row[i][y].ToString() : "D:~" + tbl.ToList()[0].Row[i][y].ToString();

                                    anser.IdQuizQuestion = quizQues.IdQuestion;
                                    anser.IsCorrect = 0;

                                    quizQues.ListAnswer.Add(anser);
                                }

                                else if (y - flag == 7)
                                {
                                    if (tbl.ToList()[0].Row[i][y].ToString().Contains(","))
                                    {
                                        string[] subs = tbl.ToList()[0].Row[i][y].ToString().Split(',');

                                        foreach (var sub in subs)
                                        {
                                            quizQues.ListIsCorrect.Add(sub.Trim());
                                        }
                                    }
                                    else
                                    {
                                        quizQues.ListIsCorrect.Add(tbl.ToList()[0].Row[i][y].ToString());
                                    }

                                }
                            }
                            else if (quizQues.QuestionTypeName == "YesNo")
                            {
                                if (!String.IsNullOrEmpty(Convert.ToString(tbl.ToList()[0].Row[i][y])))
                                {
                                    if (y - flag >= 3 && y - flag <= 6)
                                    {
                                        if (quizQues.ListAnswer.Any(c => c.Answer.Split(":~")[1] == tbl.ToList()[0].Row[i][y].ToString()) || quizQues.ListAnswer.Count() > 1)
                                        {
                                            continue;
                                        }
                                        var anser = new QuizAnswerExcel();
                                        anser.Id = Guid.NewGuid();
                                        anser.Answer = quizQues.ListAnswer.Count() == 0 ? "A:~" + tbl.ToList()[0].Row[i][y].ToString() : "B:~" + tbl.ToList()[0].Row[i][y].ToString();
                                        anser.IdQuizQuestion = quizQues.IdQuestion;
                                        anser.IsCorrect = 0;
                                        quizQues.ListAnswer.Add(anser);
                                    }
                                }

                                if (y - flag == 7)
                                {
                                    if (tbl.ToList()[0].Row[i][y].ToString().Contains(","))
                                    {
                                        string[] subs = tbl.ToList()[0].Row[i][y].ToString().Split(',');

                                        foreach (var sub in subs)
                                        {
                                            quizQues.ListIsCorrect.Add(sub.Trim());
                                        }
                                    }
                                    else
                                    {
                                        quizQues.ListIsCorrect.Add(tbl.ToList()[0].Row[i][y].ToString());
                                    }

                                }
                            }
                            else if (quizQues.QuestionTypeName == "SupplyItems")
                            {
                                if (y - flag > 6)
                                {
                                    continue;
                                }
                                if (!String.IsNullOrEmpty(Convert.ToString(tbl.ToList()[0].Row[i][y])))
                                {
                                    if (y - flag >= 3 && y - flag <= 6)
                                    {
                                        if (quizQues.ListAnswer.Count() > 0)
                                        {
                                            continue;
                                        }
                                        var anser = new QuizAnswerExcel();
                                        anser.Id = Guid.NewGuid();
                                        anser.Answer = "A:~" + tbl.ToList()[0].Row[i][y].ToString().Trim();
                                        anser.IdQuizQuestion = quizQues.IdQuestion;
                                        anser.IsCorrect = 1;
                                        quizQues.ListAnswer.Add(anser);
                                    }
                                }

                            }



                        }
                        if (quizQues.Id == Guid.Empty || quizQues.ListAnswer.Count() == 0)
                        {
                            continue;
                        }
                        foreach (var correct in quizQues.ListIsCorrect)
                        {
                            foreach (var answer in quizQues.ListAnswer)
                            {
                                if (answer.Answer.Split(":~")[0].ToUpper() == correct.ToUpper())
                                {
                                    answer.IsCorrect = 1;
                                }
                            }
                        }
                        foreach (var answer in quizQues.ListAnswer)
                        {
                            answer.Answer = answer.Answer.Split(":~")[1];
                        }
                        _excelQuizQuestions.Add(quizQues);
                    }

                    return _excelQuizQuestions;
                }
            }
        }

        public async Task<int> CreateQuizCP(Guid idsubject, QuizCPVm quiz)
        {
            var content = JsonSerializer.Serialize(quiz);
            var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");

            var postResult = await _client.PostAsync("/api/QuizCPs/" + idsubject.ToString(), bodyContent);

            if (postResult.IsSuccessStatusCode)
                return 1;

            return 0;
        }

        public async Task<PageList<SubjectQuizCPDtos>> GetQuizCPList(Guid idsubject, ListQuizSearch quiz)
        {
            var queryStringParam = new Dictionary<string, string>
            {
                ["pageNumber"] = quiz.PageNumber.ToString()
            };
            if (!string.IsNullOrEmpty(Convert.ToString(quiz.Status)))
            {
                queryStringParam.Add("Status", Convert.ToString(quiz.Status));
            }
            if (!string.IsNullOrEmpty(quiz.QuizName))
            {
                queryStringParam.Add("QuizName", quiz.QuizName);
            }
            string url = QueryHelpers.AddQueryString("/api/QuizCPs/all/" + idsubject.ToString(), queryStringParam);

            var result = await _client.GetFromJsonAsync<PageList<SubjectQuizCPDtos>>(url);

            return result;
        }

        public async Task<int> CreateExcelQuizQuestion(List<ExcelQuizQuestion> lstexcelQuizQuestions)
        {
            var result = await _client.PostAsJsonAsync("/api/QuizCPs/createExcelQuizQuestion", lstexcelQuizQuestions);
            if (result.IsSuccessStatusCode) return 1;
            return 0;
        }
        public async Task<int> UpdateQuizCP(Guid idquiz, UpdateQuizCPVm quiz)
        {
            var url = Path.Combine("/api/QuizCPs", idquiz.ToString());
            var putResult = await _client.PutAsJsonAsync(url, quiz);
            if (putResult.IsSuccessStatusCode)
                return 1;

            return 0;
        }

        public async Task<SubjectQuizCPDtos> GetQuizById(Guid id)
        {
            var url = Path.Combine("/api/QuizCPs", id.ToString());

            var response = await _client.GetAsync(url);
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content);
            }
            var quiz = JsonSerializer.Deserialize<SubjectQuizCPDtos>(content, _options);
            return quiz;
        }

        public async Task<List<SubjectQuizCPDtos>> GetAllQuizCPbyIdSubject(Guid idsubject)
        {
            var url = Path.Combine("/api/QuizCPs/allquizbyid", idsubject.ToString());

            var response = await _client.GetAsync(url);
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content);
            }
            var quiz = JsonSerializer.Deserialize<List<SubjectQuizCPDtos>>(content, _options);
            return quiz;
        }
        public async Task<List<KindOfQuestionCPDtos>> GetAllKoq()
        {
            var GetListKoq = await _client.GetFromJsonAsync<List<KindOfQuestionCPDtos>>($"/api/KindoOfQuestionCPs/GetAllKoq");
            return GetListKoq;
        }

        public async Task<int> DeleteQuizCP(Guid idQuiz)
        {
            var url = Path.Combine("/api/QuizCPs", idQuiz.ToString());

            var deleteResult = await _client.DeleteAsync(url);
            if (!deleteResult.IsSuccessStatusCode)
            {
                return 0;
            }
            return 1;
        }

        public async Task<bool> RemoveListQuizCP(List<Guid> listIdQuiz)
        {
            var result = await _client.PostAsJsonAsync($"/api/QuizCPs/deletelist/", listIdQuiz);
            if (result.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }
    }
}
