using FPLSP.Server.Data.Repositories.Interfaces;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Domain.Entities.UserParts;
using FPLSP.Server.Domain.Entities.UsesParts;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels.SubjectsSpecializedVM;
using Microsoft.EntityFrameworkCore;

namespace FPLSP.Server.Infrastructure.Services.Implements
{
    public class SubjectsSpecializedUPServices : ISubjectsSpecializedUPServices
    {
        private readonly IRepository<SpecializedUP> _resspecialized;
        private readonly IRepository<SubjectUP> _ressubjects;
        private readonly IRepository<SpecializedSubjectUP> _res;
        public SubjectsSpecializedUPServices(IRepository<SpecializedUP> resspecialized
            , IRepository<SubjectUP> ressubjects
            , IRepository<SpecializedSubjectUP> res)
        {
            _res = res ?? throw new ArgumentNullException(nameof(res));
            _ressubjects = ressubjects ?? throw new ArgumentNullException(nameof(ressubjects));
            _resspecialized = resspecialized ?? throw new ArgumentNullException(nameof(resspecialized));
        }

        public async Task<bool> Create(Guid specializedId, SubjectsSpecializedCreateVM createVm)
        {
            var isExist = await _res.AsQueryable().AnyAsync(c => Equals(createVm.IdSubject, c.SubjectId) && Equals(specializedId, c.SpecializedId));
            if (isExist) return false;
            var lecspnew = new SpecializedSubjectUP()
            {
                SpecializedId = specializedId,
                SubjectId = createVm.IdSubject,
                Status = createVm.Status,
            };
            try
            {
                await _res.AddAsync(lecspnew);
                await _res.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Task<bool> Delete(Guid specializedId, Guid IdSubject)
        {
            throw new NotImplementedException();
        }

        public async Task<List<SubjectsSpecializedDtos>> GetAllAsync()
        {
            var listSub = _ressubjects.AsQueryable().ToList();
            var listSpec = _resspecialized.AsQueryable().ToList();
            var listSubSpec = _res.AsQueryable().ToList();
            var querry = (from c in listSubSpec
                          join ct in listSub on c.SubjectId equals ct.Id
                          join ct2 in listSpec on c.SpecializedId equals ct2.Id
                          //where ct2.Level != 0
                          select new { c, ct, ct2 }).ToList();
            var x = querry;
            var resuals = querry.Select(x => new SubjectsSpecializedDtos()
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
            }).ToList();

            return resuals;
        }

        public Task<SubjectsSpecializedDtos> GetbyId(Guid specializedId, Guid IdSubject)
        {
            throw new NotImplementedException();
        }

        public async Task<PageList<SubjectsSpecializedDtos>> GetPagingParamets(List<Guid> specializedIds, SubjectsSpecializedCPListSearch parameters)
        {
            var resuals = await GetAllAsync();

            if (specializedIds.Count != 0)
                resuals = resuals.Where(x => specializedIds.Any(c => c == x.SpecializedId)).ToList();
            if (!string.IsNullOrEmpty(parameters.Name))
                resuals = resuals.Where(x => x.SubjectName.ToLower().Contains(parameters.Name.ToLower())).ToList();

            var count = resuals.Count();

            var data = resuals
               .Skip((parameters.PageNumber - 1) * parameters.PageSize)
               .Take(parameters.PageSize)
               .ToList();

            return new PageList<SubjectsSpecializedDtos>(data, count
                , parameters.PageNumber
                , parameters.PageSize);
        }

        public Task<bool> Update(Guid specializedId, Guid IdSubject, SubjectsSpecializedUpdateVM update)
        {
            throw new NotImplementedException();
        }
    }
}
