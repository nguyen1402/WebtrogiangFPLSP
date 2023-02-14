using FPLSP.Server.Data.SeedWork;

namespace FPLSP.Server.Infrastructure.ViewModels
{
    public class ClassSearchDTO : PagingParameters
    {
        // Tạo ra 1 đối tưởng ClassSearch Để Phục Vụ Cho Việc Search Data Trả Về

        public string? ClassroomName { get; set; }// tên lớp học 
        public string? ClassroomCode { get; set; }// mã lớp học 
        public string? JoinCode { get; set; }// mã lớp học 
        public Guid? specializedUPId { get; set; }// địa chỉ 
        public Guid? SubjectId { get; set; }// địa chỉ 
        public Guid? LecturterId { get; set; }// địa chỉ 


    }
}
