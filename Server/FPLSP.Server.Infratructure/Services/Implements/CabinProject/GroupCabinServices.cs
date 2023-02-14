using AutoMapper;
using AutoMapper.QueryableExtensions;
using FPLSP.Server.Data.Repositories.Interfaces;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Entities.CabinProject;
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Domain.Entities.UserParts;
using FPLSP.Server.Infrastructure.Services.Interfaces.CabinProject;
using FPLSP.Server.Infrastructure.ViewModels;
using FPLSP.Server.Infrastructure.ViewModels.CabinProject.GroupCabin;
using FPLSP.Server.Infratructure.AutoMapperConfiguration;
using IdentityServer4.Extensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPLSP.Server.Infrastructure.Services.Implements.CabinProject
{
    public class GroupCabinServices : IGroupCabinServices
    {
        private readonly IRepository<GroupCabin> _Irepository;
        private readonly IMapper _mapper;

        public GroupCabinServices(IRepository<GroupCabin> Irepository, IMapper mapper)
        {
            _Irepository = Irepository;
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<GroupCabinViewModel> CreateGroupCabin(GroupCabinCreateViewModel request)
        {
            try
            {
                int index = 0;
                var objCollection = _Irepository.AsQueryable().ToList();
                if (objCollection.Count > 0)
                {
                    index = objCollection.Max(c => c.IndexOfGroupCabin) + 1;
                }

                var obj = new GroupCabin
                {
                    IdCabin = request.IdCabin,
                    IdSpec = request.IdSpec,
                    GroupCabinName = request.GroupCabinName,
                    DateOfGrouping = DateTime.Now,
                    StartTime = request.StartTime,
                    EndTime = request.EndTime,
                    IndexOfGroupCabin = index,
                    Status = request.Status,
                };
                await _Irepository.AddAsync(obj);
                await _Irepository.SaveChangesAsync();
                return await GetGroupCabinListById(obj.IdSpec, obj.IdCabin);
            }
            catch
            {
                return null;
            }

        }
        public async Task<bool> ChangeStatus(Guid IdSpec, Guid IdCabin)
        {
            try
            {
                var obj = await _Irepository.AsQueryable().FirstOrDefaultAsync(c => Equals(IdSpec, c.IdSpec) && Equals(IdCabin, c.IdCabin));
                if (obj != null)
                {
                    obj.Status = 0;
                    await _Irepository.UpdateAsync(obj);
                    await _Irepository.SaveChangesAsync();
                    return true;

                }
                return false;


            }
            catch
            {
                return false;
            }
        }
        public async Task<bool> DeleteGroupCabin(Guid IdSpec, Guid IdCabin)
        {
            try
            {
                var obj = await _Irepository.AsQueryable().FirstOrDefaultAsync(c => Equals(IdSpec, c.IdSpec) && Equals(IdCabin, c.IdCabin));
                obj.Status = 1;
                await _Irepository.UpdateAsync(obj);
                await _Irepository.SaveChangesAsync();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<List<GroupCabinViewModel>> GetAllGroupCabinAsync()
        {
            try
            {
                var objCollection = _Irepository.AsQueryable().ProjectTo<GroupCabinViewModel>(_mapper.ConfigurationProvider).ToList();
                return objCollection;
            }
            catch
            {
                return null;
            }
        }

        public async Task<GroupCabinViewModel> GetGroupCabinListById(Guid IdSpec, Guid IdCabin)
        {
            try
            {
                var obj = await _Irepository.AsQueryable().SingleOrDefaultAsync(c => c.IdSpec == IdSpec && c.IdCabin == IdCabin);
                var objModel = _mapper.Map<GroupCabinViewModel>(obj);
                return objModel;
            }
            catch
            {
                return null;
            }
        }

        public async Task<PageList<GroupCabinViewModel>> GetGroupCabinListSearch(GroupCabinSearchViewModel search)
        {
            try
            {
                var objCollection = _Irepository.AsQueryable().Where(x => x.Status != 1).ProjectTo<GroupCabinViewModel>(_mapper.ConfigurationProvider).ToList();

                // Danh sách các parameter muốn dùng để search
                if (!string.IsNullOrEmpty(search.GroupCabinName))
                    objCollection = objCollection.Where(x => x.GroupCabinName == search.GroupCabinName).ToList();
                if (!string.IsNullOrEmpty(Convert.ToString(search.IdSpec)))
                    objCollection = objCollection.Where(x => x.IdSpec == search.IdSpec).ToList();

                var count = objCollection.Count();

                var data = objCollection.Skip((search.PageNumber - 1) * search.PageSize).Take(search.PageSize).ToList();
                var result = new PageList<GroupCabinViewModel>(data, count, search.PageNumber, search.PageSize);
                return result;
            }
            catch
            {
                return null;
            }
        }

        public async Task<bool> RemoveListGroupCabin(List<(Guid, Guid)> listIdSpecCabin)
        {
            try
            {
                List<GroupCabin> objCollection = new List<GroupCabin>();
                foreach (var item in listIdSpecCabin)
                {
                    objCollection.AddRange(_Irepository.AsQueryable().Where(c => c.IdSpec == item.Item1 && c.IdSpec == item.Item2));
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

        public async Task<bool> UpdateGroupCabin(Guid IdSpec, Guid IdCabin, GroupCabinUpdateViewModel request)
        {
            try
            {
                var obj = await _Irepository.AsQueryable().FirstOrDefaultAsync(c => c.IdSpec == IdSpec && c.IdCabin == IdCabin);

                //obj.IdCabin = request.IdCabin;
                //obj.IdSpec = request.IdSpec;
                obj.GroupCabinName = request.GroupCabinName;
                //obj.DateOfGrouping = DateTime.Now;
                obj.StartTime = request.StartTime;
                obj.EndTime = request.EndTime;
                obj.IndexOfGroupCabin = request.IndexOfGroupCabin;
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
