using AutoMapper;
using AutoMapper.QueryableExtensions;
using FPLSP.Server.Data.Repositories.Interfaces;
using FPLSP.Server.Domain.Dtos.QuizQuestionUPDto;
using FPLSP.Server.Domain.Entities.UsesParts;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels.QuizQuestionUp;
using Microsoft.EntityFrameworkCore;

namespace FPLSP.Server.Infrastructure.Services.Implements
{
    public class QuizQuestionUPServices : IQuizQuestionUPServices
    {
        private readonly IRepository<QuizQuestionUP> _quizQuestionUPRep;
        private readonly IMapper _mapper;
        public QuizQuestionUPServices(IRepository<QuizQuestionUP> quizQuestionUPRep, IMapper mapper)
        {
            _quizQuestionUPRep = quizQuestionUPRep ?? throw new ArgumentNullException(nameof(quizQuestionUPRep)); ;
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<bool> Add(QuizQuestionUpVm quizQuestionUpVm)
        {
            try
            {
                QuizQuestionUP quizQuestionUP = new QuizQuestionUP();
                quizQuestionUP.QuestionTital = quizQuestionUpVm.QuestionTital;
                quizQuestionUP.ContentQuestion = quizQuestionUpVm.ContentQuestion;
                quizQuestionUP.QuestionTypeId = quizQuestionUpVm.QuestionTypeId;
                quizQuestionUP.QuestionName = quizQuestionUpVm.QuestionName;
                quizQuestionUP.Status = 0;
                quizQuestionUP.QuestionCode = quizQuestionUpVm.QuestionCode;
                _quizQuestionUPRep.AddAsync(quizQuestionUP);
                _quizQuestionUPRep.SaveChangesAsync();
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
                var quizQuestionUp = await _quizQuestionUPRep.AsQueryable().FirstOrDefaultAsync(c => c.Id == Id);
                quizQuestionUp.Status = 1;
                _quizQuestionUPRep.UpdateAsync(quizQuestionUp);
                _quizQuestionUPRep.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<IQueryable<QuizQuestionUpDto>> GetAll()
        {
            return _quizQuestionUPRep.AsQueryable().ProjectTo<QuizQuestionUpDto>(_mapper.ConfigurationProvider).Where(c => c.Status == 0);
        }

        public async Task<QuizQuestionUP> GetDetails(Guid Id)
        {
            return _quizQuestionUPRep.AsQueryable().FirstOrDefault(c => c.Id == Id);
        }

        public async Task<bool> Update(Guid Id, QuizQuestionUpVm quizQuestionUpVm)
        {
            try
            {
                var quizQuestionUp = await _quizQuestionUPRep.AsQueryable().FirstOrDefaultAsync(c => c.Id == Id);
                quizQuestionUp.QuestionTital = quizQuestionUpVm.QuestionTital;
                quizQuestionUp.ContentQuestion = quizQuestionUpVm.ContentQuestion;
                quizQuestionUp.QuestionTypeId = quizQuestionUpVm.QuestionTypeId;
                quizQuestionUp.QuestionName = quizQuestionUpVm.QuestionName;
                quizQuestionUp.Status = quizQuestionUpVm.Status;
                quizQuestionUp.QuestionCode = quizQuestionUpVm.QuestionCode;
                _quizQuestionUPRep.UpdateAsync(quizQuestionUp);
                _quizQuestionUPRep.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
