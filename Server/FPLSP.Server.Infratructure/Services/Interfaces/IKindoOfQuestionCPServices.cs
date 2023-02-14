using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos.KindOfQuestionCPDtos;
using FPLSP.Server.Infrastructure.ViewModels.KìnOfQuestionCPVm;

namespace FPLSP.Server.Infrastructure.Services.Interfaces
{
    public interface IKindoOfQuestionCPServices
    {
        Task<int> CreateKOQCP(KindOfQuestionCPVm koq);
        Task<PageList<KindOfQuestionCPDtos>> GetKOQList(ListKOQCPSearch koq);
        Task<int> UpdateKOQCP(Guid id, KindOfQuestionCPVm koq);
        Task<KindOfQuestionCPDtos> GetKOQCPbyId(Guid id);
        Task<int> DeleteKOQCP(Guid id);
        Task<List<KindOfQuestionCPDtos>> GetAllKoq();
    }
}
