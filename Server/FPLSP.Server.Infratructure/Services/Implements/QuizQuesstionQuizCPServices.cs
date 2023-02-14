using FPLSP.Server.Data.Repositories.Interfaces;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels.QuizQuesstionQuizCP;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace FPLSP.Server.Infrastructure.Services.Implements
{
    public class QuizQuesstionQuizCPServices : IQuizQuesstionQuizCPServices
    {
        private readonly IRepository<QuizQuestionQuizCP> _resquizQuiz;
        private readonly IRepository<QuizCP> _resQuizcp;
        private readonly IRepository<SubjectCP> _resSubjectCP;
        private readonly IRepository<KindoOfQuestionCP> _reskoqs;
        private readonly IRepository<QuizQuestionCP> _resquizQuesstion;
        private readonly IRepository<QuizAnswerCP> _resquizAnswer;
        public QuizQuesstionQuizCPServices(IRepository<QuizQuestionQuizCP> resquizQuiz
            , IRepository<QuizCP> resQuizcp
            , IRepository<KindoOfQuestionCP> reskoqs
            , IRepository<QuizQuestionCP> resquizQuesstion
            , IRepository<QuizAnswerCP> resquizAnswer,
            IRepository<SubjectCP> resSubjectCP)
        {
            _resquizQuiz = resquizQuiz;
            _resQuizcp = resQuizcp;
            _reskoqs = reskoqs;
            _resquizQuesstion = resquizQuesstion;
            _resquizAnswer = resquizAnswer;
            _resSubjectCP = resSubjectCP;
        }
        public async Task<int> Create(Guid quizId, QuizQuesstionQuizCPCreateVM create)
        {
            try
            {
                var id = Guid.NewGuid();
                var idkdoqs = Guid.NewGuid();

                StringBuilder str_build = new StringBuilder();
                Random random = new Random();

                char letter;

                for (int i = 0; i < 5; i++)
                {
                    double flt = random.NextDouble();
                    int shift = Convert.ToInt32(Math.Floor(25 * flt));
                    letter = Convert.ToChar(shift + 65);
                    str_build.Append(letter);
                }
                var newKOQ = new KindoOfQuestionCP()
                {
                    Id = idkdoqs,
                    QuestionTypeName = create.QuestionForm.ToString(),
                    QuestionForm = create.QuestionForm
                };

                await _reskoqs.AddAsync(newKOQ);
                await _reskoqs.SaveChangesAsync();
                var countquizquestion = _resquizQuiz.AsQueryable().ToList().Where(p => p.QuizId == quizId);
                var newquizquesttion = new QuizQuestionCP()
                {
                    Id = id,
                    KindoOfQuestionId = idkdoqs,
                    QuestionName = "Câu " + (countquizquestion.Count() + 1),
                    QuestionCode = str_build.ToString(),
                    Status = create.StatusQuizQuiz,
                    QuestionTital = create.ContentQuestion,
                    ContentQuestion = create.ContentQuestion,
                };
                await _resquizQuesstion.AddAsync(newquizquesttion);
                await _resquizQuesstion.SaveChangesAsync();

                for (int i = 0; i < create.lsAnswer.Count; i++)
                {
                    var newquizAnswer = new QuizAnswerCP()
                    {
                        IdQuizQuestion = id,
                        Answer = create.lsAnswer[i],
                        IsCorrect = create.lsIsCorrect[i]
                    };
                    await _resquizAnswer.AddAsync(newquizAnswer);
                    await _resquizAnswer.SaveChangesAsync();
                }

                var newquizquiz = new QuizQuestionQuizCP()
                {
                    QuizQuestionId = id,
                    QuizId = quizId,
                    Status = create.StatusQuizQuiz
                };
                await _resquizQuiz.AddAsync(newquizquiz);
                await _resquizQuiz.SaveChangesAsync();

                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }

        }

        public async Task<int> Delete(Guid quizquesstionId)
        {
            try
            {
                var quizquestion =  _resquizQuesstion.AsQueryable().ToList().FirstOrDefault(p => p.Id == quizquesstionId);
                if (quizquestion.Status == 0)
                {
                    quizquestion.Status = 1;
                    await _resquizQuesstion.UpdateAsync(quizquestion);
                    await _resquizQuesstion.SaveChangesAsync();

                }
                else
                {
                    quizquestion.Status = 0;
                    await _resquizQuesstion.UpdateAsync(quizquestion);
                    await _resquizQuesstion.SaveChangesAsync();
                }


                var quizquestionquiz =  _resquizQuiz.AsQueryable().ToList().FirstOrDefault(p => p.QuizQuestionId == quizquesstionId);
                if (quizquestionquiz.Status == 0)
                {
                    quizquestionquiz.Status = 1;
                    await _resquizQuiz.UpdateAsync(quizquestionquiz);
                    await _resquizQuiz.SaveChangesAsync();

                }
                else
                {
                    quizquestionquiz.Status = 0;
                    await _resquizQuiz.UpdateAsync(quizquestionquiz);
                    await _resquizQuiz.SaveChangesAsync();
                }
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public async Task<List<QuizQuesstionQuizCPDto>> GetAllCauHoi(Guid idsubject)
        {
            try
            {
                var querry = from c in _resquizQuiz.AsQueryable().ToList()
                             join ct in _resquizQuesstion.AsQueryable().ToList() on c.QuizQuestionId equals ct.Id
                             join ct2 in _resQuizcp.AsQueryable().ToList() on c.QuizId equals ct2.Id
                             join ct4 in _resSubjectCP.AsQueryable().ToList() on ct2.SubjectId equals ct4.Id
                             join ct3 in _reskoqs.AsQueryable().ToList() on ct.KindoOfQuestionId equals ct3.Id
                             where ct4.Id == idsubject
                             select new { c, ct, ct2, ct3 };

                var resuals =  querry.Select(x => new QuizQuesstionQuizCPDto()
                {
                    QuestionTypeName = x.ct3.QuestionTypeName,
                    QuestionForm = x.ct3.QuestionForm,
                    QuestionName = x.ct.QuestionName,
                    QuestionCode = x.ct.QuestionCode,
                    KindoOfQuestionId = x.ct3.Id,
                    StatusQuizQuestion = x.ct.Status,
                    StatusQuizQuiz = x.c.Status,
                    QuizQuestionId = x.ct.Id,
                    QuizId = x.ct2.Id,
                }).ToList();

                return resuals;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public async Task<QuizQuesstionQuizCPDto> GetbyId(Guid quizquesstionId)
        {
            try
            {
                var querry = from c in _resquizQuiz.AsQueryable().ToList()
                             join ct in _resquizQuesstion.AsQueryable().ToList() on c.QuizQuestionId equals ct.Id
                             join ct2 in _resQuizcp.AsQueryable().ToList() on c.QuizId equals ct2.Id
                             join ct3 in _reskoqs.AsQueryable().ToList() on ct.KindoOfQuestionId equals ct3.Id
                             join ct4 in _resquizAnswer.AsQueryable().ToList() on ct.Id equals ct4.IdQuizQuestion
                             select new { c, ct, ct2, ct3, ct4 };
                var resuals =  querry.Select(x => new QuizQuesstionQuizCPDto()
                {
                    QuestionTypeName = x.ct3.QuestionTypeName,
                    QuestionForm = x.ct3.QuestionForm,
                    Answers = querry.Where(c => Equals(quizquesstionId, c.ct.Id)).Select(c => c.ct4.Answer).ToList(),
                    lsIsCorrect = querry.Where(c => Equals(quizquesstionId, c.ct.Id)).Select(c => c.ct4.IsCorrect).ToList(),
                    QuestionName = x.ct.QuestionName,
                    QuestionCode = x.ct.QuestionCode,
                    KindoOfQuestionId = x.ct3.Id,
                    StatusQuizQuestion = x.ct.Status,
                    StatusQuizQuiz = x.c.Status,
                    QuizQuestionId = x.ct.Id,
                    QuizId = x.ct2.Id,
                    ContentQuestion = x.ct.ContentQuestion
                }).ToList();

                var resual = resuals.FirstOrDefault(c => Equals(quizquesstionId, c.QuizQuestionId));

                return resual;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public async Task<PageList<QuizQuesstionQuizCPDto>> GetPagingParamets(Guid quizId, QuizQuesstionQuizCPListSearch parameters)
        {
            try
            {
                var querry = from c in _resquizQuiz.AsQueryable().ToList()
                             join ct in _resquizQuesstion.AsQueryable().ToList() on c.QuizQuestionId equals ct.Id
                             join ct2 in _resQuizcp.AsQueryable().ToList() on c.QuizId equals ct2.Id
                             join ct3 in _reskoqs.AsQueryable().ToList() on ct.KindoOfQuestionId equals ct3.Id
                             where c.QuizId == quizId
                             select new { c, ct, ct2, ct3 };

                //join ct4 in _resquizAnswer.AsQueryable().ToList() on ct.Id equals ct4.IdQuizQuestion
                var resuals =  querry.Select(x => new QuizQuesstionQuizCPDto()
                {
                    QuestionTypeName = x.ct3.QuestionTypeName,
                    QuestionForm = x.ct3.QuestionForm,
                    QuestionName = x.ct.QuestionName,
                    QuestionCode = x.ct.QuestionCode,
                    KindoOfQuestionId = x.ct3.Id,
                    StatusQuizQuestion = x.ct.Status,
                    StatusQuizQuiz = x.c.Status,
                    QuizQuestionId = x.ct.Id,
                    QuizId = x.ct2.Id,
                    ContentQuestion = x.ct.ContentQuestion
                }).ToList();

                if (!string.IsNullOrEmpty(parameters.Name))
                    resuals = resuals.Where(x => x.QuestionName.ToLower().Contains(parameters.Name.ToLower())).ToList();
                if (parameters.Status != 3)
                    resuals = resuals.Where(x => x.StatusQuizQuiz == parameters.Status).ToList();
                resuals = resuals.OrderBy(p => p.QuestionName).ToList();
                var count = resuals.Count();

                var data = resuals
                   .Skip((parameters.PageNumber - 1) * parameters.PageSize)
                   .Take(parameters.PageSize)
                   .ToList();

                return new PageList<QuizQuesstionQuizCPDto>(data, count
                    , parameters.PageNumber
                    , parameters.PageSize);
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public async Task<int> Update(Guid QuizQuestionId, QuizQuesstionQuizCPUpdateVM update)
        {
            try
            {
                var lsQuizAnser = _resquizAnswer.AsQueryable().ToList().Where(c => Equals(QuizQuestionId, c.IdQuizQuestion)).Select(c => c.Id).ToList();
                var quizquestion =  _resquizQuesstion.AsQueryable().ToList().FirstOrDefault(c => Equals(QuizQuestionId, c.Id));

                quizquestion.ContentQuestion = update.ContentQuestion;
                quizquestion.Status = update.StatusQuizQuiz;
                await _resquizQuesstion.UpdateAsync(quizquestion);
                await _resquizQuesstion.SaveChangesAsync();

                var quizquestionquiz =  _resquizQuiz.AsQueryable().ToList().FirstOrDefault(p => p.QuizQuestionId == QuizQuestionId);
                quizquestionquiz.Status = update.StatusQuizQuiz;
                await _resquizQuiz.UpdateAsync(quizquestionquiz);
                await _resquizQuiz.SaveChangesAsync();

                for (int i = 0; i < update.lsAnswer.Count; i++)
                {
                    var QuizAnserud =  _resquizAnswer.AsQueryable().ToList().FirstOrDefault(c => Equals(lsQuizAnser[i], c.Id));

                    QuizAnserud.Answer = update.lsAnswer[i];
                    QuizAnserud.IsCorrect = update.lsIsCorrect[i];
                    await _resquizAnswer.UpdateAsync(QuizAnserud);
                    await _resquizAnswer.SaveChangesAsync();
                }


                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }


        }

        public async Task<bool> DeleteListQuestionQuizCP(List<Guid> ListIdQuizQuesstionQuiz)
        {
            try
            {
                foreach (var item in ListIdQuizQuesstionQuiz)
                {
                    var quizquestion =  _resquizQuesstion.AsQueryable().ToList().FirstOrDefault(p => p.Id == item);
                    if (quizquestion.Status == 0)
                    {
                        quizquestion.Status = 1;
                        await _resquizQuesstion.UpdateAsync(quizquestion);
                        await _resquizQuesstion.SaveChangesAsync();

                    }
                    else
                    {
                        quizquestion.Status = 0;
                        await _resquizQuesstion.UpdateAsync(quizquestion);
                        await _resquizQuesstion.SaveChangesAsync();
                    }
                    var quizquestionquiz =  _resquizQuiz.AsQueryable().ToList().FirstOrDefault(p => p.QuizQuestionId == item);
                    if (quizquestionquiz.Status == 0)
                    {
                        quizquestionquiz.Status = 1;
                        await _resquizQuiz.UpdateAsync(quizquestionquiz);
                        await _resquizQuiz.SaveChangesAsync();

                    }
                    else
                    {
                        quizquestionquiz.Status = 0;
                        await _resquizQuiz.UpdateAsync(quizquestionquiz);
                        await _resquizQuiz.SaveChangesAsync();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
