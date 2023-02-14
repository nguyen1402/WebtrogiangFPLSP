using AutoMapper;
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Infrastructure.ViewModels;

namespace FPLSP.Server.Infratructure.AutoMapperConfiguration;

public class LecturerMap : Profile // phải kế thừa Profile của Automaper Khi tạo mới
{
    public LecturerMap() // Tạo Constructor cho Class và Create map tại Đây
    {
        //Example: map từ  LecturersCP => LecturerDto
        CreateMap<LecturersCP, LecturersCPViewModel>().ReverseMap(); // ReverseMap() dùng để máp ngược lại từ LecturerDto => LecturersCP ||| 

    }
}