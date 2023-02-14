using AutoMapper;
using FPLSP.Server.Domain.Entities.CabinProject;
using FPLSP.Server.Infrastructure.ViewModels.CabinProject.Cabin;

namespace FPLSP.Server.Infrastructure.AutoMapperConfiguration.CabinProject;

public class CabinMap : Profile // phải kế thừa Profile của Automaper Khi tạo mới
{
    public CabinMap() // Tạo Constructor cho Class và Create map tại Đây
    {
        //Example: map từ  LecturersCP => LecturerDto
        CreateMap<Cabin, CabinViewModel>().ReverseMap(); // ReverseMap() dùng để máp ngược lại từ LecturerDto => LecturersCP ||| 

    }
}