using AutoMapper;
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Infrastructure.ViewModels;

namespace FPLSP.Server.Infratructure.AutoMapperConfiguration;

public class TrainingFacilityMap : Profile // phải kế thừa Profile của Automaper Khi tạo mới
{
    public TrainingFacilityMap() // Tạo Constructor cho Class và Create map tại Đây
    {
        CreateMap<TrainingFacilitiesCP, TrainingFacilitiesCPViewModel>().ReverseMap(); // ReverseMap() dùng để máp ngược lại từ Vm
    }
}