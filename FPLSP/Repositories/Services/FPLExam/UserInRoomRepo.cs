using FPLSP.Data.FPLExam;
using FPLSP.Repositories.Interfaces.FPLExam;
using FPLSP.Server.Domain.Entities.CoresParts;
using Microsoft.AspNetCore.Identity;
using System.Collections.Concurrent;

namespace FPLSP.Repositories.Services.FPLExam
{
    public class UserInRoomRepo : IUserInRoomRepo
    {

        private readonly IServiceScopeFactory _scopeFactory;
        public ConcurrentDictionary<string, KeyValuesUser> UsersByConnectionId { get; set; } =
           new ConcurrentDictionary<string, KeyValuesUser>();
        public event EventHandler OnChange;


        public UserInRoomRepo(IServiceScopeFactory scopeFactory)
        {
            _scopeFactory = scopeFactory;
        }
        public async Task Connect(string circuitId, string email, string Image, string StudentCode, string RoleName)
        {


            KeyValuesUser keyValuesUser = new KeyValuesUser()
            {
                Email = email,
                StudentCode = StudentCode,
                Image = Image,
            };

            UsersByConnectionId.AddOrUpdate(circuitId, keyValuesUser, (key, oldValue) => keyValuesUser);
            NotifyStateChanged();






        }

        public async Task DisConnect(string circuitId, string Email, string RoleName)
        {
            if (RoleName == "SV FPLExam")
            {

                using (var scope = _scopeFactory.CreateScope())
                {
                    var _onlineExamRoomRepo = scope.ServiceProvider.GetService<IOnlineExamRoomRepo>();
                    var usermanager = scope.ServiceProvider.GetService<UserManager<UserSignIn>>();
                    var _examinationRoomDetailRepo = scope.ServiceProvider.GetService<IExaminationRoomDetailRepo>();
                    var Clear = scope.ServiceProvider.GetService<StateDelegateAcceptTojoin>();
                    var GetIdUser = usermanager.Users.Where(c => c.Email == Email).Select(c => c.Id).FirstOrDefault();

                    var GetLastestSecrete = await _onlineExamRoomRepo.GetScretKeyLastestForUser(GetIdUser);

                    var ListUserInRoomBySecret = await _onlineExamRoomRepo.GetOnlineExamRoomById(GetLastestSecrete.SecretKey);
                    //láº¥y ra tháº±ng user
                    var UserInRoomBySecretById = ListUserInRoomBySecret.Where(c => c.IdUser == GetIdUser).FirstOrDefault();
                    //kiểm tra xem đên giờ phát hay chưa
                    if (UserInRoomBySecretById.StartTime <= DateTime.Now && UserInRoomBySecretById.EndTime >= DateTime.Now)
                    {
                        //đây là khi vào phòng thi rồi
                        var res = await _onlineExamRoomRepo.FastUpdateHanlerWhenOut(GetLastestSecrete.SecretKey, GetIdUser);
                        if (res)
                        {

                            UsersByConnectionId.TryRemove(circuitId, out var _);
                            NotifyStateChanged();
                        }

                    }
                    if (UserInRoomBySecretById.StartTime > DateTime.Now)
                    {

                        //đây là trước khi thi
                        UsersByConnectionId.TryRemove(circuitId, out var _);
                        NotifyStateChanged();
                    }
                    if (!string.IsNullOrEmpty(UserInRoomBySecretById.IdUser) && UserInRoomBySecretById.StartTime <= DateTime.Now && UserInRoomBySecretById.EndTime <= DateTime.Now)
                    {
                        var res = await _onlineExamRoomRepo.FastUpdateHanlerWhenOut(GetLastestSecrete.SecretKey, GetIdUser);
                        if (res)
                        {

                            UsersByConnectionId.TryRemove(circuitId, out var _);
                            NotifyStateChanged();
                        }
                    }

                }
            }
            else
            {
                UsersByConnectionId.TryRemove(circuitId, out var _);
                NotifyStateChanged();
            }


        }
        private void NotifyStateChanged() => OnChange?.Invoke(this, EventArgs.Empty);
        //


    }
    public class KeyValuesUser
    {
        public string Email { get; set; }
        public string StudentCode { get; set; }

        public string Image { get; set; }
    }
}
