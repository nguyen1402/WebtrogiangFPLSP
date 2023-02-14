using FPLSP.Server.Domain.Dtos.DoQuizDtos;
using FPLSP.Server.Infrastructure.ViewModels.DoQuizsVM;

namespace FPLSP.Repositories.Interfaces;

public interface IDoQuizRepository
{
    Task<GetListQuestionAndScore> GetQuestionInQuizAsync(GetQuestionCollectionVm vieCollectionVm);
    Task<double> EventButtonSubmitAsync(Guid quizId, DoQuizViewModel viewModel);
}