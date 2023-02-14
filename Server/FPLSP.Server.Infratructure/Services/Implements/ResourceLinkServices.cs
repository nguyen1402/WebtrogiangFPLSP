using FPLSP.Server.Data.Repositories.Interfaces;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels.ResourceLink;
using Microsoft.EntityFrameworkCore;

namespace FPLSP.Server.Infrastructure.Services.Implements
{
    public class ResourceLinkServices : IResourceLinkServices
    {
        private readonly IRepository<ResourceLink> _res;
        public ResourceLinkServices(IRepository<ResourceLink> res)
        {
            _res = res;
        }

        public async Task<int> Create(ResourceLinkCreateVM models_create)
        {

            try
            {
                var newrs = new ResourceLink()
                {
                    Path = models_create.Path,
                    Descriptions = models_create.Descriptions,
                    Status = models_create.Status,
                    ResourcesTitle = models_create.ResourcesTitle,
                    DateCreated = DateTime.Now,
                    IdSubject = models_create.IdSubject,
                };
                await _res.AddAsync(newrs);
                await _res.SaveChangesAsync();
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public async Task<int> Delete(Guid id)
        {
            var result = _res.AsQueryable().ToList().FirstOrDefault(c => Equals(id, c.Id));
            try
            {
                if (result.Status == 0)
                {
                    result.Status = 1;
                    await _res.UpdateAsync(result);
                    await _res.SaveChangesAsync();

                }
                else
                {
                    result.Status = 0;
                    await _res.UpdateAsync(result);
                    await _res.SaveChangesAsync();
                }
                return 1;

            }
            catch
            {
                return 0;
            }
        }

        public async Task<List<ResourceLinkDto>> GetAllAsync()
        {
            try
            {
                var ls = _res.AsQueryable().ToList();
                var resuals = ls.Select(x => new ResourceLinkDto()
                {
                    Id = x.Id,
                    Path = x.Path,
                    Descriptions = x.Descriptions,
                    Status = x.Status,
                    ResourcesTitle = x.ResourcesTitle,
                    DateCreated = x.DateCreated,
                    IdSubject = x.IdSubject,
                }).ToList();

                return resuals;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public async Task<ResourceLinkUpdateVM> GetbyId(Guid id)
        {
            try
            {
                var ls = _res.AsQueryable().ToList().Select(x => new ResourceLinkUpdateVM()
                {
                    Id = x.Id,
                    Path = x.Path,
                    Descriptions = x.Descriptions,
                    ResourcesTitle = x.ResourcesTitle,
                    Status = x.Status,
                    IdSubject = x.IdSubject,
                   
                }).ToList();

                var result = ls.FirstOrDefault(x => Equals(id, x.Id));
                return result;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public async Task<PageList<ResourceLinkDto>> Gets(ResourceLinkListSearch parameters)
        {
            try
            {
                var ls =  _res.AsQueryable().ToList().Select(x => new ResourceLinkDto()
                {
                    Id = x.Id,
                    Path = x.Path,
                    Descriptions = x.Descriptions,
                    ResourcesTitle = x.ResourcesTitle,
                    Status = x.Status,
                    DateCreated =x.DateCreated,
                    IdSubject = x.IdSubject,
                    
                }).ToList();

                if (!string.IsNullOrEmpty(parameters.Name))
                    ls = ls.Where(x => x.ResourcesTitle.ToLower().Contains(parameters.Name.ToLower())).ToList();
                if (parameters.Status != 3)
                    ls = ls.Where(x => x.Status == parameters.Status).ToList();   
                if (parameters.IdSubject != Guid.Empty)
                    ls = ls.Where(x => x.IdSubject == parameters.IdSubject).ToList();

                var count = ls.Count();

                var data = ls
                   .Skip((parameters.PageNumber - 1) * parameters.PageSize)
                   .Take(parameters.PageSize)
                   .ToList();

                return new PageList<ResourceLinkDto>(data, count
                    , parameters.PageNumber
                    , parameters.PageSize);
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public async Task<int> Update(Guid id, ResourceLinkUpdateVM models_update)
        {


            try
            {
                var result = _res.AsQueryable().ToList().FirstOrDefault(c => Equals(id, c.Id));

                result.Path = models_update.Path;
                result.Descriptions = models_update.Descriptions;
                result.ResourcesTitle = models_update.ResourcesTitle;
                result.Status = models_update.Status;
                result.IdSubject = models_update.IdSubject;
                await _res.UpdateAsync(result);
                await _res.SaveChangesAsync();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public async Task<bool> RemoveListResourceLink(List<Guid> listIdResource)
        {
            try
            {
                List<ResourceLink> lessonCP = new List<ResourceLink>();
                foreach (var item in listIdResource)
                {

                    var statuss = _res.AsQueryable().ToList().FirstOrDefault(c => c.Id == item);
                    if (statuss.Status == 0)
                    {
                        statuss.Status = 1;
                        await _res.UpdateAsync(statuss);
                        await _res.SaveChangesAsync();
                    }
                    else
                    {
                        statuss.Status = 0;
                        await _res.UpdateAsync(statuss);
                        await _res.SaveChangesAsync();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
    }
}
