using FPLSP.Server.Data.SeedWork;

namespace FPLSP.Server.Infrastructure.ViewModels.ImagesCP
{
    public class ImageCPListSearchVm : PagingParameters
    {

        public string? Path { get; set; } = string.Empty;
        public string? Descriptions { get; set; } = string.Empty;
        public int? Status { get; set; } = 0;
    }
}
