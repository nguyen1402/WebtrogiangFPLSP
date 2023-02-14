using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos.QuestionType;
using FPLSP.Server.Infrastructure.ViewModels.QuestionType;

namespace FPLSP.Repositories.Interfaces
{
    public interface IQuestionTypeRepo
    {
        Task<List<QuestionTypeDto>> GetAll();
        Task<PageList<QuestionTypeDto>> GetPageList(QuestionTypeSearch questionTypeSearch);
        Task<bool> Add(QuestionTypeVm questionTypeVm);
        Task<bool> Update(string Id, QuestionTypeVm questionTypeVm);
        Task<QuestionTypeVm> Get(string Id);
    }
}
