using FPLSP.Server.Data.Repositories.Interfaces;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Domain.Entities.UsesParts;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels.Specialized;
using Microsoft.EntityFrameworkCore;

namespace FPLSP.Server.Infrastructure.Services.Implements
{
    public class SpecializedCPServices : ISpecializedCPServices
    {
        private readonly IRepository<SpecializedUP> _repository;
        private readonly IRepository<SpecializedCP> _res;
        private readonly IRepository<LectuterSpecializedCP> _lectuterSpecializedCP;
        public SpecializedCPServices(IRepository<SpecializedCP> res, IRepository<SpecializedUP> repository, IRepository<LectuterSpecializedCP> lectuterSpecializedCP)
        {
            _res = res;
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _lectuterSpecializedCP = lectuterSpecializedCP;
        }

        public async Task<int> CreateSpecialized(Guid idBo, SpecializedVM specialized)
        {
            try
            {
                if (idBo == Guid.Empty)
                {
                    var cc =  _res.AsQueryable().ToList().ToList().Any(c => c.IsDeleted == false && String.Equals(specialized.SpecializedCode, c.SpecializedCode) && String.Equals(specialized.SpecializationName, c.SpecializationName));
                    if (cc) return 0;
                    var newspecialized = new SpecializedCP()
                    {
                        SpecializedCode = specialized.SpecializedCode.Trim(),
                        SpecializationName = specialized.SpecializationName,
                        Status = specialized.Status,
                        Image = specialized.Image,
                        Level = 0,
                        Id = specialized.Id,

                    };

                    await _res.AddAsync(newspecialized);
                    await _res.SaveChangesAsync();

                    var newspecializedUP = new SpecializedUP()
                    {
                        Id = newspecialized.Id,
                        SpecializedCode = newspecialized.SpecializedCode,
                        SpecializationName = newspecialized.SpecializationName,
                        Status = newspecialized.Status,
                        Image = newspecialized.Image,
                        Level = newspecialized.Level,
                    };

                    await _repository.AddAsync(newspecializedUP);
                    await _repository.SaveChangesAsync();
                    return 1;
                }
                else
                {
                    var dd =  _res.AsQueryable().ToList().Any(c => c.IsDeleted == false && String.Equals(specialized.SpecializationName, c.SpecializationName) && c.IdSpeciality == idBo);
                    if (dd) return 0;
                    var id = _res.AsQueryable().ToList().Where(c => Equals(idBo, c.Id)).Select(c => c.Level).FirstOrDefault();
                    var code = _res.AsQueryable().ToList().Where(c => Equals(idBo, c.Id)).Select(c => c.SpecializedCode).FirstOrDefault();
                    var newspecialized = new SpecializedCP()
                    {
                        SpecializedCode = specialized.SpecializedCode.Trim(),
                        SpecializationName = specialized.SpecializationName,
                        Status = specialized.Status,
                        Image = specialized.Image,
                        IdSpeciality = idBo,
                        Level = id + 1,
                        Id = specialized.Id,
                    };

                    await _res.AddAsync(newspecialized);
                    await _res.SaveChangesAsync();

                    var newspecializedUP = new SpecializedUP()
                    {
                        Id = newspecialized.Id,
                        SpecializedCode = newspecialized.SpecializedCode,
                        SpecializationName = newspecialized.SpecializationName,
                        Status = newspecialized.Status,
                        Image = newspecialized.Image,
                        SpecialityId = idBo,
                        Level = newspecialized.Level,
                     
                    };

                    await _repository.AddAsync(newspecializedUP);
                    await _repository.SaveChangesAsync();

                    return 1;
                }
            }
            catch (Exception)
            {
                return 0;
            }

        }

