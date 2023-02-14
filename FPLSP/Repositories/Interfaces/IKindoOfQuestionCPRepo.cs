using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos.KindOfQuestionCPDtos;
using FPLSP.Server.Infrastructure.ViewModels.KìnOfQuestionCPVm;

namespace FPLSP.Repositories.Interfaces
{
    public interface IKindoOfQuestionCPRepo
    {
        Task<int> CreateKOQCP(KindOfQuestionCPVm koq);
        Task<PageList<KindOfQuestionCPDtos>> GetKOQList(ListKOQCPSearch koq);
        Task<int> UpdateKOQCP(KindOfQuestionCPVm koq);
        Task<KindOfQuestionCPVm> GetKOQCPbyId(Guid id);
        Task<int> DeleteKOQCP(Guid id);
    }
}
