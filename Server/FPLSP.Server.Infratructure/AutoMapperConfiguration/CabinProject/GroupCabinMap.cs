using AutoMapper;
using FPLSP.Server.Domain.Entities.CabinProject;
using FPLSP.Server.Infrastructure.ViewModels.CabinProject.GroupCabin;

namespace FPLSP.Server.Infrastructure.AutoMapperConfiguration.CabinProject;

public class GroupCabinMap : Profile // phải kế thừa Profile của Automaper Khi tạo mới
{
    public GroupCabinMap() // Tạo Constructor cho Class và Create map tại Đây
    {
        //Example: map từ  LecturersCP => LecturerDto
        CreateMap<GroupCabin, GroupCabinViewModel>().ReverseMap(); // ReverseMap() dùng để máp ngược lại từ LecturerDto => LecturersCP ||| 

    }
}