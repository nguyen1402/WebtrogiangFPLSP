using AutoMapper;
using AutoMapper.QueryableExtensions;
using FPLSP.Server.Data.Repositories.Interfaces;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Domain.Entities.UserParts;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels.ReportClassUP;

namespace FPLSP.Server.Infrastructure.Services.Implements
{
    public class ReportClassUPServices : IReportClassUPServices
    {
        private readonly IRepository<ReportClassUP> _reportrepository;
        private readonly IRepository<ClassUp> _classuprepository;
        private readonly IMapper _mapper;
        public ReportClassUPServices(IRepository<ReportClassUP> reportrepository, IMapper mapper, IRepository<ClassUp> classuprepository)
        {
            _reportrepository = reportrepository ?? throw new ArgumentNullException(nameof(reportrepository));
            _classuprepository = classuprepository ?? throw new ArgumentNullException(nameof(classuprepository)); ; ;
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper)); ;
        }

        public async Task<bool> CreateReportClassUP(ReportUPViewModel reportvm)
        {
            var report = _reportrepository.AddAsync(new ReportClassUP()
            {
                Id = Guid.NewGuid(),
                ReportAmount = reportvm.ReportAmount,
                ReportDate = DateTime.Now,
                ReportLevel = reportvm.ReportLevel,//Mức độ báo cáo int
                Question = reportvm.Question,
                Answer = reportvm.Answer,
                Describe = reportvm.Describe,
                Note = reportvm.Note,
                ClassId = reportvm.ClassId,
                Status = reportvm.Status
            });
            await _reportrepository.SaveChangesAsync();
            return report.IsCompletedSuccessfully;
        }

        public Task<ReportUPViewModel> GetByIdReport(Guid id)
        {
            var report = _reportrepository.AsQueryable().OrderByDescending(c => c.ReportDate).ProjectTo<ReportUPViewModel>(_mapper.ConfigurationProvider);
            var result = report.FirstOrDefault(c => c.Id == id);
            return Task.FromResult(result);
        }

        public async Task<IQueryable<ReportUPDto>> GetListReportClassUP()
        {
            var lstreport = _reportrepository.AsQueryable();
            var lstclassup = _classuprepository.AsQueryable();
            var result = from a in lstreport
                         join b in lstclassup
                         on a.ClassId equals b.Id
                         select new ReportUPDto
                         {
                             Id = a.Id,
                             ReportAmount = a.ReportAmount,
                             ReportDate = a.ReportDate,
                             ReportLevel = a.ReportLevel,
                             Question = a.Question,
                             Answer = a.Answer,
                             Describe = a.Describe,
                             Note = a.Note,
                           
                             IsDeleted = a.IsDeleted,
                             Status = a.Status
                         };
            return result.OrderByDescending(c => c.ReportDate);
        }

        public Task<bool> RestoreReportClassUP(Guid id)
        {
            var report = _reportrepository.AsQueryable().FirstOrDefault(c => c.Id == id);
            if (report == null)
            {
                return Task.FromResult(false);
            }
            report.IsDeleted = false;

            _reportrepository.UpdateAsync(report);
            _reportrepository.SaveChangesAsync();
            return Task.FromResult(true);
        }

        public Task<bool> RemoveReportClassUP(Guid id)
        {
            var report = _reportrepository.AsQueryable().FirstOrDefault(c => c.Id == id);
            if (report == null)
            {
                return Task.FromResult(false);
            }
            report.DeletedTime = DateTimeOffset.Now;
            // chưa đăng nhập report.DeletedBy
            var result = _reportrepository.RemoveAsync(report);
            _reportrepository.SaveChangesAsync();
            return Task.FromResult(result.IsCompletedSuccessfully);
        }

        public Task<bool> UpdateReportClassUP(ReportUPViewModel reportvm)
        {
            var report = _reportrepository.AsQueryable().FirstOrDefault(c => c.Id == reportvm.Id);
            if (report == null)
            {
                return Task.FromResult(false);
            };
            report.ReportAmount = reportvm.ReportAmount;
            report.ReportLevel = reportvm.ReportLevel;//Mức độ báo cáo int
            report.Question = reportvm.Question;
            report.Answer = reportvm.Answer;
            report.Describe = reportvm.Describe;
            report.Note = reportvm.Note;
            report.ClassId = reportvm.ClassId;
            report.ModifiedTime = DateTimeOffset.Now;
            report.Status = reportvm.Status;

            _reportrepository.UpdateAsync(report);
            _reportrepository.SaveChangesAsync();

            return Task.FromResult(true);
        }

        public async Task<PageList<ReportUPDto>> GetPagingReportUPDto(Guid classUPId, ReportClassUpSearch repositoryParameters)
        {
            var lstreport = _reportrepository.AsQueryable();
            var lstclassup = _classuprepository.AsQueryable();
            var result = (from a in lstreport
                          join b in lstclassup
                          on a.ClassId equals b.Id
                          where a.IsDeleted == false && Equals(a.ClassId, b.Id)
                          select new ReportUPDto
                          {
                              Id = a.Id,
                              ReportAmount = a.ReportAmount,
                              ReportDate = a.ReportDate,
                              ReportLevel = a.ReportLevel,
                              Question = a.Question,
                              Answer = a.Answer,
                              Describe = a.Describe,
                              Note = a.Note,
                          
                              IsDeleted = a.IsDeleted,
                              Status = a.Status
                          }).OrderByDescending(c => c.ReportDate).ToList();
            if (!string.IsNullOrEmpty(repositoryParameters.Lever.ToString()))
            {
                result = result.Where(c => Equals(c.ReportLevel, repositoryParameters.Lever)).ToList();
            }
            if (!string.IsNullOrEmpty(repositoryParameters.Describe))
            {
                result = result.Where(c => c.Describe.ToUpper().Contains(repositoryParameters.Describe.ToUpper())).ToList();
            }
            var count = result.Count();
            var data = result
                .Skip((repositoryParameters.PageNumber - 1) * repositoryParameters.PageSize)
                .Take(repositoryParameters.PageSize)
                .ToList();

            return new PageList<ReportUPDto>(data, count
                , repositoryParameters.PageNumber
                , repositoryParameters.PageSize);

        }

        public async Task<bool> RemoveListReportClassUP(List<Guid> listIdReport)
        {
            List<ReportClassUP> reportClassUP = new List<ReportClassUP>();
            foreach (var item in listIdReport)
            {
                reportClassUP.AddRange(_reportrepository.AsQueryable().Where(c => c.Id == item));
            }
            var result = _reportrepository.RemoveRangeAsync(reportClassUP);
            await _reportrepository.SaveChangesAsync();
            return result.IsCompletedSuccessfully;
        }
    }
}

