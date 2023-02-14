using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos.QuestionType;
using FPLSP.Server.Infrastructure.ViewModels.QuestionType;

namespace FPLSP.Server.Infrastructure.Services.Interfaces
{
    public interface IQuestionTypeServices
    {
        Task<IQueryable<QuestionTypeDto>> GetAll();
        Task<PageList<QuestionTypeDto>> GetPageList(QuestionTypeSearch questionTypeSearch);
        Task<bool> Add(QuestionTypeVm questionTypeVm);
        Task<bool> Update(Guid Id, QuestionTypeVm questionTypeVm);
        Task<QuestionTypeVm> Get(Guid Id);
    }
}
