using AutoMapper;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Domain.Entities.CoresParts;

namespace FPLSP.Server.Infratructure.AutoMapperConfiguration;

public class StudentMap : Profile // phải kế thừa Profile của Automaper Khi tạo mới
{
    public StudentMap() // Tạo Constructor cho Class và Create map tại Đây
    {
        //Example: máp từ  SinhVienCP => SinhVienDto
        CreateMap<StudentCP, StudentDto>().ReverseMap(); // ReverseMap() dùng để máp ngược lại từ SinhVienDto => SinhVienCP ||| 

    }
}