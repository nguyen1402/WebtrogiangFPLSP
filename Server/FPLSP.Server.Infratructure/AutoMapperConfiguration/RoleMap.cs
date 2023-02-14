using AutoMapper;
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Infrastructure.ViewModels;

namespace FPLSP.Server.Infrastructure.AutoMapperConfiguration
{
    public class RoleMap : Profile
    {
        public RoleMap()
        {
            CreateMap<RoleCP, RoleCPViewModel>().ReverseMap();
        }
    }
}
