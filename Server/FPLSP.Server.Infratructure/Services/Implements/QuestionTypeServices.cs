using AutoMapper;
using AutoMapper.QueryableExtensions;
using FPLSP.Server.Data.Repositories.Interfaces;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos.QuestionType;
using FPLSP.Server.Domain.Entities.UsesParts;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels.QuestionType;
using Microsoft.EntityFrameworkCore;

namespace FPLSP.Server.Infrastructure.Services.Implements
{
    public class QuestionTypeServices : IQuestionTypeServices
    {
        private IRepository<QuestionType> _questionTypeRep;
        private readonly IMapper _mapper;
        public QuestionTypeServices(IRepository<QuestionType> questionTypeRep, IMapper mapper)
        {
            _questionTypeRep = questionTypeRep ?? throw new ArgumentNullException(nameof(questionTypeRep));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        public Task<IQueryable<QuestionTypeDto>> GetAll()
        {
            return Task.FromResult(_questionTypeRep.AsQueryable().ProjectTo<QuestionTypeDto>(_mapper.ConfigurationProvider));
        }
        /// <summary>
        /// Thêm QuestionType
        /// </summary>
        /// <param name="questionTypeVm">Truyền vào view models</param>
        /// <returns></returns>
        public async Task<bool> Add(QuestionTypeVm questionTypeVm)
        {
            try
            {
                await _questionTypeRep.AddAsync(new QuestionType()
                {
                    Id = questionTypeVm.Id,
                    QuestionTypeName = questionTypeVm.QuestionTypeName,
                    QuestionForm = questionTypeVm.QuestionForm
                });
                await _questionTypeRep.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        /// <summary>
        /// Update question type
        /// </summary>
        /// <param name="Id">Truyền vào Id để tìm ra bản ghi </param>
        /// <param name="questionTypeVm">Truyền vào dữ liệu cập nhật mới</param>
        /// <returns></returns>
        public async Task<bool> Update(Guid Id, QuestionTypeVm questionTypeVm)
        {
            try
            {
                var questionType = _questionTypeRep.AsQueryable().FirstOrDefault(c => c.Id == Id);
                if (questionType != null)
                {
                    questionType.QuestionTypeName = questionTypeVm.QuestionTypeName;
                    questionType.QuestionForm = questionTypeVm.QuestionForm;
                    await _questionTypeRep.UpdateAsync(questionType);
                    await _questionTypeRep.SaveChangesAsync();
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<QuestionTypeVm> Get(Guid Id)
        {
            var question = _questionTypeRep.AsQueryable().ProjectTo<QuestionTypeVm>(_mapper.ConfigurationProvider).FirstOrDefault(c => c.Id == Id);
            return question;
        }
        /// <summary>
        /// Phân trang List Question
        /// </summary>
        /// <param name="questionTypeSearch">Truyền từ bên trên xuống để phân trang</param>
        /// <returns></returns>
        public async Task<PageList<QuestionTypeDto>> GetPageList(QuestionTypeSearch questionTypeSearch)
        {
            var listQuestion = from a in _questionTypeRep.AsQueryable()
                               select new QuestionTypeDto()
                               {
                                   Id = a.Id,
                                   QuestionTypeName = a.QuestionTypeName,
                                   QuestionForm = a.QuestionForm
                               };
            if (questionTypeSearch.QuestionForm != null)
            {
                listQuestion = listQuestion.Where(p => p.QuestionForm == questionTypeSearch.QuestionForm);
            }
            if (questionTypeSearch.QuestionTypeName != null)
            {
                listQuestion = listQuestion.Where(p => p.QuestionTypeName.Contains(questionTypeSearch.QuestionTypeName));
            }
            var count = await listQuestion.CountAsync();
            var data = await listQuestion.Skip((questionTypeSearch.PageNumber - 1) * questionTypeSearch.PageSize).Take(questionTypeSearch.PageSize).ToListAsync();
            return new PageList<QuestionTypeDto>(data, count, questionTypeSearch.PageNumber, questionTypeSearch.PageSize);
        }
    }
}
