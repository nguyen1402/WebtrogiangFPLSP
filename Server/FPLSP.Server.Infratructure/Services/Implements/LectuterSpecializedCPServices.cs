using FPLSP.Server.Data.Repositories.Interfaces;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Domain.Entities.UserParts;
using FPLSP.Server.Domain.Entities.UsesParts;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels.LectuterSpecializedCP;
using Microsoft.EntityFrameworkCore;

namespace FPLSP.Server.Infrastructure.Services.Implements
{
    public class LectuterSpecializedCPServices : ILectuterSpecializedCPServices
    {
        private readonly IRepository<SpecializedCP> _resspecialized;
        private readonly IRepository<LecturersCP> _reslecture;
        private readonly IRepository<SpecializedUP> _resspecializedup;
        private readonly IRepository<LectuterSpecializedCP> _res;
        private readonly IRepository<SubjectClassUP> _reposSubClass;
        private readonly IRepository<LectuterSpecializedUP> _repository;
        public LectuterSpecializedCPServices(IRepository<SpecializedCP> resspecialized
            , IRepository<LecturersCP> reslecture
            , IRepository<LectuterSpecializedCP> res, IRepository<SpecializedUP> resspecializedup, IRepository<LectuterSpecializedUP> repository, IRepository<SubjectClassUP> reposSubClass)
        {
            _res = res ?? throw new ArgumentNullException(nameof(res));
            _reslecture = reslecture ?? throw new ArgumentNullException(nameof(reslecture));
            _resspecialized = resspecialized ?? throw new ArgumentNullException(nameof(resspecialized));
            _resspecializedup = resspecializedup ?? throw new ArgumentNullException(nameof(resspecializedup));
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _reposSubClass = reposSubClass ?? throw new ArgumentNullException(nameof(reposSubClass));
        }
        public async Task<int> Create(Guid specializedId, LectuterSpecializedCPCreateVM create)
        {
            try
            {
                var tontai = await _res.AsQueryable().AnyAsync(c => Equals(create.IdLectuter, c.LectuterId) && Equals(specializedId, c.SpecializedId));
                if (tontai) return 0;
                var lecspnew = new LectuterSpecializedCP()
                {
                    SpecializedId = specializedId,
                    LectuterId = create.IdLectuter,
                    Status = create.Status,
                };
                await _res.AddAsync(lecspnew);
                await _res.SaveChangesAsync();

                var newUP = new LectuterSpecializedUP()
                {
                    SpecializedId = lecspnew.SpecializedId,
                    LectuterId = lecspnew.LectuterId,
                    Status = lecspnew.Status,
                };
                var updatestatus = _reposSubClass.AsQueryable().Where(c => c.HomeroomLecturer == create.IdLectuter && c.SpecializedOfClass == specializedId).ToList();
                if (updatestatus != null)
                {
                    foreach (var item in updatestatus)
                    {
                        item.Status = 0;
                    }
                    await _reposSubClass.UpdateRangeAsync(updatestatus);
                }
                await _repository.AddAsync(newUP);
                await _repository.SaveChangesAsync();
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public async Task<int> Delete(Guid specializedId, Guid lecturerid)
        {
            try
            {
                var result = _res.AsQueryable().FirstOrDefault(c => Equals(specializedId, c.SpecializedId) &&
            Equals(lecturerid, c.LectuterId));

                var updatestatus = _reposSubClass.AsQueryable().Where(c=>c.HomeroomLecturer == lecturerid && c.SpecializedOfClass == specializedId).ToList();
                if (updatestatus != null)
                {
                    foreach (var item in updatestatus)
                    {
                        item.Status = 1;
                    }
                    await _reposSubClass.UpdateRangeAsync(updatestatus);
                    var a = updatestatus.ToList();
                }
                await _res.RemoveAsync(result);
                await _res.SaveChangesAsync();


                var newUP = _repository.AsQueryable().FirstOrDefault(c => Equals(specializedId, c.SpecializedId) &&
            Equals(lecturerid, c.LectuterId));
                if (newUP != null)
                {
                    await _repository.RemoveAsync(newUP);
                    await _repository.SaveChangesAsync();
                }
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public async Task<List<LectuterSpecializedCPDto>> GetAllAsync()
        {
            try
            {
                var querry = from c in _res.AsQueryable().ToList()
                             join ct in _reslecture.AsQueryable().ToList() on c.LectuterId equals ct.Id
                             join ct2 in _resspecialized.AsQueryable() on c.SpecializedId equals ct2.Id
                             select new { c, ct, ct2 };

                var resuals = querry.Select(x => new LectuterSpecializedCPDto()
                {
                    Idspecialized = x.ct2.Id,
                    Idlecturers = x.ct.Id,
                    Email = x.ct.Email,
                    Dob = x.ct.Dob,
                    Gender = x.ct.Gender,
                    PhoneNumber = x.ct.PhoneNumber,
                    Address = x.ct.Address,
                    Ethnic = x.ct.Ethnic,
                    ImageUrl = x.ct.ImageUrl,
                    Status = x.c.Status,
                    SpecializationName = x.ct2.SpecializationName,
                    SpecializedCode = x.ct2.SpecializedCode,
                }).ToList();
                return resuals;
            }
            catch
            {
                return null;
            }
        }

        public async Task<LectuterSpecializedCPDto> GetbyId(Guid specializedId, Guid lecturerid)
        {
            try
            {
                var querry = from c in _res.AsQueryable()
                             join ct in _reslecture.AsQueryable() on c.LectuterId equals ct.Id
                             join ct2 in _resspecialized.AsQueryable() on c.SpecializedId equals ct2.Id
                             where c.SpecializedId == specializedId
                             select new { c, ct, ct2 };

                var resuals = await querry.Select(x => new LectuterSpecializedCPDto()
                {
                    Idspecialized = x.ct2.Id,
                    Idlecturers = x.ct.Id,
                    Email = x.ct.Email,
                    Dob = x.ct.Dob,
                    Gender = x.ct.Gender,
                    PhoneNumber = x.ct.PhoneNumber,
                    Address = x.ct.Address,
                    Ethnic = x.ct.Ethnic,
                    ImageUrl = x.ct.ImageUrl,
                    Status = x.c.Status,
                    Emsils = querry.Select(c => c.ct.Email).ToList(),
                    SpecializationName = x.ct2.SpecializationName,
                    SpecializedCode = x.ct2.SpecializedCode,
                }).ToListAsync();

                var resual = resuals.FirstOrDefault(c => Equals(specializedId, c.Idspecialized)
                && Equals(lecturerid, c.Idlecturers));

                return resual;
            }
            catch
            {
                return null;
            }
        }

        public async Task<PageList<LectuterSpecializedCPDto>> GetPagingParamets(Guid specializedId, LectuterSpecializedCPListSearch parameters)
        {
            try
            {
                var querry = from c in _res.AsQueryable()
                             join ct in _reslecture.AsQueryable() on c.LectuterId equals ct.Id
                             join ct2 in _resspecialized.AsQueryable() on c.SpecializedId equals ct2.Id
                             where c.SpecializedId == specializedId
                             select new { c, ct, ct2 };

                var resuals = await querry.Select(x => new LectuterSpecializedCPDto()
                {
                    Idspecialized = x.ct2.Id,
                    Idlecturers = x.ct.Id,
                    Email = x.ct.Email,
                    Dob = x.ct.Dob,
                    Gender = x.ct.Gender,
                    PhoneNumber = x.ct.PhoneNumber,
                    Address = x.ct.Address,
                    Ethnic = x.ct.Ethnic,
                    ImageUrl = x.ct.ImageUrl,
                    Status = x.c.Status,
                    SpecializationName = x.ct2.SpecializationName,
                    SpecializedCode = x.ct2.SpecializedCode,
                }).ToListAsync();

                if (!string.IsNullOrEmpty(parameters.Name))
                    resuals = resuals.Where(x => x.Email.Contains(parameters.Name)).ToList();

                var count = resuals.Count();

                var data = resuals
                   .Skip((parameters.PageNumber - 1) * parameters.PageSize)
                   .Take(parameters.PageSize)
                   .ToList();

                return new PageList<LectuterSpecializedCPDto>(data, count
                    , parameters.PageNumber
                    , parameters.PageSize);
            }
            catch
            {
                return null;
            }
        }

        public async Task<int> Update(Guid specializedId, Guid lecturerid, LectuterSpecializedCPUpdateVM update)
        {
            try
            {
                var lecspnud = _res.AsQueryable().FirstOrDefault(c => Equals(specializedId, c.SpecializedId)
                && Equals(lecturerid, c.LectuterId));


                var specializedIdud = _resspecialized.AsQueryable().
                    Where(c => Equals(update.SpecializedName, c.SpecializationName))
                    .Select(c => c.Id).FirstOrDefault();
                var lectureridud = _reslecture.AsQueryable().
                    Where(c => Equals(update.Email, c.Email))
                    .Select(c => c.Id).FirstOrDefault();


                lecspnud.SpecializedId = specializedIdud;
                lecspnud.LectuterId = lectureridud;
                lecspnud.Status = update.Status;
                await _res.UpdateAsync(lecspnud);
                await _res.SaveChangesAsync();

                var lecspnup = _repository.AsQueryable().FirstOrDefault(c => Equals(specializedId, c.SpecializedId)
                && Equals(lecturerid, c.LectuterId));


                var specializedIdup = _resspecializedup.AsQueryable().
                    Where(c => Equals(update.SpecializedName, c.SpecializationName))
                    .Select(c => c.Id).FirstOrDefault();
                var lectureridup = lectureridud;

                if (specializedIdup != null)
                {
                    lecspnup.SpecializedId = specializedIdud;
                    lecspnup.LectuterId = lectureridud;
                    lecspnup.Status = update.Status;
                    await _repository.UpdateAsync(lecspnup);
                    await _repository.SaveChangesAsync();
                }

                return 1;
            }
            catch
            {
                return 0;
            }
        }
    }
}
