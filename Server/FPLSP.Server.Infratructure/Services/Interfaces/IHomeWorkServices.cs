using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Entities.UserParts;
using FPLSP.Server.Infrastructure.ViewModels.HomeWork;

namespace FPLSP.Server.Infrastructure.Services.Interfaces
{
    public interface IHomeWorkServices
    {
        Task<PageList<HomeWork>> GetCPList(Guid idclass, Guid idsubject, Guid idlesson, HomeWorkSeachList SearchVm);
        Task<int> CreateCP(HomeWorkCreatVM creat);
        Task<int> UpdateCP(Guid id, HomeWorkUpdateVM update);
        Task<int> DeleteCP(Guid id);

        Task<HomeWork> Getbyid(Guid id);
    }
}
