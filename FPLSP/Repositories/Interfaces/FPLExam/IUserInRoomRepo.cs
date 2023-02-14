using FPLSP.Repositories.Services.FPLExam;
using System.Collections.Concurrent;

namespace FPLSP.Repositories.Interfaces.FPLExam
{
    public interface IUserInRoomRepo
    {
        ConcurrentDictionary<string, KeyValuesUser> UsersByConnectionId { get; set; }
        Task Connect(string circuitId, string email, string Image, string StudentCode, string RoleName);
        Task DisConnect(string circuitId, string Email, string RoleName);
        event EventHandler OnChange;
        //


    }
}
