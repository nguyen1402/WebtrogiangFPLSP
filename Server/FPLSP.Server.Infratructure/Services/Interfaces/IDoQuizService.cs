using FPLSP.Server.Domain.Dtos.DoQuizDtos;
using FPLSP.Server.Infrastructure.ViewModels.DoQuizsVM;

namespace FPLSP.Server.Infrastructure.Services.Interfaces;

public interface IDoQuizService
{
    Task<GetListQuestionAndScore> GetQuestionCollection(GetQuestionCollectionVm viewModel);
    Task<double> SubmitQuizAsync(Guid quizId, DoQuizViewModel viewModel);
    Task<List<AnswersOfQuizDto>?> GetTakeAnswersOfQuizAsync(GetTakeAnswerOfStudentVM viewModel);
}