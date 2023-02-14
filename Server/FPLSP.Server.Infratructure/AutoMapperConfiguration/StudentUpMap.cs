using AutoMapper;
using FPLSP.Server.Domain.Dtos.StudentUPDtos;
using FPLSP.Server.Domain.Entities.UserParts;
using FPLSP.Server.Infrastructure.ViewModels;

namespace FPLSP.Server.Infratructure.AutoMapperConfiguration;

public class StudentUpMap : Profile // phải kế thừa Profile của Automaper Khi tạo mới
{
    public StudentUpMap() // Tạo Constructor cho Class và Create map tại Đây
    {
        //Example: máp từ  SinhVienCP => SinhVienDto
        CreateMap<StudentUP, StudentUpDto>().ReverseMap(); // ReverseMap() dùng để máp ngược lại từ SinhVienDto => SinhVienCP ||| 
        CreateMap<StudentUP, StudentCreateVm>().ReverseMap();
        CreateMap<StudentUpDto, StudentCreateVm>().ReverseMap();
        CreateMap<StudentUpDto, StudentUpdateVm>().ReverseMap();
    }
}