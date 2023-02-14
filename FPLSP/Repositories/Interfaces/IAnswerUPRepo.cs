using FPLSP.Server.Domain.Dtos.AnswerUPDtos;
using FPLSP.Server.Infrastructure.ViewModels.AnswerUp;

namespace FPLSP.Repositories.Interfaces
{
    public interface IAnswerUPRepo
    {
        Task<List<AnswerUPDto>> GetAll();
        Task<bool> AddAnswer(AnswerUpVm answerUpVm);
        Task<bool> Delete(string Id);
        Task<bool> Update(string Id, AnswerUpVm answerUpVm);
        Task<AnswerUpVm> GetDetails(string Id);
    }
}