        public async Task<int> DeleteSpecialized(Guid idBo, Guid id)
        {
            try
            {
                if (idBo == Guid.Empty)
                {
                    var specialized = _res.AsQueryable().ToList().Where(c => Equals(id, c.Id) || Equals(id, c.IdSpeciality));
                    await _res.RemoveRangeAsync(specialized);
                    await _res.SaveChangesAsync();

                    var specializedUP = _repository.AsQueryable().ToList().Where(c => Equals(id, c.Id) || Equals(id, c.SpecialityId));
                    if (specializedUP != null && specializedUP.Count() > 0)
                    {
                        await _repository.RemoveRangeAsync(specializedUP);
                        await _repository.SaveChangesAsync();
                    }

                    foreach (var i in specialized.ToList())
                    {
                        var lecSpec = _lectuterSpecializedCP.AsQueryable().ToList().Where(c => Equals(i.Id, c.SpecializedId));
                        if (lecSpec != null && lecSpec.Count() > 0)
                        {
                            await _lectuterSpecializedCP.RemoveRangeAsync(lecSpec);
                            await _lectuterSpecializedCP.SaveChangesAsync();
                        }
                    }

                    return 1;
                }
                else
                {
                    var specialized = _res.AsQueryable().ToList().FirstOrDefault(c => Equals(id, c.Id)
                    && Equals(idBo, c.IdSpeciality));
                    await _res.RemoveAsync(specialized);
                    await _res.SaveChangesAsync();

                    var specializedUP = _repository.AsQueryable().ToList().FirstOrDefault(c => Equals(id, c.Id)
                && Equals(idBo, c.SpecialityId));
                    if (specializedUP != null)
                    {
                        await _repository.RemoveAsync(specializedUP);
                        await _repository.SaveChangesAsync();
                    }

                    var lecSpec = _lectuterSpecializedCP.AsQueryable().ToList().Where(c => Equals(id, c.SpecializedId));
                    if (lecSpec != null && lecSpec.Count() > 0)
                    {
                        await _lectuterSpecializedCP.RemoveRangeAsync(lecSpec);
                        await _lectuterSpecializedCP.SaveChangesAsync();
                    }

                    return 1;
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public async Task<List<SpecializedDto>> GetAll()
        {
            try
            {
                var ls = _res.AsQueryable().ToList();
                var lsspecialized =  ls.Select(x => new SpecializedDto()
                {
                    SpecializedCode = x.SpecializedCode.Trim(),
                    SpecializationName = x.SpecializationName,
                    Status = x.Status,
                    Id = x.Id,
                    Level = x.Level,
                    IdSpeciality = x.IdSpeciality,
                    Image = x.Image,
                }).ToList();
                return lsspecialized;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<List<SpecializedDto>> GetAllAsync(Guid idspec)
        {
            try
            {
                if (idspec != Guid.Empty)
                {
                    var ls = _res.AsQueryable().ToList().Where(c => Boolean.Equals(false, c.IsDeleted)
                && Equals(idspec, c.IdSpeciality));
                    var lsspecialized =  ls.Select(x => new SpecializedDto()
                    {
                        SpecializedCode = x.SpecializedCode.Trim(),
                        SpecializationName = x.SpecializationName,
                        Status = x.Status,
                        Id = x.Id,
                        Level = x.Level,
                        IdSpeciality = x.IdSpeciality,
                        Image = x.Image,
                    }).ToList();
                    return lsspecialized;
                }
                else
                {
                    var ls = _res.AsQueryable().ToList().Where(c => Boolean.Equals(false, c.IsDeleted));
                    var lsspecialized =  ls.Select(x => new SpecializedDto()
                    {
                        SpecializedCode = x.SpecializedCode.Trim(),
                        SpecializationName = x.SpecializationName,
                        Status = x.Status,
                        Id = x.Id,
                        Level = x.Level,
                        IdSpeciality = x.IdSpeciality,
                        Image = x.Image,
                    }).ToList();
                    return lsspecialized;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<SpecializedDto> GetbyId(Guid idBo, Guid id)
        {
            try
            {
                var ls = _res.AsQueryable().ToList();
                var lspecializedDto = ls.Select(x => new SpecializedDto()
                {
                    SpecializedCode = x.SpecializedCode.Trim(),
                    SpecializationName = x.SpecializationName,
                    Status = x.Status,
                    Id = x.Id,
                    Level = x.Level,
                    IdSpeciality = x.IdSpeciality,
                    Image = x.Image,
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
            catch (Exception)
            {
                return null;
            }
        }
        public async Task<PageList<SpecializedDto>> GetAllSpecializeds(SpecializedListSearch specializedParameters)
        {
            try
            {
                var ls = _res.AsQueryable().ToList().Where(c => Boolean.Equals(false, c.IsDeleted)).OrderByDescending(x => x.CreatedTime);
                var count = ls.Count();
                var lsspecialized = ls.Select(x => new SpecializedDto()
                {
                    SpecializedCode = x.SpecializedCode.Trim(),
                    SpecializationName = x.SpecializationName,
                    Status = x.Status,
                    Id = x.Id,
                    Level = x.Level,
                    Image = x.Image,
                    IdSpeciality = x.IdSpeciality,
                });
                if (!string.IsNullOrEmpty(specializedParameters.Name))
                    lsspecialized = lsspecialized.Where(x => x.SpecializationName.ToLower().Contains(specializedParameters.Name.ToLower()) || x.SpecializedCode.ToLower().Contains(specializedParameters.Name.ToLower()));

                var data =  lsspecialized
                    .Skip((specializedParameters.PageNumber - 1) * specializedParameters.PageSize)
                    .Take(specializedParameters.PageSize)
                    .ToList();
                return new PageList<SpecializedDto>(data, count,
                    specializedParameters.PageNumber, specializedParameters.PageSize);

            }
            catch (Exception)
            {
                return null;
            }

        }

        public async Task<PageList<SpecializedDto>> GetSpecializeds(Guid idBo, SpecializedListSearch specializedParameters)
        {
            try
            {
                if (idBo == Guid.Empty)
                {
                    var ls = _res.AsQueryable().ToList().Where(c => Boolean.Equals(false, c.IsDeleted) &&
                Equals(0, c.Level)).OrderBy(x => x.SpecializedCode);
                    var count = ls.Count();
                    var lsspecialized = ls.Select(x => new SpecializedDto()
                    {
                        SpecializedCode = x.SpecializedCode.Trim(),
                        SpecializationName = x.SpecializationName,
                        Status = x.Status,
                        Id = x.Id,
                        Level = x.Level,
                        Image = x.Image,
                        IdSpeciality = x.IdSpeciality,
                    });
                    if (!string.IsNullOrEmpty(specializedParameters.Name))
                        lsspecialized = lsspecialized.Where(x => x.SpecializationName.ToLower().Contains(specializedParameters.Name.ToLower()) || x.SpecializedCode.ToLower().Contains(specializedParameters.Name.ToLower()));

                    var data =  lsspecialized
                        .Skip((specializedParameters.PageNumber - 1) * specializedParameters.PageSize)
                        .Take(specializedParameters.PageSize)
                        .ToList();
                    return new PageList<SpecializedDto>(data, count,
                        specializedParameters.PageNumber, specializedParameters.PageSize);
                }
                else
                {
                    var ls = _res.AsQueryable().ToList().Where(c => Boolean.Equals(false, c.IsDeleted) &&
                    Equals(idBo, c.IdSpeciality));
                    var count = ls.Count();
                    var lsspecialized = ls.Select(x => new SpecializedDto()
                    {
                        SpecializedCode = x.SpecializedCode.Trim(),
                        SpecializationName = x.SpecializationName,
                        Status = x.Status,
                        Id = x.Id,
                        Level = x.Level,
                        Image = x.Image,
                        IdSpeciality = x.IdSpeciality,
                    });
                    if (!string.IsNullOrEmpty(specializedParameters.Name))
                        lsspecialized = lsspecialized.Where(x => x.SpecializationName.ToLower().Contains(specializedParameters.Name.ToLower()) || x.SpecializedCode.ToLower().Contains(specializedParameters.Name.ToLower()));

                    var data =  lsspecialized
                        .Skip((specializedParameters.PageNumber - 1) * specializedParameters.PageSize)
                        .Take(specializedParameters.PageSize)
                        .ToList();
                    return new PageList<SpecializedDto>(data, count,
                        specializedParameters.PageNumber, specializedParameters.PageSize);
                }
            }
            catch (Exception)
            {
                return null;
            }

        }

        public async Task<List<SpecializedDto>> LoctheoLever(int lever)
        {
            try
            {
                var ls = _res.AsQueryable().ToList().Where(c => Boolean.Equals(false, c.IsDeleted) && c.Level == lever);
                var lsspecialized =  ls.Select(x => new SpecializedDto()
                {
                    SpecializedCode = x.SpecializedCode,
                    SpecializationName = x.SpecializationName,
                    Status = x.Status,
                    Id = x.Id,
                    Level = x.Level,
                    IdSpeciality = x.IdSpeciality,
                    Image = x.Image,
                }).ToList();
                return lsspecialized;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<int> UpdateSpecialized(Guid idBo, Guid id, SpecializedVM specialized_update)
        {
            try
            {
                if (idBo == Guid.Empty)
                {
                    var specialized = _res.AsQueryable().ToList().FirstOrDefault(c => Equals(id, c.Id));
                    specialized.SpecializedCode = specialized_update.SpecializedCode.Trim();
                    specialized.SpecializationName = specialized_update.SpecializationName;
                    specialized.Status = specialized_update.Status;
                    specialized.Level = 0;
                    specialized.Image = specialized_update.Image;
                    specialized.IdSpeciality = null;
                    //specialized.IdSpeciality = null;
                    await _res.UpdateAsync(specialized);
                    await _res.SaveChangesAsync();

                    var specializedUP = _repository.AsQueryable().ToList().FirstOrDefault(c => Equals(id, c.Id));
                    if (specializedUP != null)
                    {
                        specializedUP.SpecializedCode = specialized.SpecializedCode;
                        specializedUP.SpecializationName = specialized.SpecializationName;
                        specializedUP.Status = specialized.Status;
                        specializedUP.Level = specialized.Level;
                        specializedUP.Image = specialized.Image;
                        specializedUP.SpecialityId = specialized.IdSpeciality;
                        await _repository.UpdateAsync(specializedUP);
                        await _repository.SaveChangesAsync();
                    }
                    return 1;
                }
                else
                {
                    var specialized = _res.AsQueryable().ToList().FirstOrDefault(c => Equals(id, c.Id) );
                    specialized.SpecializedCode = specialized_update.SpecializedCode.Trim();
                    specialized.SpecializationName = specialized_update.SpecializationName;
                    specialized.Status = specialized_update.Status;
                    specialized.Image = specialized_update.Image;
                    specialized.Level = 1;
                    specialized.IdSpeciality = idBo;
                    await _res.UpdateAsync(specialized);
                    await _res.SaveChangesAsync();


                    var specializedUP = _repository.AsQueryable().ToList().FirstOrDefault(c => Equals(id, c.Id));
                    if (specializedUP != null)
                    {
                        specializedUP.SpecializedCode = specialized.SpecializedCode;
                        specializedUP.SpecializationName = specialized.SpecializationName;
                        specializedUP.Status = specialized.Status;
                        specializedUP.Level = specialized.Level;
                        specializedUP.Image = specialized.Image;
                        specializedUP.SpecialityId = specialized.IdSpeciality;
                        await _repository.UpdateAsync(specializedUP);
                        await _repository.SaveChangesAsync();
                    }

                    return 1;
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
