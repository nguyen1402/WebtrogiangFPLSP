using FPLSP.Server.Domain.Dtos.TakeAnswerDtos;
using FPLSP.Server.Domain.Entities.UsesParts;
using FPLSP.Server.Infrastructure.ViewModels.TakeAnswerViewModel;

namespace FPLSP.Server.Infrastructure.Services.Interfaces
{
    public interface ITakeAnswerUPServices
    {
        Task<List<TakeAnswerUPDto>> GetTakeAnSwerAsync();
        Task<TakeAnswerUP> CreateTakeAnswerAsync(TakeAnswerWm viewModel);
        Task<TakeAnswerUP> UpdateTakeAnswerAsync(Guid id, TakeAnswerWm viewModel);
        Task<TakeAnswerUP> DeleteTakeAnswerAsync(Guid id);
    }
}
