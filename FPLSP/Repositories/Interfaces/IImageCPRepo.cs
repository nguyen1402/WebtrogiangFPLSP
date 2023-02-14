using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Infrastructure.ViewModels.ImagesCP;

namespace FPLSP.Repositories.Interfaces
{
    public interface IImageCPRepo
    {
        Task<PageList<ImageCPDto>> GetImageCPList(ImageCPListSearchVm ListSearch);
        Task<PageList<ImageCPDto>> GetImageCPListByExamId(Guid Id, ImageCPListSearchVm ListSearch);

        Task<ImageCP> GetImageCPById(Guid Id);
        Task<bool> CreateImageCP(ImageCPCreateVm CreateVm);
        Task<bool> UpdateImageCP(Guid id, ImageCPUpdateVm UpdateVm);
        Task<bool> DeleteImageCP(Guid id);
    }
}
