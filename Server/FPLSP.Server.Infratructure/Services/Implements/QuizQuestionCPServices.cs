using AutoMapper;
using FPLSP.Server.Data.Repositories.Interfaces;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos.QuizQuestionCPDtos;
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels.QuizQuestionCPVm;
using Microsoft.EntityFrameworkCore;

namespace FPLSP.Server.Infrastructure.Services.Implements
{

    public class QuizQuestionCPServices : IQuizQuestionCPServices
    {

        private readonly IRepository<QuizQuestionCP> _quizquestionCPtRepository;
        private readonly IRepository<KindoOfQuestionCP> _koqtCPtRepository;
        private readonly IMapper _mapper;

        public QuizQuestionCPServices(IRepository<QuizQuestionCP> quizquestionCPtRepository, IRepository<KindoOfQuestionCP> koqtCPtRepository, IMapper mapper)
        {
            _quizquestionCPtRepository = quizquestionCPtRepository ?? throw new ArgumentNullException(nameof(quizquestionCPtRepository)); ;
            _koqtCPtRepository = koqtCPtRepository ?? throw new ArgumentNullException(nameof(koqtCPtRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<int> CreateQuizQuestionCP(CreateQuizQuestionCPVm quizQuestion)
        {
            try
            {
                var newquizquesttion = new QuizQuestionCP()
                {
                    KindoOfQuestionId = quizQuestion.KindoOfQuestionId,
                    QuestionName = quizQuestion.QuestionName,
                    QuestionCode = quizQuestion.QuestionCode,
                    Status = quizQuestion.Status,
                };
                await _quizquestionCPtRepository.AddAsync(newquizquesttion);
                await _quizquestionCPtRepository.SaveChangesAsync();
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }

        }

        public async Task<int> DeleteQuizQuestionCP(Guid id)
        {
            try
            {
                var quizquestion = await _quizquestionCPtRepository.AsQueryable().FirstOrDefaultAsync(c => Guid.Equals(id, c.Id));
                await _quizquestionCPtRepository.RemoveAsync(quizquestion);
                await _quizquestionCPtRepository.SaveChangesAsync();
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }

        }

        public async Task<QuizQuestionCPVm> GetQuizQuestionCPbyId(Guid id)
        {
            try
            {
                var quizquestion = from a in _quizquestionCPtRepository.AsQueryable()
                                   join b in _koqtCPtRepository.AsQueryable() on a.KindoOfQuestionId equals b.Id
                                   select new QuizQuestionCPVm()
                                   {
                                       Id = a.Id,
                                       KindoOfQuestionId = a.KindoOfQuestionId,
                                       QuizQuestionForm = b.QuestionForm,
                                       QuestionTypeName = b.QuestionTypeName,
                                       QuestionCode = a.QuestionCode,
                                       QuestionName = a.QuestionName,
                                       Status = a.Status,

                                   };
                var quiz = await quizquestion.FirstOrDefaultAsync(p => p.Id == id);
                return quiz;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public async Task<PageList<QuizQuestionCPDtos>> GetQuizQuestionList(ListQuizQuestionSearch quizQuestion)
        {
            try
            {
                var quizquestions = from a in _quizquestionCPtRepository.AsQueryable()
                                    join b in _koqtCPtRepository.AsQueryable() on a.KindoOfQuestionId equals b.Id
                                    select new QuizQuestionCPDtos()
                                    {
                                        Id = a.Id,
                                        KindoOfQuestionId = a.KindoOfQuestionId,
                                        QuizQuestionForm = b.QuestionForm,
                                        QuestionTypeName = b.QuestionTypeName,
                                        QuestionCode = a.QuestionCode,
                                        QuestionName = a.QuestionName,
                                        Status = a.Status,

                                    };

                if (quizQuestion.KindoOfQuestionId != null)
                {
                    quizquestions = quizquestions.Where(x => x.KindoOfQuestionId == quizQuestion.KindoOfQuestionId);
                }
                if (quizQuestion.QuizQuestionName != null)
                {
                    quizquestions = quizquestions.Where(x => x.QuestionName.ToLower().Contains(quizQuestion.QuizQuestionName.ToLower()));
                }
                if (quizQuestion.Status != null)
                {
                    quizquestions = quizquestions.Where(x => x.Status == quizQuestion.Status);
                }
                var count = await quizquestions.CountAsync();
                var data = await quizquestions.Skip((quizQuestion.PageNumber - 1) * quizQuestion.PageSize).Take(quizQuestion.PageSize).ToListAsync();
                return new PageList<QuizQuestionCPDtos>(data, count, quizQuestion.PageNumber, quizQuestion.PageSize);
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public async Task<int> UpdateQuizQuestionCP(Guid id, QuizQuestionCPVm quizQuestion)
        {
            try
            {
                var quizzquestions = await _quizquestionCPtRepository.AsQueryable().FirstOrDefaultAsync(c => Guid.Equals(id, c.Id));
                quizzquestions.KindoOfQuestionId = quizQuestion.KindoOfQuestionId;
                quizzquestions.QuestionName = quizQuestion.QuestionName;
                quizzquestions.QuestionCode = quizQuestion.QuestionCode;
                quizzquestions.Status = quizQuestion.Status;
                await _quizquestionCPtRepository.UpdateAsync(quizzquestions);
                await _quizquestionCPtRepository.SaveChangesAsync();
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }

        }
    }
}
