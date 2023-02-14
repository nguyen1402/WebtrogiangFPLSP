using AutoMapper;
using FPLSP.Server.Domain.Entities.CabinProject;
using FPLSP.Server.Infrastructure.ViewModels.CabinProject.BookingRequest;

namespace FPLSP.Server.Infrastructure.AutoMapperConfiguration.CabinProject;

public class BookingRequestMap : Profile // phải kế thừa Profile của Automaper Khi tạo mới
{
    public BookingRequestMap() // Tạo Constructor cho Class và Create map tại Đây
    {
        //Example: map từ  LecturersCP => LecturerDto
        CreateMap<BookingRequest, BookingRequestViewModel>().ReverseMap(); // ReverseMap() dùng để máp ngược lại từ LecturerDto => LecturersCP ||| 

    }
}