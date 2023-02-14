using AutoMapper;
using AutoMapper.QueryableExtensions;
using FPLSP.Server.Data.Repositories.Interfaces;
using FPLSP.Server.Domain.Dtos.TakeAnswerDtos;
using FPLSP.Server.Domain.Entities.UsesParts;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels.TakeAnswerViewModel;

namespace FPLSP.Server.Infrastructure.Services.Implements
{
    public class TakeAnswerUPServices : ITakeAnswerUPServices
    {
        private readonly IRepository<TakeAnswerUP> _takeAnswerUPRepository;
        private readonly IMapper _mapper;

        public TakeAnswerUPServices(IRepository<TakeAnswerUP> takeAnswerUpRepository, IMapper mapper)
        {
            _takeAnswerUPRepository = takeAnswerUpRepository ?? throw new ArgumentNullException(nameof(takeAnswerUpRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public Task<List<TakeAnswerUPDto>> GetTakeAnSwerAsync()
        {
            var result = _takeAnswerUPRepository.AsQueryable().ProjectTo<TakeAnswerUPDto>(_mapper.ConfigurationProvider).ToList();
            return Task.FromResult(result);
        }

        public async Task<TakeAnswerUP> CreateTakeAnswerAsync(TakeAnswerWm viewModel)
        {
            var result = new TakeAnswerUP();
            result = _mapper.Map<TakeAnswerUP>(viewModel);
            result.Id = Guid.NewGuid();
            await _takeAnswerUPRepository.AddAsync(result);
            await _takeAnswerUPRepository.SaveChangesAsync();
            return result;
        }

        public async Task<TakeAnswerUP> UpdateTakeAnswerAsync(Guid Id, TakeAnswerWm viewModel)
        {
            var result = _takeAnswerUPRepository.AsQueryable().FirstOrDefault(c => Guid.Equals(Id, c.Id));
            result.TakeAnswers = viewModel.TakeAnswers;
            await _takeAnswerUPRepository.UpdateAsync(result);
            await _takeAnswerUPRepository.SaveChangesAsync();
            return result;
        }

        public async Task<TakeAnswerUP> DeleteTakeAnswerAsync(Guid id)
        {
            var result = _takeAnswerUPRepository.AsQueryable().FirstOrDefault(c => Guid.Equals(id, c.Id));
            await _takeAnswerUPRepository.RemoveAsync(result);
            await _takeAnswerUPRepository.SaveChangesAsync();
            return result;
        }
    }
}
