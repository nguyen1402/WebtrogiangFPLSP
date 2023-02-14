using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Infrastructure.ViewModels.ResourceLink;

namespace FPLSP.Server.Infrastructure.Services.Interfaces
{
    public interface IResourceLinkServices
    {
        Task<PageList<ResourceLinkDto>> Gets(ResourceLinkListSearch parameters);
        Task<ResourceLinkUpdateVM> GetbyId(Guid id);
        Task<List<ResourceLinkDto>> GetAllAsync();
        Task<int> Create(ResourceLinkCreateVM models_create);
        Task<int> Update(Guid id, ResourceLinkUpdateVM models_update);
        Task<int> Delete(Guid id);
        Task<bool> RemoveListResourceLink(List<Guid> listIdResource);
    }
}
