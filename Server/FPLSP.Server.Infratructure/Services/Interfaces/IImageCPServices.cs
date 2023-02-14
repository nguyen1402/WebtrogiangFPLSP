using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Infrastructure.ViewModels.ImagesCP;

namespace FPLSP.Server.Infrastructure.Services.Interfaces
{
    public interface IImageCPServices
    {
        Task<PageList<ImageCP>> GetImageCPList(ImageCPListSearchVm SearchVm);
        Task<PageList<ImageCP>> GetImageCPListByCoeId(Guid Id, ImageCPListSearchVm SearchVm);
        Task<ImageCP> CreateImageCP(ImageCP imageCP);
        Task<ImageCP> UpdateImageCP(Guid id, ImageCPUpdateVm imageCPUpdateVm);
        Task<ImageCP> DeleteImageCP(Guid id);

        Task<ImageCP> GetImageCPById(Guid id);
    }
}
