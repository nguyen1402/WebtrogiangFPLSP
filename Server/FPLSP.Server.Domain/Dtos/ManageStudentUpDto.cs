namespace FPLSP.Server.Domain.Dtos
{
    public class ManageStudentUpDto
    {
        public string ClassroomName { get; set; }// tên lớp học 
        public string ClassroomCode { get; set; }// mã lớp học 
        public string Address { get; set; }// địa chỉ 
        public int StudentAmount { get; set; } // Tổng số lượng sinh viên 

        public int StudentAmountInClass { get; set; } // Số lượng hiện có sinh viên trong lớp
        public int Status { get; set; } // Trạng thái lớp

        public string StudentName { get; set; }//tên sinh viên 
        public string StudentCode { get; set; }// mã sinh viên 

        public string SubjectName { get; set; }

        public Guid IdClass { get; set; }



    }
}
