using AutoMapper;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Domain.Entities.UserParts;
using FPLSP.Server.Infrastructure.ViewModels;
using FPLSP.Server.Infrastructure.ViewModels.BookMark;

namespace FPLSP.Server.Infrastructure.AutoMapperConfiguration
{
    public class ClassRoomMap : Profile
    {
        public ClassRoomMap()
        {
            CreateMap<ClassUp, ClassRoomDto>().ReverseMap();
            CreateMap<ClassUp, ClassUPViewModel>().ReverseMap();
            CreateMap<ClassUPViewModel, CreateClassVM>().ReverseMap();
            CreateMap<ClassUp, CreateClassVM>().ReverseMap();
            CreateMap<BookMarkClass, BookMarkClassVM>().ReverseMap();

        }
    }
}
