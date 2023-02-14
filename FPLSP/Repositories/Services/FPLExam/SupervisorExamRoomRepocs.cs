using FPLSP.Repositories.Interfaces.FPLExam;
using FPLSP.Server.Domain.Entities.FPLExam;
using FPLSP.Server.Infrastructure.ViewModels.FPLExam;

namespace FPLSP.Repositories.Services.FPLExam
{
    public class SupervisorExamRoomRepocs : ISupervisorExamRoomRepocs
    {
        private readonly HttpClient _httpClient;
        public SupervisorExamRoomRepocs(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<bool> AddingRangeSupervisorExamRoom(List<ExamRoomSupervisorViewModel> supervisorExamRooms)
        {
            var res = await _httpClient.PostAsJsonAsync("/api/SupervisorExamRooms/supervisorexamroom-addingrange", supervisorExamRooms);
            return res.IsSuccessStatusCode;
        }

        public async Task<bool> AddingSupervisorExamRoom(SupervisorExamRoom supervisorExamRooms)
        {
            var res = await _httpClient.PostAsJsonAsync("/api/SupervisorExamRooms/supervisorexamroom-adding", supervisorExamRooms);
            return res.IsSuccessStatusCode;
        }

        public async Task<bool> DeletingSupervisorExamRoom(SupervisorExamRoom supervisorExamRooms)
        {
            var res = await _httpClient.PutAsJsonAsync("/api/SupervisorExamRooms/onlineexam-delete", supervisorExamRooms);
            return res.IsSuccessStatusCode;
        }

        public async Task<List<SupervisorExamRoom>> GetAllSupervisorExamRoom()
        {
            var res = await _httpClient.GetFromJsonAsync<List<SupervisorExamRoom>>("/api/SupervisorExamRooms");
            return res;
        }

        public async Task<SupervisorExamRoom> GetCrurrntTimeForSupervisor(string IdUser)
        {
            var res = await _httpClient.GetFromJsonAsync<SupervisorExamRoom>($"/api/supervisorexamrooms/getting-sercret/{IdUser}");
            return res;
        }

        public async Task<List<ExamRoomSupervisorViewModel>> GetSupervisorById(string IdUser)
        {
            var res = await _httpClient.GetFromJsonAsync<List<ExamRoomSupervisorViewModel>>($"/api/supervisorexamrooms/getting-listuer/{IdUser}");
            return res;
        }

        public async Task<bool> UpdatingSupervisorExamRoom(SupervisorExamRoom supervisorExamRooms)
        {
            var res = await _httpClient.PutAsJsonAsync("/api/SupervisorExamRooms/onlineexam-updating", supervisorExamRooms);
            return res.IsSuccessStatusCode;
        }
    }
}
