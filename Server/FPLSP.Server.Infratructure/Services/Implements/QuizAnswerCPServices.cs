using AutoMapper;
using FPLSP.Server.Data.Repositories.Interfaces;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos.QuizAnswerCPDtos;
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels.QuizAnswerCPVm;
using Microsoft.EntityFrameworkCore;

namespace FPLSP.Server.Infrastructure.Services.Implements
{
    public class QuizAnswerCPServices : IQuizAnswerCPServices
    {
        private readonly IRepository<QuizAnswerCP> _quizAnswerCPtRepository;
        private readonly IRepository<QuizQuestionCP> _quizQuestionCPtRepository;
        private readonly IMapper _mapper;

        public QuizAnswerCPServices(IRepository<QuizAnswerCP> quizAnswerCPtRepository, IMapper mapper, IRepository<QuizQuestionCP> quizQuestionCPtRepository)
        {
            _quizAnswerCPtRepository = quizAnswerCPtRepository ?? throw new ArgumentNullException(nameof(quizAnswerCPtRepository));
            _quizQuestionCPtRepository = quizQuestionCPtRepository ?? throw new ArgumentNullException(nameof(quizQuestionCPtRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        public async Task<int> CreateQuizAnswerCP(CreateQuizAnswerCPVm quizAnswer)
        {
            try
            {
                var newquizAnswer = new QuizAnswerCP()
                {
                    IdQuizQuestion = quizAnswer.IdQuizQuestion,
                    Answer = quizAnswer.Answer
                };
                await _quizAnswerCPtRepository.AddAsync(newquizAnswer);
                await _quizAnswerCPtRepository.SaveChangesAsync();
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }

        }

        public async Task<int> DeleteQuizAnswerCP(Guid id)
        {
            try
            {
                var quizquestion = await _quizAnswerCPtRepository.AsQueryable().FirstOrDefaultAsync(c => Guid.Equals(id, c.Id));
                await _quizAnswerCPtRepository.RemoveAsync(quizquestion);
                await _quizAnswerCPtRepository.SaveChangesAsync();
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }

        }

        public async Task<QuizAnswerCPVm> GetQuizAnswerCPbyId(Guid id)
        {
            try
            {
                var quizanswer = from a in _quizAnswerCPtRepository.AsQueryable()
                                 join b in _quizQuestionCPtRepository.AsQueryable() on a.IdQuizQuestion equals b.Id
                                 select new QuizAnswerCPVm()
                                 {
                                     Id = a.Id,
                                     QuestionCode = b.QuestionCode,
                                     Answer = a.Answer,
                                     IdQuizQuestion = a.IdQuizQuestion,

                                 };
                var quiz = await quizanswer.FirstOrDefaultAsync(p => p.Id == id);
                return quiz;
            }
            catch
            {
                return null;
            }

        }

        public async Task<PageList<QuizAnswerCPDtos>> GetQuizAnswerList(ListSearchQuizAnswerCP quizQuestion)
        {
            try
            {
                var quizanswer = from a in _quizAnswerCPtRepository.AsQueryable()
                                 join b in _quizQuestionCPtRepository.AsQueryable() on a.IdQuizQuestion equals b.Id
                                 select new QuizAnswerCPDtos()
                                 {
                                     Id = a.Id,
                                     QuestionCode = b.QuestionCode,
                                     Answer = a.Answer,
                                     IdQuizQuestion = a.IdQuizQuestion,
                                 };
                if (quizQuestion.QuestionCode != null)
                {
                    quizanswer = quizanswer.Where(x => x.QuestionCode == quizQuestion.QuestionCode);
                }
                if (quizQuestion.Answer != null)
                {
                    quizanswer = quizanswer.Where(x => x.Answer == quizQuestion.Answer);
                }
                var count = await quizanswer.CountAsync();
                var data = await quizanswer.Skip((quizQuestion.PageNumber - 1) * quizQuestion.PageSize).Take(quizQuestion.PageSize).ToListAsync();
                return new PageList<QuizAnswerCPDtos>(data, count, quizQuestion.PageNumber, quizQuestion.PageSize);
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public async Task<int> UpdateQuizAnswerCP(Guid id, QuizAnswerCPVm quizAnswer)
        {
            try
            {
                var quizzanswerdb = await _quizAnswerCPtRepository.AsQueryable().FirstOrDefaultAsync(c => Guid.Equals(id, c.Id));
                quizzanswerdb.IdQuizQuestion = quizAnswer.IdQuizQuestion;
                quizzanswerdb.Answer = quizAnswer.Answer;
                await _quizAnswerCPtRepository.UpdateAsync(quizzanswerdb);
                await _quizAnswerCPtRepository.SaveChangesAsync();
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }

        }
    }
}
