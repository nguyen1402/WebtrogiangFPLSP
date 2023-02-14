using FPLSP.Repositories.Interfaces.FPLExam;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Entities.FPLExam;
using FPLSP.Server.Infrastructure.ViewModels.FPLExam;
using Microsoft.AspNetCore.WebUtilities;

namespace FPLSP.Repositories.Services.FPLExam
{
    public class ExaminationRoomRepo : IExaminationRoomRepo
    {
        private readonly HttpClient _httpClient;
        public ExaminationRoomRepo(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<bool> AddExaminationRoom(ExaminationRoomDetailView examinationRoomViewModel)
        {
            var res = await _httpClient.PostAsJsonAsync("/api/ExaminationRooms/examroom-adding", examinationRoomViewModel);
            return res.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteExamRoom(Guid IdExamroom)
        {
            var res = await _httpClient.DeleteAsync($"/api/ExaminationRooms/{IdExamroom}");
            return res.IsSuccessStatusCode;
        }

        public async Task<List<ExaminationRoom>> GetAllExamRoom()
        {
            var res = await _httpClient.GetFromJsonAsync<List<ExaminationRoom>>("/api/ExaminationRooms");
            return res;
        }

        public async Task<ExaminationRoom> GetExamRoomById(Guid Id)
        {
            var res = await _httpClient.GetFromJsonAsync<ExaminationRoom>($"/api/ExaminationRooms/{Id}");
            return res;
        }

        public async Task<PageList<ExaminationRoomDetailView>> GetExamRoomForPaging(ExaminationRoomSearch examinationRoomSearch)
        {
            var queryStringParam = new Dictionary<string, string>
            {
                ["pageNumber"] = examinationRoomSearch.PageNumber.ToString()
            };

            //       public string? ExaminationRoomName { get; set; }
            //public Guid? TrainId { get; set; }


            if (!string.IsNullOrEmpty(examinationRoomSearch.ExaminationRoomName))
            {
                queryStringParam.Add("ExaminationRoomName", examinationRoomSearch.ExaminationRoomName.ToString());
            }
            if (examinationRoomSearch.TrainId.HasValue)
            {
                queryStringParam.Add("TrainId", examinationRoomSearch.TrainId.ToString());
            }
            string url = QueryHelpers.AddQueryString("/api/ExaminationRooms/examroom-paging", queryStringParam);

            var res = await _httpClient.GetFromJsonAsync<PageList<ExaminationRoomDetailView>>(url);
            return res;
        }

        public async Task<bool> UpdateExamRoom(ExaminationRoomDetailView examinationRoomViewModel)
        {
            var res = await _httpClient.PutAsJsonAsync("/api/ExaminationRooms/examroom-updating", examinationRoomViewModel);
            return res.IsSuccessStatusCode;
        }
    }
}
