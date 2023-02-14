using FPLSP.Server.Data.FPLSPDbContext;
using FPLSP.Server.Data.Repositories.Interfaces;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Domain.Entities.UserParts;
using FPLSP.Server.Domain.Entities.UsesParts;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels.QuizQuesstionQuizUP;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace FPLSP.Server.Infrastructure.Services.Implements
{
    public class QuizQuesstionQuizUPServices : IQuizQuesstionQuizUPServices
    {
        private readonly IRepository<QuizQuestionQuizUP> _resquizQuiz;
        private readonly IRepository<QuizUP> _resQuizcp;
        private readonly IRepository<SubjectUP> _resSubjectCP;
        private readonly IRepository<QuestionType> _reskoqs;
        private readonly IRepository<QuizQuestionUP> _resquizQuesstion;
        private readonly IRepository<AnswerUP> _resquizAnswer;
        private readonly ApplicationDbContext _dbContext;
        public QuizQuesstionQuizUPServices(IRepository<QuizQuestionQuizUP> resquizQuiz
            , IRepository<QuizUP> resQuizcp
            , IRepository<QuestionType> reskoqs
            , IRepository<QuizQuestionUP> resquizQuesstion
            , IRepository<AnswerUP> resquizAnswer,
            IRepository<SubjectUP> resSubjectCP,
            ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            _resquizQuiz = resquizQuiz;
            _resQuizcp = resQuizcp;
            _reskoqs = reskoqs;
            _resquizQuesstion = resquizQuesstion;
            _resquizAnswer = resquizAnswer;
            _resSubjectCP = resSubjectCP;
        }
        public async Task<int> Create(Guid quizId, QuizQuesstionQuizUPCreateVM create)
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
            var newKOQ = new QuestionType()
            {
                Id = idkdoqs,
                QuestionTypeName = create.QuestionForm.ToString(),
                QuestionForm = create.QuestionForm
            };

            await _reskoqs.AddAsync(newKOQ);
            await _reskoqs.SaveChangesAsync();

            var newquizquesttion = new QuizQuestionUP()
            {
                Id = id,
                QuestionTypeId = idkdoqs,
                QuestionName = create.QuestionName,
                QuestionCode = str_build.ToString(),
                Status = create.StatusQuizQuiz,
                QuestionTital = create.QuestionName,
                ContentQuestion = create.QuestionName,
            };
            await _resquizQuesstion.AddAsync(newquizquesttion);
            await _resquizQuesstion.SaveChangesAsync();

            //var newquizAnswer = new QuizAnswerCP()
            //{
            //    IdQuizQuestion = id,
            //    Answer = create.Answer
            //};
            for (int i = 0; i < create.lsAnswer.Count; i++)
            {
                var newquizAnswer = new AnswerUP()
                {
                    QuizQuestionId = id,
                    Answer = create.lsAnswer[i],
                    IsCorrect = create.lsIsCorrect[i]
                };
                await _resquizAnswer.AddAsync(newquizAnswer);
                await _resquizAnswer.SaveChangesAsync();
            }
            //await _resquizAnswer.AddAsync(newquizAnswer);
            //await _resquizAnswer.SaveChangesAsync();

            var newquizquiz = new QuizQuestionQuizUP()
            {
                QuizQuestionId = id,
                QuizId = quizId,
                Status = create.StatusQuizQuiz
            };
            await _resquizQuiz.AddAsync(newquizquiz);
            await _resquizQuiz.SaveChangesAsync();

            return 1;
        }

        public async Task<int> Delete(Guid quizquesstionId)
        {
            try
            {
                var quizquestion = await _resquizQuesstion.AsQueryable().FirstOrDefaultAsync(p => p.Id == quizquesstionId);
                quizquestion.Status = 0;
                await _resquizQuesstion.UpdateAsync(quizquestion);
                await _resquizQuesstion.SaveChangesAsync();
                var quizquestionquiz = await _resquizQuiz.AsQueryable().FirstOrDefaultAsync(p => p.QuizQuestionId == quizquesstionId);
                quizquestionquiz.Status = 0;
                await _resquizQuiz.UpdateAsync(quizquestionquiz);
                await _resquizQuiz.SaveChangesAsync();
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public async Task<List<QuizQuesstionQuizUPDto>> GetAllCauHoi(Guid idsubject)
        {
            var querry = from c in _resquizQuiz.AsQueryable()
                         join ct in _resquizQuesstion.AsQueryable() on c.QuizQuestionId equals ct.Id
                         join ct2 in _resQuizcp.AsQueryable() on c.QuizId equals ct2.Id
                         join ct4 in _resSubjectCP.AsQueryable() on ct2.SubjectId equals ct4.Id
                         join ct3 in _reskoqs.AsQueryable() on ct.QuestionTypeId equals ct3.Id
                         where ct4.Id == idsubject
                         select new { c, ct, ct2, ct3 };

            var resuals = await querry.Select(x => new QuizQuesstionQuizUPDto()
            {
                QuestionTypeName = x.ct3.QuestionTypeName,
                QuestionForm = x.ct3.QuestionForm,
                QuestionName = x.ct.QuestionName,
                QuestionCode = x.ct.QuestionCode,
                QuestionTypeId = x.ct3.Id,
                StatusQuizQuestion = x.ct.Status,
                StatusQuizQuiz = x.c.Status,
                QuizQuestionId = x.ct.Id,
                QuizId = x.ct2.Id,
            }).ToListAsync();

            return resuals;
        }

        public Task<QuizQuesstionQuizUPDto> GetbyId(Guid quizquesstionId)
        {
            var querry = from c in _resquizQuiz.AsQueryable()
                         join ct in _resquizQuesstion.AsQueryable() on c.QuizQuestionId equals ct.Id
                         join ct2 in _resQuizcp.AsQueryable() on c.QuizId equals ct2.Id
                         join ct3 in _reskoqs.AsQueryable() on ct.QuestionTypeId equals ct3.Id
                         join ct4 in _resquizAnswer.AsQueryable() on ct.Id equals ct4.QuizQuestionId
                         select new { c, ct, ct2, ct3, ct4 };
            var resuals = querry.Select(x => new QuizQuesstionQuizUPDto()
            {
                QuestionTypeName = x.ct3.QuestionTypeName,
                QuestionForm = x.ct3.QuestionForm,
                Answers = querry.Where(c => Equals(quizquesstionId, c.ct.Id)).Select(c => c.ct4.Answer).ToList(),
                lsIsCorrect = querry.Where(c => Equals(quizquesstionId, c.ct.Id)).Select(c => c.ct4.IsCorrect).ToList(),
                QuestionName = x.ct.QuestionName,
                QuestionCode = x.ct.QuestionCode,
                QuestionTypeId = x.ct3.Id,
                StatusQuizQuestion = x.ct.Status,
                StatusQuizQuiz = x.c.Status,
                QuizQuestionId = x.ct.Id,
                QuizId = x.ct2.Id
            }).ToList();

            var resual = resuals.FirstOrDefault(c => Equals(quizquesstionId, c.QuizQuestionId));

            return Task.FromResult(resual);
        }

        public Task<PageList<QuizQuesstionQuizUPDto>> GetPagingParamets(Guid quizId, QuizQuesstionQuizUPListSearch parameters)
        {
            var querry = from c in _resquizQuiz.AsQueryable()
                         join ct in _resquizQuesstion.AsQueryable() on c.QuizQuestionId equals ct.Id
                         join ct2 in _resQuizcp.AsQueryable() on c.QuizId equals ct2.Id
                         join ct3 in _reskoqs.AsQueryable() on ct.QuestionTypeId equals ct3.Id
                         where c.QuizId == quizId
                         select new { c, ct, ct2, ct3 };

            //join ct4 in _resquizAnswer.AsQueryable() on ct.Id equals ct4.IdQuizQuestion
            var resuals = querry.Select(x => new QuizQuesstionQuizUPDto()
            {
                QuestionTypeName = x.ct3.QuestionTypeName,
                QuestionForm = x.ct3.QuestionForm,
                QuestionName = x.ct.QuestionName,
                QuestionCode = x.ct.QuestionCode,
                QuestionTypeId = x.ct3.Id,
                StatusQuizQuestion = x.ct.Status,
                StatusQuizQuiz = x.c.Status,
                QuizQuestionId = x.ct.Id,
                QuizId = x.ct2.Id
            }).ToList();

            if (!string.IsNullOrEmpty(parameters.Name))
                resuals = resuals.Where(x => x.QuestionName.ToLower().Contains(parameters.Name.ToLower())).ToList();
            if (!string.IsNullOrEmpty(parameters.Status.ToString()))
                resuals = resuals.Where(x => x.StatusQuizQuiz == parameters.Status).ToList();

            var count = resuals.Count();

            var data = resuals
               .Skip((parameters.PageNumber - 1) * parameters.PageSize)
               .Take(parameters.PageSize)
               .ToList();
            var result = new PageList<QuizQuesstionQuizUPDto>(data, count
                , parameters.PageNumber
                , parameters.PageSize);
            return Task.FromResult(result);
        }

        public async Task<int> Update(Guid QuizQuestionId, QuizQuesstionQuizUPUpdateVM update)
        {
            var lsQuizAnser = _resquizAnswer.AsQueryable().Where(c => Equals(QuizQuestionId, c.QuizQuestionId)).Select(c => c.Id).ToList();


            Update2(QuizQuestionId, update);




            return 1;

        }
        public void Update2(Guid QuizQuestionId, QuizQuesstionQuizUPUpdateVM update)
        {
            var quizquestion = _resquizQuesstion.AsQueryable().FirstOrDefault(c => Equals(QuizQuestionId, c.Id));
            quizquestion.QuestionName = update.QuestionName;
            quizquestion.Status = update.StatusQuizQuiz;
            _resquizQuesstion.UpdateAsync(quizquestion);
            _resquizQuesstion.SaveChangesAsync();

        }
        public void Update3(Guid Id, string answer, bool isCorrect, Guid QuizQuestionId, QuizQuesstionQuizUPUpdateVM update)
        {
            var quizquestion = _resquizQuesstion.AsQueryable().FirstOrDefault(c => Equals(QuizQuestionId, c.Id));
            var QuizAnserud = _resquizAnswer.AsQueryable().FirstOrDefault(c => Equals(Id, c.Id));
            QuizAnserud.Answer = answer;
            QuizAnserud.IsCorrect = isCorrect;
            _resquizAnswer.UpdateAsync(QuizAnserud);
            _resquizAnswer.SaveChangesAsync();

        }
        public async Task<bool> DeleteListQuestionQuizUP(List<Guid> ListIdQuizQuesstionQuiz)
        {
            try
            {
                foreach (var item in ListIdQuizQuesstionQuiz)
                {
                    var quizquestion = await _resquizQuesstion.AsQueryable().FirstOrDefaultAsync(p => p.Id == item);
                    quizquestion.Status = 0;
                    await _resquizQuesstion.UpdateAsync(quizquestion);
                    await _resquizQuesstion.SaveChangesAsync();
                    var quizquestionquiz = await _resquizQuiz.AsQueryable().FirstOrDefaultAsync(p => p.QuizQuestionId == item);
                    quizquestionquiz.Status = 0;
                    await _resquizQuiz.UpdateAsync(quizquestionquiz);
                    await _resquizQuiz.SaveChangesAsync();
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
