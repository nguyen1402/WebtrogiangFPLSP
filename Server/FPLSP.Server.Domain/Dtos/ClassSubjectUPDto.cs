namespace FPLSP.Server.Domain.Dtos
{
    public class ClassSubjectUPDto
    {
        public Guid? LectuterId { get; set; }
        public Guid? SpecializedId { get; set; }
        public Guid? SubjectId { get; set; }
        public Guid? ClassId { get; set; }
        public string JoinCode { get; set; }

        public Guid HomeroomLecturer { get; set; }
        public Guid SpecializedOfClass { get; set; }

        public string ClassroomName { get; set; }// tên lớp học 
        public string ClassroomCode { get; set; }// mã lớp học 
        public string Building { get; set; }// Tòa Nhà 
        public int StudentAmount { get; set; } // số lượng sinh viên 
        public int StatusClass { get; set; }// trạng thái 
        public int StatusSubjectClass { get; set; }// trạng thái 
        public string SpecializationName { get; set; }
        public string SubjectName { get; set; }
        public DateTime CreatedDayClass { get; set; }
        public DateTime CreatedDay { get; set; }
        public DateTime StartDay { get; set; }
        public DateTime EndDay { get; set; }
        public int TotalOfSub { get; set; }
        public string LecturersName { get; set; }
        public bool Gender { get; set; }
        public DateTime Dob { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int Sinhvienthucte { get; set; }
        public string Address { get; set; }
        public string ImageUrl { get; set; }

        public bool IsChecked { get; set; } = false;
    }
}
