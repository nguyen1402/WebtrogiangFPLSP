using FPLSP.Server.Data.Repositories.Interfaces;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Domain.Entities.UsesParts;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels.Specialized;
using Microsoft.EntityFrameworkCore;

namespace FPLSP.Server.Infrastructure.Services.Implements
{
    public class SpecializedUPServices : ISpecializedUPServices
    {

        private readonly IRepository<SpecializedUP> _repository;
        public SpecializedUPServices(IRepository<SpecializedUP> repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }
        public async Task<int> CreateSpecialized(Guid idBo, SpecializedVM specialized)
        {
            var cc = await _repository.AsQueryable().AnyAsync(c => String.Equals(specialized.SpecializedCode, c.SpecializedCode) && String.Equals(specialized.SpecializationName, c.SpecializationName));
            var dd = await _repository.AsQueryable().AnyAsync(c => String.Equals(specialized.SpecializationName, c.SpecializationName));
            if (idBo == Guid.Empty)
            {
                if (cc) return 0;
                var newspecialized = new SpecializedUP()
                {
                    SpecializedCode = specialized.SpecializedCode,
                    SpecializationName = specialized.SpecializationName,
                    Status = specialized.Status,
                    Image = specialized.Image,
                    Level = 0,
                };

                await _repository.AddAsync(newspecialized);
                await _repository.SaveChangesAsync();
                return 1;
            }
            else
            {
                if (dd) return 0;
                var id = _repository.AsQueryable().Where(c => Equals(idBo, c.Id)).Select(c => c.Level).FirstOrDefault();
                var code = _repository.AsQueryable().Where(c => Equals(idBo, c.Id)).Select(c => c.SpecializedCode).FirstOrDefault();
                var newspecialized = new SpecializedUP()
                {
                    SpecializedCode = code,
                    SpecializationName = specialized.SpecializationName,
                    Status = specialized.Status,
                    SpecialityId = idBo,
                    Image = specialized.Image,
                    Level = id + 1,
                };

                await _repository.AddAsync(newspecialized);
                await _repository.SaveChangesAsync();
                return 1;
            }

        }
        public async Task<int> DeleteSpecialized(Guid idBo, Guid id)
        {
            if (idBo == Guid.Empty)
            {
                var specialized = _repository.AsQueryable().FirstOrDefault(c => Equals(id, c.Id));
                await _repository.RemoveAsync(specialized);
                await _repository.SaveChangesAsync();
                return 1;
            }
            else
            {
                var specialized = _repository.AsQueryable().FirstOrDefault(c => Equals(id, c.Id)
                && Equals(idBo, c.SpecialityId));
                await _repository.RemoveAsync(specialized);
                await _repository.SaveChangesAsync();
                return 1;
            }
        }

        public async Task<List<SpecializedDto>> GetAll()
        {
            var ls = _repository.AsQueryable().Where(c => Boolean.Equals(false, c.IsDeleted));
            var lsspecialized = await ls.Select(x => new SpecializedDto()
            {
                SpecializedCode = x.SpecializedCode,
                SpecializationName = x.SpecializationName,
                Status = x.Status,
                Id = x.Id,
                Level = x.Level,
                IdSpeciality = x.SpecialityId,
            }).ToListAsync();
            return lsspecialized;
        }

        public async Task<List<SpecializedDto>> GetAllAsync(Guid idspec)
        {
            if (idspec != Guid.Empty)
            {
                var ls = _repository.AsQueryable().Where(c => Boolean.Equals(false, c.IsDeleted)
            && Equals(idspec, c.SpecialityId));
                var lsspecialized = await ls.Select(x => new SpecializedDto()
                {
                    SpecializedCode = x.SpecializedCode,
                    SpecializationName = x.SpecializationName,
                    Status = x.Status,
                    Id = x.Id,
                    Level = x.Level,
                    IdSpeciality = x.SpecialityId,
                }).ToListAsync();
                return lsspecialized;
            }
            else
            {
                var ls = _repository.AsQueryable().Where(c => Boolean.Equals(false, c.IsDeleted));
                var lsspecialized = await ls.Select(x => new SpecializedDto()
                {
                    SpecializedCode = x.SpecializedCode,
                    SpecializationName = x.SpecializationName,
                    Status = x.Status,
                    Id = x.Id,
                    Level = x.Level,
                    IdSpeciality = x.SpecialityId,
                }).ToListAsync();
                return lsspecialized;
            }
        }

