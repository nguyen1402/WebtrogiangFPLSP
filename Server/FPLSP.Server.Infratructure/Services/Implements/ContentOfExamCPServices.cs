using FPLSP.Server.Data.Repositories.Interfaces;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels.ContentOfExamsCP;
using Microsoft.EntityFrameworkCore;

namespace FPLSP.Server.Infrastructure.Services.Implements
{
    public class ContentOfExamCPServices : IContentOfExamCPServices
    {
        private readonly IRepository<ContentOfExamCP> _repository;

        public ContentOfExamCPServices(IRepository<ContentOfExamCP> repository)
        {
            _repository = repository;
        }

        public async Task<ContentOfExamCP> CreateCoeCp(ContentOfExamCP contentOfExamCP)
        {
            await _repository.AddAsync(contentOfExamCP);
            await _repository.SaveChangesAsync();
            return contentOfExamCP;
        }

        public async Task<ContentOfExamCP> DeleteCoeCp(Guid id)
        {
            var delete = _repository.AsQueryable().FirstOrDefault(c => Guid.Equals(id, c.Id));
            await _repository.RemoveAsync(delete);
            await _repository.SaveChangesAsync();
            return delete;
        }

        public async Task<ContentOfExamCP> GetCoeCPById(Guid id)
        {
            var query = await _repository.AsQueryable().FirstOrDefaultAsync(c => c.Id == id);

            return query;
        }

        public async Task<PageList<ContentOfExamCP>> GetCoeCpList(CoeListSearchVm coeListSearchVm)
        {
            var query = _repository.AsQueryable();
            if (coeListSearchVm.Status != null)
            {
                query = query.Where(x => x.Status == Convert.ToInt32(coeListSearchVm.Status));
            }
            if (coeListSearchVm.CoeCode != null)
            {
                query = query.Where(x => x.CoeCode.ToLower().Contains(coeListSearchVm.CoeCode.ToLower()) || x.CoeCode.ToLower().Contains(coeListSearchVm.CoeCode.ToLower()));
            }
            if (coeListSearchVm.Content != null)
            {
                query = query.Where(x => x.Content.ToLower().Contains(coeListSearchVm.Content.ToLower()) || x.Content.ToLower().Contains(coeListSearchVm.Content.ToLower()));
            }
            var count = await query.CountAsync();
            var data = await query.Skip((coeListSearchVm.PageNumber - 1) * coeListSearchVm.PageSize).Take(coeListSearchVm.PageSize).ToListAsync();
            return new PageList<ContentOfExamCP>(data, count, coeListSearchVm.PageNumber, coeListSearchVm.PageSize);
        }

        public Task<List<ContentOfExamCP>> GetCoeCpListAll()
        {
            var result = _repository.AsQueryable().ToList();
            return Task.FromResult(result);
        }

        public async Task<PageList<ContentOfExamCP>> GetCoeCpListByExamId(Guid Id, CoeListSearchVm coeListSearchVm)
        {
            var query = _repository.AsQueryable().Where(c => c.ExamId == Id);

            var count = await query.CountAsync();
            var data = await query.Skip((coeListSearchVm.PageNumber - 1) * coeListSearchVm.PageSize).Take(coeListSearchVm.PageSize).ToListAsync();
            return new PageList<ContentOfExamCP>(data, count, coeListSearchVm.PageNumber, coeListSearchVm.PageSize);

        }

        public async Task<ContentOfExamCP> UpdateCoeCp(Guid id, CoeUpdateVm coeUpdateVm)
        {
            var updateCP = _repository.AsQueryable().FirstOrDefault(c => Guid.Equals(id, c.Id));
            updateCP = new ContentOfExamCP()
            {
                Id = id,
                EndDate = coeUpdateVm.EndDate,
                CoeCode = coeUpdateVm.CoeCode,
                DateStarted = coeUpdateVm.DateStarted,
                Level = coeUpdateVm.Level,
                Status = coeUpdateVm.Status,
                Content = coeUpdateVm.Content,
                ExamId = coeUpdateVm.ExamId,
                TotalOfQuestions = coeUpdateVm.TotalOfQuestions,
                QuestionType = coeUpdateVm.QuestionType

            };

            await _repository.UpdateAsync(updateCP);
            await _repository.SaveChangesAsync();
            return updateCP;
        }

    }
}
