using FPLSP.Server.Data.Repositories.Interfaces;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels.ExamLinks;
using Microsoft.EntityFrameworkCore;

namespace FPLSP.Server.Infrastructure.Services.Implements
{
    public class ExamLinkCPServices : IExamLinkCPServices
    {
        private readonly IRepository<ExamLinkCP> _examLinkRepository;

        public ExamLinkCPServices(IRepository<ExamLinkCP> examLinkRepository)
        {
            _examLinkRepository = examLinkRepository;
        }

        public async Task<ExamLinkCP> CreateExamLinkCP(ExamLinkCP examLinkCP)
        {
            await _examLinkRepository.AddAsync(examLinkCP);
            await _examLinkRepository.SaveChangesAsync();
            return examLinkCP;
        }

        public async Task<ExamLinkCP> DeleteExamLinkCP(Guid id)
        {
            var exam = _examLinkRepository.AsQueryable().FirstOrDefault(c => Guid.Equals(id, c.Id));
            await _examLinkRepository.RemoveAsync(exam);
            await _examLinkRepository.SaveChangesAsync();
            return exam;
        }

        public async Task<ExamLinkCP> GetExamLinkCPById(Guid Id)
        {
            var query = await _examLinkRepository.AsQueryable().FirstOrDefaultAsync(c => c.Id == Id);

            return query;
        }

        public Task<List<ExamLinkCP>> GetExamLinkCPAll()
        {
            var result = _examLinkRepository.AsQueryable().ToList();
            return Task.FromResult(result);
        }

        public async Task<PageList<ExamLinkCP>> GetExamLinkCPList(ExamLinkListSearchVm examLinkListSearch)
        {
            var query = _examLinkRepository.AsQueryable();
            if (examLinkListSearch.Status != null)
            {
                query = query.Where(x => x.Status == Convert.ToInt32(examLinkListSearch.Status));
            }
            if (examLinkListSearch.ExamLinkCode != null)
            {
                query = query.Where(x => x.ExamLinkCode.ToLower().Contains(examLinkListSearch.ExamLinkCode.ToLower()) || x.ExamLinkCode.ToLower().Contains(examLinkListSearch.ExamLinkCode.ToLower()));
            }
            if (examLinkListSearch.Path != null)
            {
                query = query.Where(x => x.Path.ToLower().Contains(examLinkListSearch.Path.ToLower()) || x.Path.ToLower().Contains(examLinkListSearch.Path.ToLower()));
            }
            if (examLinkListSearch.CreatedDay != null)
            {
                query = query.Where(x => x.CreatedDay >= examLinkListSearch.CreatedDay);
            }
            var count = await query.CountAsync();
            var data = await query.Skip((examLinkListSearch.PageNumber - 1) * examLinkListSearch.PageSize).Take(examLinkListSearch.PageSize).ToListAsync();
            return new PageList<ExamLinkCP>(data, count, examLinkListSearch.PageNumber, examLinkListSearch.PageSize);
        }

        public async Task<PageList<ExamLinkCP>> GetExamLinkCPListByExamId(Guid ExamId, ExamLinkListSearchVm examLinkListSearch)
        {
            var query = _examLinkRepository.AsQueryable().Where(c => c.ExamId == ExamId);

            var count = await query.CountAsync();
            var data = await query.Skip((examLinkListSearch.PageNumber - 1) * examLinkListSearch.PageSize).Take(examLinkListSearch.PageSize).ToListAsync();
            return new PageList<ExamLinkCP>(data, count, examLinkListSearch.PageNumber, examLinkListSearch.PageSize);
        }



        public async Task<ExamLinkCP> UpdateExamLinkCP(Guid id, ExamLinkUpdateVm examLinkUpdateVm)
        {
            var examLinkCP = _examLinkRepository.AsQueryable().FirstOrDefault(c => Guid.Equals(id, c.Id));
            examLinkCP = new ExamLinkCP()
            {
                Id = id,
                ExamId = examLinkUpdateVm.ExamId,
                ExamLinkCode = examLinkUpdateVm.ExamLinkCode,
                Path = examLinkUpdateVm.Path,
                ExpirationDate = examLinkUpdateVm.ExpirationDate,
                Status = examLinkUpdateVm.Status
            };

            await _examLinkRepository.UpdateAsync(examLinkCP);
            await _examLinkRepository.SaveChangesAsync();
            return examLinkCP;
        }
    }
}
