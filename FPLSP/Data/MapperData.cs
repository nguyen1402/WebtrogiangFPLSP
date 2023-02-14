using AutoMapper;
using FPLSP.Server.Domain.Entities.UserParts;
using FPLSP.Server.Infrastructure.ViewModels;

namespace FPLSP.Data
{
    public class MapperData : Profile
    {
        public MapperData()
        {
            CreateMap<StudentViewModel, StudentUP>().ReverseMap();

        }

    }
}
