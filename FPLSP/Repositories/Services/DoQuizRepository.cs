using FPLSP.Repositories.Interfaces;
using FPLSP.Server.Domain.Dtos.DoQuizDtos;

using FPLSP.Server.Infrastructure.ViewModels.DoQuizsVM;

namespace FPLSP.Repositories.Services;

public class DoQuizRepository : IDoQuizRepository
{
    private readonly HttpClient _httpClient;

    public DoQuizRepository(HttpClient httpClient)
    {
        _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
    }
    public async Task<GetListQuestionAndScore> GetQuestionInQuizAsync(GetQuestionCollectionVm vieCollectionVm)
    {
        var result = await _httpClient.GetFromJsonAsync<GetListQuestionAndScore>($"api/DoQuiz/GetQuestion?QuizId={vieCollectionVm.QuizId}&StudentId={vieCollectionVm.StudentId}");
        return result;
    }

    public async Task<double> EventButtonSubmitAsync(Guid quizId, DoQuizViewModel viewModel)
    {
        var result = await _httpClient.PostAsJsonAsync($"api/DoQuiz/Submit/{quizId}", viewModel);

        if (!result.IsSuccessStatusCode)
        {
            return -1;
        }

        var a = result.Content.ReadAsStringAsync();
        var data = double.Parse(await result.Content.ReadAsStringAsync());
        return data;
    }

}