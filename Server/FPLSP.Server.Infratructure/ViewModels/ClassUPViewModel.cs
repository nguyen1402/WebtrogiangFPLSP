using FPLSP.Server.Domain.Entities.UserParts;
using System.ComponentModel.DataAnnotations;

namespace FPLSP.Server.Infrastructure.ViewModels
{
    public class ClassUPViewModel
    {


        public Guid Id { get; set; }

        [Required(ErrorMessage = "Class Name Mustn't Be Blank")]
        [RegularExpression(@"^[A-Z''-'\d/s/]{1,10}$",
         ErrorMessage = "Invalid ClassroomName")]
        [MaxLength(20, ErrorMessage = "ClassroomName Is Too Long.")]
        public string ClassroomName { get; set; }// tên lớp học 

       

        [Required(ErrorMessage = "Place Mustn't Be Blank")]
        [RegularExpression(@"^[A-Z''-'\d/s/]$",
         ErrorMessage = "Place Address Invalid")]
        [MaxLength(20, ErrorMessage = "Address Is Too Long.")]
        public string Building { get; set; }// địa chỉ


        [Required(ErrorMessage = "StudentAmount Mustn't Be Blank")]
        [RegularExpression(@"\d{2}$",
        ErrorMessage = "Invalid StudentAmount(It's Must Be 20-50 Students In A Class) ")]
        [Range(20, 50, ErrorMessage = "StudentAmount Valid In Range [20-50].")]
        public int StudentAmount { get; set; } // số lượng sinh viên


        [Required(ErrorMessage = "Status Must Be Checked")]
        [RegularExpression(@"\d{1}$",
        ErrorMessage = "Invalid Status")]
        [Range(0, 3, ErrorMessage = "Status InValid")]
        public int Status { get; set; }// trạng thái 

        public DateTime DateCreated { get; set; }
        public DateTime DateStarted { get; set; }
        public DateTime EndDate { get; set; }

        public string HomeroomLecturer { get; set; }
        public string SubjectName { get; set; }
        public string HomeroomLecturerEmail { get; set; }
        public string HomeroomLecturerPhoneNumber { get; set; }
        public Guid HomeroomLecturerId { get; set; }

        public int ActualNumberOfStudent { get; set; }

        //các bảng liên đới để truy vấn hiển thị ra lớp học
        public List<Guid?> SpecializedName { get; set; }
        public Guid SpecializedId { get; set; }
        public string JoinCode { get; set; }

        public Guid? SubjectId { get; set; }
        public List<Guid?> subjectUP { get; set; }

        public StudentClassUP? studentClassUP { get; set; }

        public List<Guid?> ListStudent { get; set; }

    }
}