        public async Task<SpecializedDto> GetbyId(Guid idBo, Guid id)
        {
            var ls = _repository.AsQueryable();
            var lspecializedDto = ls.Select(x => new SpecializedDto()
            {
                SpecializedCode = x.SpecializedCode,
                SpecializationName = x.SpecializationName,
                Status = x.Status,
                Id = x.Id,
                Level = x.Level,
                IdSpeciality = x.SpecialityId,
            }).ToList();
            if (idBo == Guid.Empty)
            {
                var specialized = lspecializedDto.FirstOrDefault(c => Equals(id, c.Id));
                return specialized;
            }
            else
            {
                var specialized = lspecializedDto.FirstOrDefault(c => Equals(id, c.Id) &&
                Equals(idBo, c.IdSpeciality));
                return specialized;
            }
        }
        public async Task<SpecializedUP> GetbyIdSpec(Guid id)
        {
            var resutl = _repository.AsQueryable().FirstOrDefault(c => c.Id == id);
            return resutl;
        }

        public async Task<PageList<SpecializedDto>> GetSpecializeds(Guid idBo, SpecializedListSearch specializedParameters)
        {
            if (idBo == Guid.Empty)
            {
                var ls = _repository.AsQueryable().Where(c => Boolean.Equals(false, c.IsDeleted) &&
            Equals(0, c.Level));
                var count = ls.Count();
                var lsspecialized = ls.Select(x => new SpecializedDto()
                {
                    SpecializedCode = x.SpecializedCode,
                    SpecializationName = x.SpecializationName,
                    Status = x.Status,
                    Image = x.Image,
                    Id = x.Id,
                    Level = x.Level
                });
                if (!string.IsNullOrEmpty(specializedParameters.Name))
                    lsspecialized = lsspecialized.Where(x => x.SpecializationName.Contains(specializedParameters.Name));
                if (!string.IsNullOrEmpty(specializedParameters.Status.ToString()))
                    lsspecialized = lsspecialized.Where(x => x.Status == specializedParameters.Status);
                if (!string.IsNullOrEmpty(specializedParameters.Code))
                    lsspecialized = lsspecialized.Where(x => x.SpecializedCode == specializedParameters.Code);

                var data = await lsspecialized
                    .Skip((specializedParameters.PageNumber - 1) * specializedParameters.PageSize)
                    .Take(specializedParameters.PageSize)
                    .ToListAsync();
                return new PageList<SpecializedDto>(data, count,
                    specializedParameters.PageNumber, specializedParameters.PageSize);
            }
            else
            {
                var ls = _repository.AsQueryable().Where(c => Boolean.Equals(false, c.IsDeleted) &&
                Equals(idBo, c.SpecialityId));
                var count = ls.Count();
                var lsspecialized = ls.Select(x => new SpecializedDto()
                {
                    SpecializedCode = x.SpecializedCode,
                    SpecializationName = x.SpecializationName,
                    Status = x.Status,
                    Id = x.Id,
                    Level = x.Level
                });
                if (!string.IsNullOrEmpty(specializedParameters.Name))
                    lsspecialized = lsspecialized.Where(x => x.SpecializationName.Contains(specializedParameters.Name));

                var data = await lsspecialized
                    .Skip((specializedParameters.PageNumber - 1) * specializedParameters.PageSize)
                    .Take(specializedParameters.PageSize)
                    .ToListAsync();
                return new PageList<SpecializedDto>(data, count,
                    specializedParameters.PageNumber, specializedParameters.PageSize);
            }

        }

        public async Task<List<SpecializedDto>> LoctheoLever(int lever)
        {
            var ls = _repository.AsQueryable().Where(c => Boolean.Equals(false, c.IsDeleted) && c.Level == lever);
            var lsspecialized = await ls.Select(x => new SpecializedDto()
            {
                SpecializedCode = x.SpecializedCode,
                SpecializationName = x.SpecializationName,
                Status = x.Status,
                Id = x.Id,
                Level = x.Level,
                IdSpeciality = x.SpecialityId,
            }).ToListAsync();
            return lsspecialized;
        }

        public async Task<int> UpdateSpecialized(Guid idBo, Guid id, SpecializedVM specialized_update)
        {
            if (idBo == Guid.Empty)
            {
                var specialized = _repository.AsQueryable().FirstOrDefault(c => Equals(id, c.Id));
                specialized.SpecializedCode = specialized_update.SpecializedCode;
                specialized.SpecializationName = specialized_update.SpecializationName;
                specialized.Status = specialized_update.Status;
                await _repository.UpdateAsync(specialized);
                await _repository.SaveChangesAsync();
                return 1;
            }
            else
            {
                var specialized = _repository.AsQueryable().FirstOrDefault(c => Equals(id, c.Id) &&
                Equals(idBo, c.SpecialityId));
                specialized.SpecializedCode = specialized_update.SpecializedCode;
                specialized.SpecializationName = specialized_update.SpecializationName;
                specialized.Status = specialized_update.Status;
                await _repository.UpdateAsync(specialized);
                await _repository.SaveChangesAsync();
                return 1;
            }
        }
    }
}

