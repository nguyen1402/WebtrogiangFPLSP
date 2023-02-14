namespace FPLSP.Server.Domain.Dtos
{
    public class ClassRoomDto
    {
        public Guid Id { get; set; }
        public string ClassroomName { get; set; }// tên lớp học 
        public string ClassroomCode { get; set; }// mã lớp học 
        public string Address { get; set; }// địa chỉ 
        public int StudentAmount { get; set; } // số lượng sinh viên 
        public int Status { get; set; }// trạng thái 
    }
}
