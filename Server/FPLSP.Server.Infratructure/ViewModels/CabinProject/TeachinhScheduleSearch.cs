using FPLSP.Server.Data.SeedWork;

namespace FPLSP.Server.Infrastructure.ViewModels.CabinProject
{
    public class TeachinhScheduleSearch : PagingParameterForSchedule
    {
        public Guid? specializedUPId { get; set; }// địa chỉ 
        public string? LecturterName { get; set; }// địa chỉ 
        public string? Email { get; set; }// địa chỉ 
        public Guid? BlockId { get; set; }// địa chỉ 
        public Guid? SemesterId { get; set; }// địa chỉ 




    }
}
