using AutoMapper;
using AutoMapper.QueryableExtensions;
using FPLSP.Server.Data.Repositories.Interfaces;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Entities.CabinProject;
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Domain.Entities.UserParts;
using FPLSP.Server.Infrastructure.Services.Interfaces.CabinProject;
using FPLSP.Server.Infrastructure.ViewModels.CabinProject.Cabin;
using FPLSP.Server.Infrastructure.ViewModels.CabinProject.GroupCabin;
using FPLSP.Server.Infratructure.AutoMapperConfiguration;
using Microsoft.EntityFrameworkCore;


namespace FPLSP.Server.Infrastructure.Services.Implements.CabinProject
{
    public class CabinServices : ICabinServices
    {
        private readonly IRepository<FPLSP.Server.Domain.Entities.CabinProject.Cabin> _Irepository;
        private readonly IMapper _mapper;

        public CabinServices(IRepository<FPLSP.Server.Domain.Entities.CabinProject.Cabin> Irepository, IMapper mapper)
        {
            _Irepository = Irepository;
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<CabinViewModel> CreateCabin(CabinCreateViewModel request)
        {
            try
            {
                int index = 0;
                var objCollection = _Irepository.AsQueryable().ToList();
                if (objCollection.Count > 0)
                {
                    index = objCollection.Max(c => c.IndexOfCabin) + 1;
                }

                var obj = new FPLSP.Server.Domain.Entities.CabinProject.Cabin
                {
                    Id = Guid.NewGuid(),
                    CabinName = request.CabinName,
                    IndexOfCabin = index,
                    CreateTime = DateTime.Now,
                    BuildingName = request.BuildingName,
                    IdTrainingFacility = request.IdTrainingFacility,
                    Status = request.Status,
                };
                await _Irepository.AddAsync(obj);
                await _Irepository.SaveChangesAsync();
                return await GetCabinListById(obj.Id);
            }
            catch
            {
                return null;
            }

        }

        public async Task<bool> DeleteCabin(Guid Id)
        {
            try
            {
                var obj = await _Irepository.AsQueryable().FirstOrDefaultAsync(c => Equals(c.Id, Id));
                await _Irepository.RemoveAsync(obj);
                await _Irepository.SaveChangesAsync();

                return true;
            }
            catch
            {
                return false;
            }
        }
        public async Task<bool> ChangeStatus(Guid Id)
        {
            try
            {
                var obj = await _Irepository.AsQueryable().FirstOrDefaultAsync(c => Equals(c.Id, Id));
                obj.Status = 4;
                await _Irepository.UpdateAsync(obj);
                await _Irepository.SaveChangesAsync();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<List<CabinViewModel>> GetAllCabinAsync()
        {
            try
            {
                var objCollection = _Irepository.AsQueryable().ProjectTo<CabinViewModel>(_mapper.ConfigurationProvider).Where(x => x.Status != 1).ToList();
                return objCollection;
            }
            catch
            {
                return null;
            }
        }

        public async Task<CabinViewModel> GetCabinListById(Guid Id)
        {
            try
            {
                var obj = await _Irepository.AsQueryable().SingleOrDefaultAsync(c => c.Id == Id);
                var objModel = _mapper.Map<CabinViewModel>(obj);
                return objModel;
            }
            catch
            {
                return null;
            }
        }

        public async Task<PageList<CabinViewModel>> GetCabinListSearch(CabinSearchViewModel search)
        {
            try
            {
                var objCollection = _Irepository.AsQueryable().Where(x => x.Status != 1).ProjectTo<CabinViewModel>(_mapper.ConfigurationProvider).ToList();

                // Danh sách các parameter muốn dùng để search
                if (!string.IsNullOrEmpty(search.CabinName))
                    objCollection = objCollection.Where(x => x.CabinName.ToLower().Contains(search.CabinName.ToLower())).ToList();
                if (!string.IsNullOrEmpty(search.BuildingName))
                    objCollection = objCollection.Where(x => x.BuildingName.ToLower().Contains(search.BuildingName.ToLower())).ToList();
                if (!string.IsNullOrEmpty(Convert.ToString(search.Status)))
                    objCollection = objCollection.Where(x => x.Status == search.Status).ToList();

                var count = objCollection.Count();

                var data = objCollection.Skip((search.PageNumber - 1) * search.PageSize).Take(search.PageSize).ToList();
                var result = new PageList<CabinViewModel>(data, count, search.PageNumber, search.PageSize);
                return result;
            }
            catch
            {
                return null;
            }
        }

        public async Task<bool> RemoveListCabin(List<Guid> listIdSpecCabin)
        {
            try
            {
                List<FPLSP.Server.Domain.Entities.CabinProject.Cabin> objCollection = new List<FPLSP.Server.Domain.Entities.CabinProject.Cabin>();
                foreach (var item in listIdSpecCabin)
                {
                    objCollection.AddRange(_Irepository.AsQueryable().Where(c => c.Id == item));
                }
                var result = _Irepository.RemoveRangeAsync(objCollection);
                await _Irepository.SaveChangesAsync();
                return result.IsCompletedSuccessfully;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> UpdateCabin(Guid Id, CabinUpdateViewModel request)
        {
            try
            {
                var obj = await _Irepository.AsQueryable().FirstOrDefaultAsync(c => c.Id == Id);

                obj.CabinName = request.CabinName;
                obj.BuildingName = request.BuildingName;
                obj.IndexOfCabin = request.IndexOfCabin;
                obj.Status = request.Status;

                await _Irepository.UpdateAsync(obj);
                await _Irepository.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}