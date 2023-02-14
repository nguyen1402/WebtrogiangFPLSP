using AutoMapper;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Domain.Entities.UsesParts;
using FPLSP.Server.Infrastructure.ViewModels.ResourceLinkUP;

namespace FPLSP.Server.Infratructure.AutoMapperConfiguration;

public class ResourceLinkUPMap : Profile // phải kế thừa Profile của Automaper Khi tạo mới
{
    public ResourceLinkUPMap() // Tạo Constructor cho Class và Create map tại Đây
    {
        CreateMap<ResourceLinkUP, ResourceLinkUPViewModel>().ReverseMap(); // ReverseMap() dùng để máp ngược lại từ ResourceLinkUPViewModel => ResourceLinkUP |||
        CreateMap<ResourceLinkUP, ResourceLinkUPDto>();
    }
}
