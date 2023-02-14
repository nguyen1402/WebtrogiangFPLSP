using FPLSP.Repositories.Interfaces.FPLExam;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Domain.Entities.FPLExam;
using FPLSP.Server.Infrastructure.ViewModels.FPLExam;
using Microsoft.AspNetCore.WebUtilities;

namespace FPLSP.Repositories.Services.FPLExam
{
    public class ExaminationRoomDetailRepo : IExaminationRoomDetailRepo
    {

        private readonly HttpClient _httpClient;
        private Random random = new Random();
        public ExaminationRoomDetailRepo(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<bool> AddingRangeExamRoomDtail(ExamDetaiRoomForAdding examDetaiRoomForAdding)
        {
            var res = await _httpClient.PostAsJsonAsync("/api/ExaminationRoomDetails/examroomdetail-addingrange", examDetaiRoomForAdding);
            return res.IsSuccessStatusCode;
        }

        public async Task<bool> AutoHideExamRoomDtail(ExaminationRoomDetailViewModel examinationRoomDetailView)
        {
            var res = await _httpClient.PutAsJsonAsync("/api/ExaminationRoomDetails/examroomdetail-autohide", examinationRoomDetailView);
            return res.IsSuccessStatusCode;
        }

        public async Task<bool> DeletingExamRoomDtail(ExaminationRoomDetailViewModel examinationRoomDetailView)
        {
            var res = await _httpClient.PutAsJsonAsync("/api/ExaminationRoomDetails/examroomdetail-delete", examinationRoomDetailView);
            return res.IsSuccessStatusCode;
        }

        public async Task<List<ExaminationRoomDetail>> GetAllExaminationRoomDetail()
        {
            var res = await _httpClient.GetFromJsonAsync<List<ExaminationRoomDetail>>("/api/ExaminationRoomDetails/GetAllExamRoomDetail");
            return res;
        }
        public async Task<List<LecturersCP>> GetAllLectureAddExam()
        {
            var res = await _httpClient.GetFromJsonAsync<List<LecturersCP>>($"/api/ExaminationRoomDetails/examroomdetail-GetAllLectureAddExam");
            return res;
        }

        public async Task<PageList<ExaminationRoomDetailViewModel>> GetALlOfficialExaminationroom(ExamRoomDetailSearch examRoomDetailSearch)
        {
            var queryStringParam = new Dictionary<string, string>
            {
                ["pageNumber"] = examRoomDetailSearch.PageNumber.ToString()
            };




            if (!string.IsNullOrEmpty(examRoomDetailSearch.ExamRoomDetailName))
            {
                queryStringParam.Add("ExamRoomDetailName", examRoomDetailSearch.ExamRoomDetailName.ToString());
            }
            if (!string.IsNullOrEmpty(examRoomDetailSearch.SupervisorName))
            {
                queryStringParam.Add("SupervisorName", examRoomDetailSearch.SupervisorName.ToString());
            }
            if (examRoomDetailSearch.StartTime.HasValue)
            {
                queryStringParam.Add("StartTime", examRoomDetailSearch.StartTime.ToString());
            }
            if (examRoomDetailSearch.EndTime.HasValue)
            {
                queryStringParam.Add("EndTime", examRoomDetailSearch.EndTime.ToString());
            }
            if (examRoomDetailSearch.IdBlock.HasValue)
            {
                queryStringParam.Add("IdBlock", examRoomDetailSearch.IdBlock.ToString());
            }
            if (examRoomDetailSearch.IdSemester.HasValue)
            {
                queryStringParam.Add("IdSemester", examRoomDetailSearch.IdSemester.ToString());
            }
            if (examRoomDetailSearch.IdSubJect.HasValue)
            {
                queryStringParam.Add("IdSubJect", examRoomDetailSearch.IdSubJect.ToString());
            }

            string url = QueryHelpers.AddQueryString("/api/ExaminationRoomDetails/examroomdetail-paging", queryStringParam);
            var res = await _httpClient.GetFromJsonAsync<PageList<ExaminationRoomDetailViewModel>>(url);
            return res;
        }

        public async Task<List<ExaminationRoomDetailViewModel>> GetALlOfficialForStudent(Guid IdStu)
        {
            var res = await _httpClient.GetFromJsonAsync<List<ExaminationRoomDetailViewModel>>($"/api/ExaminationRoomDetails/examroomdetail-forstudent/{IdStu}");
            return res;
        }

        public async Task<List<ExaminationRoomDetailViewModel>> GetALlOfficialForSupervisor(Guid IdSuper)
        {
            var res = await _httpClient.GetFromJsonAsync<List<ExaminationRoomDetailViewModel>>($"/api/ExaminationRoomDetails/examroomdetail-forsupervisior/{IdSuper}");
            return res;
        }

        public async Task<List<ExaminationRoomDetailViewModel>> GetExamFileForSubject(Guid IdSubject)
        {
            var res = await _httpClient.GetFromJsonAsync<List<ExaminationRoomDetailViewModel>>($"/api/ExaminationRoomDetails/examroomdetail-forsubject/{IdSubject}");
            return res;
        }

        public async Task<ExaminationRoomDetailViewModel> GetExaminamRoomDetailBySecret(string SercretKey)
        {
            var res = await _httpClient.GetFromJsonAsync<ExaminationRoomDetailViewModel>($"/api/ExaminationRoomDetails/examroomdetailbysecret/{SercretKey}");
            return res;
        }

        public string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public async Task<bool> UpdatingExamRoomDtail(ExaminationRoomDetailViewModel examinationRoomDetailView)
        {
            var res = await _httpClient.PutAsJsonAsync($"/api/ExaminationRoomDetails/examroomdetail-updating", examinationRoomDetailView);
            return res.IsSuccessStatusCode;
        }
        public async Task<byte[]> GetExamFileBySerceate(string Secret)
        {
            var res = await _httpClient.GetFromJsonAsync<byte[]>($"/api/ExaminationRoomDetails/showexamfile/{Secret}");
            return res;
        }
    }
}
