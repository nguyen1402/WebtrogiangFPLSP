using AutoMapper;
using AutoMapper.QueryableExtensions;
using FPLSP.Server.Data.Repositories.Interfaces;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels;
using FPLSP.Server.Infrastructure.ViewModels.RoleCPVm;
using Microsoft.EntityFrameworkCore;

namespace FPLSP.Server.Infrastructure.Services.Implements
{
    public class RoleCPServices : IRoleCPServices
    {
        private readonly IRepository<RoleCP> _Irepository;
        private readonly IMapper _mapper;
        public RoleCPServices(IRepository<RoleCP> Irepository, IMapper mapper)
        {
            _Irepository = Irepository;
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        public async Task<RoleCPViewModel> CreateRole(RoleCPRequest roleCPViewModel)
        {
            try
            {
                var role = new RoleCP
                {
                    Id = Guid.NewGuid(),
                    RoleCode = AutoZenCode(),
                    RoleName = roleCPViewModel.RoleName,
                    Status = roleCPViewModel.Status,
                };
                await _Irepository.AddAsync(role);
                await _Irepository.SaveChangesAsync();
                return await GetRoleListById(role.Id);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<bool> UpdateRole(Guid Id, RoleCPRequest roleCPViewModel)
        {
            try
            {
                var updateRole = _Irepository.AsQueryable().FirstOrDefault(c => Guid.Equals(Id, c.Id));

                updateRole.RoleName = roleCPViewModel.RoleName;
                updateRole.Status = roleCPViewModel.Status;
                await _Irepository.UpdateAsync(updateRole);
                await _Irepository.SaveChangesAsync();
                return true;

            }
            catch (Exception)
            {
                return false;
            }

        }

        public async Task<bool> DeleteRole(Guid Id)
        {
            try
            {
                var roleCPList = await _Irepository.AsQueryable().Where(c => c.Id == Id).ToListAsync();
                foreach (var x in roleCPList)
                {
                    x.Status = 1;
                    await _Irepository.UpdateAsync(x);
                    await _Irepository.SaveChangesAsync();
                }
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<IQueryable<RoleCP>> GetAllRoleAsync()
        {
            try
            {
                var result = _Irepository.AsQueryable().Where(c => c.Status != 3);
                return result;
            }
            catch
            {
                return null;
            }
        }

        public async Task<PageList<RoleCPViewModel>> GetRoleList(RoleCPListSearch search)
        {
            try
            {
                var query = _Irepository.AsQueryable().ProjectTo<RoleCPViewModel>(_mapper.ConfigurationProvider);

                if (!string.IsNullOrEmpty(search.Name))
                    query = query.Where(x => x.RoleCode.ToLower().Contains(search.Name.ToLower()) || x.RoleName.ToLower().Contains(search.Name.ToLower()));
                if (search.Status != null)
                    query = query.Where(x => x.Status == search.Status);

                var count = await query.CountAsync();

                var data = await query.OrderBy(x => x.RoleCode)
                    .Skip((search.PageNumber - 1) * search.PageSize)
                    .Take(search.PageSize)
                    .ToListAsync();

                var temp = new PageList<RoleCPViewModel>(data, count, search.PageNumber, search.PageSize);

                return temp;
            }
            catch
            {
                return null;
            }
        }

        public async Task<RoleCPViewModel> GetRoleListById(Guid Id)
        {
            try
            {
                var rolecp = await _Irepository.AsQueryable().ProjectTo<RoleCPViewModel>(_mapper.ConfigurationProvider).FirstOrDefaultAsync(c => Guid.Equals(Id, c.Id));
                return await Task.FromResult(rolecp);
            }
            catch
            {
                return null;
            }
        }

        public async Task<IQueryable<RoleCPViewModel>> GetRoleMapper()
        {
            try
            {
                var roleCollection = _Irepository.AsQueryable().ProjectTo<RoleCPViewModel>(_mapper.ConfigurationProvider);
                return roleCollection;
            }
            catch (Exception)
            {
                return null;
            }

        }
        private string AutoZenCode()
        {
            try
            {
                var roleCollection = GetAllRoleAsync().Result;
                if (roleCollection.Count() == 0) return "CV1";

                string result = "CV" + (roleCollection.Max(x => Convert.ToInt32(x.RoleCode.Substring(2, x.RoleCode.Length - 2))) + 1).ToString();

                return result;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private async Task<string> GetMaxCode()
        {
            try
            {
                var roleCollection = await GetAllRoleAsync();

                string result = "CV" + roleCollection.Max(x => Convert.ToInt32(x.RoleCode.Substring(2, x.RoleCode.Length - 2))).ToString();

                return result;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<RoleCP> GetRoleMaxCode()
        {
            try
            {
                string maxCode = await GetMaxCode();
                var result = _Irepository.AsQueryable().FirstOrDefault(p => string.Equals(p.RoleCode, maxCode));
                return result;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<bool> RemoveListRoleCP(List<Guid> listId)
        {
            try
            {
                List<RoleCP> roleCP = new List<RoleCP>();
                foreach (var item in listId)
                {
                    roleCP.AddRange(_Irepository.AsQueryable().Where(c => c.Id == item));
                }
                foreach (var item in roleCP)
                {
                    item.Status = 1;
                }
                var result = _Irepository.UpdateRangeAsync(roleCP);
                await _Irepository.SaveChangesAsync();
                return result.IsCompletedSuccessfully;
            }
            catch
            {
                return false;
            }
        }
    }
}
