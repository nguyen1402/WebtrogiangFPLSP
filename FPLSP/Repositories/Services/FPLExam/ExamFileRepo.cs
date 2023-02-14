using FPLSP.Repositories.Interfaces.FPLExam;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Entities.FPLExam;
using FPLSP.Server.Infrastructure.ViewModels.FPLExam;
using Microsoft.AspNetCore.WebUtilities;

namespace FPLSP.Repositories.Services.FPLExam
{
    public class ExamFileRepo : IExamFileRepo
    {
        private readonly HttpClient _httpClient;
        public ExamFileRepo(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }



        public async Task<bool> AddMultipleExamFile(List<ExamStorageViewModel> examStorageViewModels)
        {
            var res = await _httpClient.PostAsJsonAsync("/api/ExamStorages/examfile-adding", examStorageViewModels);
            return res.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteExamFile(Guid IdExamFile)
        {
            var res = await _httpClient.DeleteAsync($"/api/ExamStorages/{IdExamFile}");
            return res.IsSuccessStatusCode;
        }

        public async Task<List<ExamStorage>> GetAllExamFiles()
        {

            var res = await _httpClient.GetFromJsonAsync<List<ExamStorage>>("/api/ExamStorages");
            return res;

        }

        public async Task<List<ExamStorage>> GetAllExamFilesBySubjectId(Guid IdSubject)
        {
            var res = await _httpClient.GetFromJsonAsync<List<ExamStorage>>($"/api/ExamStorages/examfile-byid/{IdSubject}");
            return res;
        }

        public async Task<List<ExamStorage>> GetAllExamFilesForLectuer(Guid IdLecturter)
        {
            var res = await _httpClient.GetFromJsonAsync<List<ExamStorage>>($"/api/ExamStorages/examfile-foronlylec/{IdLecturter}");
            return res;
        }

        public async Task<List<ExamStorage>> GetAllExamFilesForLectuterSubject(Guid Idlec, Guid IdSubject)
        {
            var res = await _httpClient.GetFromJsonAsync<List<ExamStorage>>($"/api/ExamStorages/examfile-forlecsub/{Idlec}/{IdSubject}");
            return res;

        }

        public async Task<List<ExamStorage>> GetAllExamFilesForOnlySubject(Guid IdSubject)
        {
            var res = await _httpClient.GetFromJsonAsync<List<ExamStorage>>($"/api/ExamStorages/examfile-foronlysub/{IdSubject}");
            return res;

        }

        public async Task<PageList<ExamStorageViewModel>> GetFileForPaging(ExamFileSearch examFileSearch)
        {
            var queryStringParam = new Dictionary<string, string>
            {
                ["pageNumber"] = examFileSearch.PageNumber.ToString()
            };
            //public DateTime? DeleteTime { get; set; }
            if (!string.IsNullOrEmpty(examFileSearch.SubjectName))
            {
                queryStringParam.Add("SubjectName", examFileSearch.SubjectName.ToString());
            }
            if (!string.IsNullOrEmpty(examFileSearch.FileName))
            {
                queryStringParam.Add("FileName", examFileSearch.FileName.ToString());
            }
            if (!string.IsNullOrEmpty(examFileSearch.IdUserUpload))
            {
                queryStringParam.Add("IdUserUpload", examFileSearch.IdUserUpload.ToString());
            }
            if (examFileSearch.CreateTime.HasValue)
            {
                queryStringParam.Add("CreateTime", examFileSearch.CreateTime.ToString());
            }

            if (examFileSearch.DeleteTime.HasValue)
            {
                queryStringParam.Add("DeleteTime", examFileSearch.DeleteTime.ToString());
            }
            string url = QueryHelpers.AddQueryString("/api/ExamStorages/examfile-paging", queryStringParam);
            var res = await _httpClient.GetFromJsonAsync<PageList<ExamStorageViewModel>>(url);
            return res;

        }

        public async Task<bool> QuickChangeExamFile(Guid Id, int status)
        {
            var res = await _httpClient.PutAsJsonAsync($"/api/ExamStorages/quickchange/{Id}", status);
            return res.IsSuccessStatusCode;

        }

        public async Task<bool> UpdateExamFile(ExamStorageViewModel examStorageViewModel)
        {
            var res = await _httpClient.PutAsJsonAsync("/api/ExamStorages/examfile-updating", examStorageViewModel);
            return res.IsSuccessStatusCode;

        }

        public async Task<bool> UpdateFastExamFile(Guid idExam)
        {

            var res = await _httpClient.PutAsJsonAsync($"/api/ExamStorages/fastupdate-examfile", idExam);
            return res.IsSuccessStatusCode;
        }
    }
}
