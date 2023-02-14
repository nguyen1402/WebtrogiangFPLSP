using AutoMapper;
using AutoMapper.QueryableExtensions;
using FPLSP.Server.Data.Repositories.Interfaces;
using FPLSP.Server.Domain.Dtos.AnswerUPDtos;
using FPLSP.Server.Domain.Entities.UsesParts;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels.AnswerUp;

namespace FPLSP.Server.Infrastructure.Services.Implements
{
    public class AnswerUPServices : IAnswerUPServices
    {
        private IRepository<AnswerUP> _answerUpRepository;
        private readonly IMapper _mapper;
        public AnswerUPServices(IRepository<AnswerUP> answerUpRepository, IMapper mapper)
        {
            _answerUpRepository = answerUpRepository ?? throw new ArgumentNullException(nameof(answerUpRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        public Task<IQueryable<AnswerUPDto>> GetAll()
        {
            return Task.FromResult(_answerUpRepository.AsQueryable().ProjectTo<AnswerUPDto>(_mapper.ConfigurationProvider).Where(c => c.Status == 0));
        }

        public async Task<bool> AddAnswer(AnswerUpVm answerUpVm)
        {
            try
            {
                AnswerUP answerUP = new AnswerUP();
                answerUP.Answer = answerUpVm.Answer;
                answerUP.QuizQuestionId = answerUpVm.QuizQuestionId;
                answerUP.Id = Guid.NewGuid();
                answerUP.Status = 0;
                _answerUpRepository.AddAsync(answerUP);
                _answerUpRepository.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public async Task<bool> Delete(Guid Id)
        {
            try
            {
                var answerUp = _answerUpRepository.AsQueryable().FirstOrDefault(c => c.Id == Id);
                answerUp.Status = 1;
                _answerUpRepository.UpdateAsync(answerUp);
                _answerUpRepository.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> Update(Guid Id, AnswerUpVm answerUpVm)
        {
            try
            {
                var answerUp = _answerUpRepository.AsQueryable().FirstOrDefault(c => c.Id == Id);
                answerUp.Answer = answerUpVm.Answer;
                answerUp.QuizQuestionId = answerUpVm.QuizQuestionId;
                answerUp.Status = answerUpVm.Status;
                _answerUpRepository.UpdateAsync(answerUp);
                _answerUpRepository.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<AnswerUpVm> GetDetails(Guid Id)
        {
            return _answerUpRepository.AsQueryable().ProjectTo<AnswerUpVm>(_mapper.ConfigurationProvider).FirstOrDefault(c => c.Id == Id);
        }
    }
}
