using FPLSP.Repositories.Interfaces.FPLExam;
using FPLSP.Server.Domain.Entities.FPLExam;
using FPLSP.Server.Infrastructure.ViewModels.FPLExam;

namespace FPLSP.Repositories.Services.FPLExam
{
    public class OnlineExamRoomRepo : IOnlineExamRoomRepo
    {
        private readonly IHttpClientFactory _httpClientFac;
        public OnlineExamRoomRepo(IHttpClientFactory httpClientFac)
        {
            _httpClientFac = httpClientFac;

        }
        public async Task<bool> AddOnlineExamRoom(OnlineExamViewModel onlineExamRoom)
        {
            var _httpClient = _httpClientFac.CreateClient("examapi");
            var res = await _httpClient.PostAsJsonAsync("/api/OnlineExams/onlineexam-adding", onlineExamRoom);
            return res.IsSuccessStatusCode;
        }

        public async Task<bool> AddRangeOnlineExamRoom(List<OnlineExamRoom> onlineExamRoom)
        {
            var _httpClient = _httpClientFac.CreateClient("examapi");
            var res = await _httpClient.PostAsJsonAsync("/api/OnlineExams/onlineexam-addingrange", onlineExamRoom);
            return res.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteOnlineExamRoom(string ScreateKey, string IdUser)
        {
            var _httpClient = _httpClientFac.CreateClient("examapi");
            var res = await _httpClient.PutAsJsonAsync($"/api/OnlineExams/onlineexam-delete/{ScreateKey}", IdUser);
            return res.IsSuccessStatusCode;
        }

        public async Task<bool> FastChangingStatus(string ScreateKey, string IdUser)
        {
            var _httpClient = _httpClientFac.CreateClient("examapi");
            var res = await _httpClient.PutAsJsonAsync($"/api/OnlineExams/fastchangingstatus/{ScreateKey}", IdUser);
            return res.IsSuccessStatusCode;
        }

        public async Task<int> FastGettingStatus(string ScreateKey, string IdUser)
        {
            var _httpClient = _httpClientFac.CreateClient("examapi");
            var res = await _httpClient.GetFromJsonAsync<int>($"/api/OnlineExams/fastgettingstatus/{ScreateKey}/{IdUser}");
            return res;
        }

        public async Task<bool> FastUpdateHanlerOneTime(string ScreateKey, string IdUser)
        {
            var _httpClient = _httpClientFac.CreateClient("examapi");
            var res = await _httpClient.PutAsJsonAsync($"/api/OnlineExams/handlereuqestonetime/{ScreateKey}", IdUser);
            return res.IsSuccessStatusCode;
        }

        public async Task<bool> FastUpdateHanlerWhenOut(string ScreateKey, string IdUser)
        {
            var _httpClient = _httpClientFac.CreateClient("examapi");
            var res = await _httpClient.PutAsJsonAsync($"/api/OnlineExams/handlereuqestcomeout/{ScreateKey}", IdUser);
            return res.IsSuccessStatusCode;
        }

        public async Task<bool> FastUpdateTurn(string ScreateKey, string IdUser)
        {
            var _httpClient = _httpClientFac.CreateClient("examapi");
            var res = await _httpClient.PutAsJsonAsync($"/api/OnlineExams/fastupdateturn/{ScreateKey}", IdUser);
            return res.IsSuccessStatusCode;
        }

        public async Task<List<StudentGoToExamViewModel>> GetAllOfExamByIdStudent(string idStudent)
        {
            var _httpClient = _httpClientFac.CreateClient("examapi");
            var res = await _httpClient.GetFromJsonAsync<List<StudentGoToExamViewModel>>($"/api/OnlineExams/getallexamnination-byidstudent/{idStudent}");
            return res;
        }

        public async Task<List<OnlineExamRoom>> GetAllOnlineExamRoom()
        {
            var _httpClient = _httpClientFac.CreateClient("examapi");
            var res = await _httpClient.GetFromJsonAsync<List<OnlineExamRoom>>("/api/OnlineExams");
            return res;
        }

        public async Task<List<OnlineExamHasImageViewModel>> GetOnlineExamRoomById(string Secret)
        {
            var _httpClient = _httpClientFac.CreateClient("examapi");
            var response = await _httpClient.GetFromJsonAsync<List<OnlineExamHasImageViewModel>>($"/api/OnlineExams/{Secret}");
            //string jsonStr = await response.Content.ReadAsStringAsync();
            //List<OnlineExamHasImageViewModel> re = JsonConvert.DeserializeObject<List<OnlineExamHasImageViewModel>>(jsonStr);
            //var res = await _httpClient.GetFromJsonAsync<List<OnlineExamHasImageViewModel>>($"/api/OnlineExams/{Secret}");
            return response;
        }



        public async Task<OnlineExamRoom> GetScretKeyLastestForUser(string IdUser)
        {
            var _httpClient = _httpClientFac.CreateClient("examapi");
            var GetLastestSecrete = await _httpClient.GetFromJsonAsync<OnlineExamRoom>($"/api/OnlineExams/getsectekeylastest/{IdUser}");
            return GetLastestSecrete;
        }

        public async Task<int> getTurnById(string ScreateKey, string IdUser)
        {
            var _httpClient = _httpClientFac.CreateClient("examapi");
            var res = await _httpClient.GetFromJsonAsync<int>($"/api/OnlineExams/getturnuser/{ScreateKey}/{IdUser}");
            return res;
        }

        public async Task<List<OnlineExamHasImageViewModel>> HandlerRequestComeIn(string Secret)
        {
            var _httpClient = _httpClientFac.CreateClient("examapi");
            var response = await _httpClient.GetFromJsonAsync<List<OnlineExamHasImageViewModel>>($"/api/OnlineExams/handlerListrequest/{Secret}");

            //string jsonStr = await response.Content.ReadAsStringAsync();
            //List<OnlineExamHasImageViewModel> re = JsonConvert.DeserializeObject<List<OnlineExamHasImageViewModel>>(jsonStr);
            return response;
        }

        public async Task<bool> ShowingExamFile(string mess)
        {
            var _httpClient = _httpClientFac.CreateClient("examapi");
            var res = await _httpClient.PostAsJsonAsync($"/api/OnlineExams/showexam", mess);
            return res.IsSuccessStatusCode;
        }

        public async Task<bool> UpdateOnlineExamRoom(OnlineExamViewModel onlineExamRoom)
        {
            var _httpClient = _httpClientFac.CreateClient("examapi");
            var res = await _httpClient.PutAsJsonAsync("/api/OnlineExams/onlineexam-updating", onlineExamRoom);
            return res.IsSuccessStatusCode;
        }

        public async Task<bool> ReOpenExamFileForUser(string ScreateKey, string IdUser)
        {
            var _httpClient = _httpClientFac.CreateClient("examapi");
            var res = await _httpClient.PutAsJsonAsync($"/api/OnlineExams/reopenexamfile/{ScreateKey}", IdUser);
            return res.IsSuccessStatusCode;
        }
        //

    }
}
