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
    public class LectuterSpecializedUPServices : ILectuterSpecializedUPServices
    {
        private readonly IRepository<SpecializedUP> _resspecialized;
        private readonly IRepository<LecturersCP> _reslecture;
        private readonly IRepository<LectuterSpecializedUP> _res;
        public LectuterSpecializedUPServices(IRepository<SpecializedUP> resspecialized
            , IRepository<LecturersCP> reslecture
            , IRepository<LectuterSpecializedUP> res)
        {
            _res = res ?? throw new ArgumentNullException(nameof(res));
            _reslecture = reslecture ?? throw new ArgumentNullException(nameof(reslecture));
            _resspecialized = resspecialized ?? throw new ArgumentNullException(nameof(resspecialized));
        }
        public async Task<int> Create(Guid specializedId, LectuterSpecializedCPCreateVM create)
        {
            try
            {
                var tontai = await _res.AsQueryable().AnyAsync(c => Equals(create.IdLectuter, c.LectuterId) && Equals(specializedId, c.SpecializedId));
                if (tontai) return 0;
                var lecspnew = new LectuterSpecializedUP()
                {
                    SpecializedId = specializedId,
                    LectuterId = create.IdLectuter,
                    Status = create.Status,
                };
                await _res.AddAsync(lecspnew);
                await _res.SaveChangesAsync();
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

                await _res.RemoveAsync(result);
                await _res.SaveChangesAsync();
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
                var querry = from c in _res.AsQueryable()
                             join ct in _reslecture.AsQueryable() on c.LectuterId equals ct.Id
                             join ct2 in _resspecialized.AsQueryable() on c.SpecializedId equals ct2.Id
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
                return 1;
            }
            catch
            {
                return 0;
            }
        }
    }
}
