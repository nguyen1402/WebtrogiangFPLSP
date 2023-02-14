using FPLSP.Server.Domain.Dtos.AnswerUPDtos;
using FPLSP.Server.Infrastructure.ViewModels.AnswerUp;

namespace FPLSP.Server.Infrastructure.Services.Interfaces
{
    public interface IAnswerUPServices
    {
        Task<IQueryable<AnswerUPDto>> GetAll();
        Task<bool> AddAnswer(AnswerUpVm answerUpVm);
        Task<bool> Delete(Guid Id);
        Task<bool> Update(Guid Id, AnswerUpVm answerUpVm);
        Task<AnswerUpVm> GetDetails(Guid Id);
    }
}
