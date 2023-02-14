using FPLSP.Server.Data.Repositories.Interfaces;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels.SubjectsSpecializedVM;
using Microsoft.EntityFrameworkCore;

namespace FPLSP.Server.Infrastructure.Services.Implements
{
    public class SubjectsSpecializedCPServices : ISubjectsSpecializedCPServices
    {
        private readonly IRepository<SpecializedCP> _resspecialized;
        private readonly IRepository<SubjectCP> _ressubjects;
        private readonly IRepository<SpecializedSubjectCP> _res;
        public SubjectsSpecializedCPServices(IRepository<SpecializedCP> resspecialized
            , IRepository<SubjectCP> ressubjects
            , IRepository<SpecializedSubjectCP> res)
        {
            _res = res ?? throw new ArgumentNullException(nameof(res));
            _ressubjects = ressubjects ?? throw new ArgumentNullException(nameof(ressubjects));
            _resspecialized = resspecialized ?? throw new ArgumentNullException(nameof(resspecialized));
        }
        public async Task<int> Create(Guid specializedId, SubjectsSpecializedCreateVM create)
        {
            var tontai = await _res.AsQueryable().AnyAsync(c => Equals(create.IdSubject, c.SubjectId) && Equals(specializedId, c.SpecializedId));
            if (tontai) return 0;
            var lecspnew = new SpecializedSubjectCP()
            {
                SpecializedId = specializedId,
                SubjectId = create.IdSubject,
                Status = create.Status,
            };
            try
            {
                await _res.AddAsync(lecspnew);
                await _res.SaveChangesAsync();
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public Task<int> Delete(Guid specializedId, Guid IdSubject)
        {
            throw new NotImplementedException();
        }

        public async Task<List<SubjectsSpecializedDtos>> GetAllAsync()
        {
            var querry = from c in _res.AsQueryable()
                         join ct in _ressubjects.AsQueryable() on c.SubjectId equals ct.Id
                         join ct2 in _resspecialized.AsQueryable() on c.SpecializedId equals ct2.Id
                         where ct2.Level != 0
                         select new { c, ct, ct2 };

            var resuals = await querry.Select(x => new SubjectsSpecializedDtos()
            {
                SpecializedId = x.ct2.Id,
                SubjectId = x.ct.Id,
                SubjectName = x.ct.SubjectName,
                SpecializationName = x.ct2.SpecializationName,
                StatusSpecialized = x.ct2.Status,
                StartDay = x.ct.StartDay,
                EndDay = x.ct.EndDay,
                TotalOfSub = x.ct.TotalOfSub,
                Image = x.ct.Image,
                StatusSubject = x.ct.Status,
            }).ToListAsync();

            return resuals;
        }

        public Task<SubjectsSpecializedDtos> GetbyId(Guid specializedId, Guid IdSubject)
        {
            throw new NotImplementedException();
        }

        public async Task<PageList<SubjectsSpecializedDtos>> GetPagingParamets(Guid specializedId, SubjectsSpecializedCPListSearch parameters)
        {
            var querry = from c in _res.AsQueryable()
                         join ct in _ressubjects.AsQueryable() on c.SubjectId equals ct.Id
                         join ct2 in _resspecialized.AsQueryable() on c.SpecializedId equals ct2.Id
                         where c.SpecializedId == specializedId
                         select new { c, ct, ct2 };

            var resuals = await querry.Select(x => new SubjectsSpecializedDtos()
            {
                SpecializedId = x.ct2.Id,
                SubjectId = x.ct.Id,
                SubjectName = x.ct.SubjectName,
                SpecializationName = x.ct2.SpecializationName,
                StatusSpecialized = x.ct2.Status,
                StartDay = x.ct.StartDay,
                EndDay = x.ct.EndDay,
                TotalOfSub = x.ct.TotalOfSub,
                Image = x.ct.Image,
                StatusSubject = x.ct.Status,
            }).ToListAsync();

            if (!string.IsNullOrEmpty(parameters.Name))
                resuals = resuals.Where(x => x.SubjectName.Contains(parameters.Name)).ToList();

            var count = resuals.Count();

            var data = resuals
               .Skip((parameters.PageNumber - 1) * parameters.PageSize)
               .Take(parameters.PageSize)
               .ToList();

            return new PageList<SubjectsSpecializedDtos>(data, count
                , parameters.PageNumber
                , parameters.PageSize);
        }

        public Task<int> Update(Guid specializedId, Guid IdSubject, SubjectsSpecializedUpdateVM update)
        {
            throw new NotImplementedException();
        }
    }
}
