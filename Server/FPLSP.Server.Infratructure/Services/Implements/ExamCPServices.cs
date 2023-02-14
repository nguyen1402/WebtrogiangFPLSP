using FPLSP.Server.Data.Repositories.Interfaces;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels.Exams;
using Microsoft.EntityFrameworkCore;

namespace FPLSP.Server.Infrastructure.Services.Implements
{
    public class ExamCPServices : IExamCPServices
    {
        private readonly IRepository<ExamCP> _examRepository;

        public ExamCPServices(IRepository<ExamCP> examRepository)
        {
            _examRepository = examRepository;
        }

        public async Task<ExamCP> CreateExamCP(ExamCP ExamCP)
        {
            await _examRepository.AddAsync(ExamCP);
            await _examRepository.SaveChangesAsync();
            return ExamCP;
        }

        public async Task<ExamCP> DeleteExamCP(Guid id)
        {
            var exam = _examRepository.AsQueryable().FirstOrDefault(c => Guid.Equals(id, c.Id));
            await _examRepository.RemoveAsync(exam);
            await _examRepository.SaveChangesAsync();
            return exam;
        }

        public async Task<PageList<ExamCP>> GetExamCPList(ExamListSearchVm ExamListSearchVm)
        {
            var query = _examRepository.AsQueryable();
            if (ExamListSearchVm.Status != null)
            {
                query = query.Where(x => x.Status == Convert.ToInt32(ExamListSearchVm.Status));
            }
            if (ExamListSearchVm.ExamName != null)
            {
                query = query.Where(x => x.ExamName.ToLower().Contains(ExamListSearchVm.ExamName.ToLower()) || x.ExamName.ToLower().Contains(ExamListSearchVm.ExamName.ToLower()));
            }
            if (ExamListSearchVm.ExamCode != null)
            {
                query = query.Where(x => x.ExamCode.ToLower().Contains(ExamListSearchVm.ExamCode.ToLower()) || x.ExamCode.ToLower().Contains(ExamListSearchVm.ExamCode.ToLower()));
            }
            var count = await query.CountAsync();
            var data = await query.Skip((ExamListSearchVm.PageNumber - 1) * ExamListSearchVm.PageSize).Take(ExamListSearchVm.PageSize).ToListAsync();
            return new PageList<ExamCP>(data, count, ExamListSearchVm.PageNumber, ExamListSearchVm.PageSize);
        }

        public Task<List<ExamCPDto>> GetAllExamCPList()
        {
            var temp = new List<ExamCPDto>();
            var result = _examRepository.AsQueryable().ToList();
            foreach (var VARIABLE in result)
            {
                var add = new ExamCPDto()
                {
                    Id = VARIABLE.Id,
                    ExamCode = VARIABLE.ExamCode,
                    ExamName = VARIABLE.ExamName,
                    Status = VARIABLE.Status,
                    SubjectId = VARIABLE.SubjectId
                };
                temp.Add(add);
            }
            return Task.FromResult(temp);
        }

        public async Task<ExamCP> GetExamCPById(Guid ExamId)
        {
            var query = await _examRepository.AsQueryable().FirstOrDefaultAsync(c => c.Id == ExamId);

            return query;
        }
        public async Task<PageList<ExamCP>> GetExamCPListBySubjectId(Guid SubjectId, ExamListSearchVm ExamListSearchVm)
        {
            var query = _examRepository.AsQueryable().Where(c => c.SubjectId == SubjectId);

            var count = await query.CountAsync();
            var data = await query.Skip((ExamListSearchVm.PageNumber - 1) * ExamListSearchVm.PageSize).Take(ExamListSearchVm.PageSize).ToListAsync();
            return new PageList<ExamCP>(data, count, ExamListSearchVm.PageNumber, ExamListSearchVm.PageSize);
        }

        public async Task<ExamCP> UpdateExamCP(Guid id, ExamUpdateVm ExamUpdateVm)
        {
            var exam = _examRepository.AsQueryable().FirstOrDefault(c => Guid.Equals(id, c.Id));
            exam = new ExamCP()
            {
                Id = id,
                ExamCode = ExamUpdateVm.ExamCode,
                ExamName = ExamUpdateVm.ExamName,
                Status = ExamUpdateVm.Status,
                SubjectId = ExamUpdateVm.SubjectId
            };

            await _examRepository.UpdateAsync(exam);
            await _examRepository.SaveChangesAsync();
            return exam;
        }
    }
}
