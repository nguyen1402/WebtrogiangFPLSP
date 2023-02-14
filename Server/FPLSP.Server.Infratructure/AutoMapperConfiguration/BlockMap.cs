using AutoMapper;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Domain.Entities.CabinProject;
using FPLSP.Server.Infrastructure.ViewModels.CabinProject;

namespace FPLSP.Server.Infrastructure.AutoMapperConfiguration
{
    public class BlockMap : Profile
    {
        public BlockMap()
        {
            CreateMap<Block, BlockDto>().ReverseMap();
            CreateMap<Block, BlockVM>().ReverseMap();
        }
    }
}
