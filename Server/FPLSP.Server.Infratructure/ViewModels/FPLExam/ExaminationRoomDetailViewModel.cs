using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FPLSP.Server.Infrastructure.ViewModels.FPLExam
{
    public class ExaminationRoomDetailViewModel 
    {

        public Guid IdExaminationRoom { get; set; }
        public string SecretKey { get; set; }
        //hết các khóa chính
        public int IndexOfExaminationRoomDetail { get; set; }
        public int Status { get; set; }
        public string Note { get; set; }
        //
        public Guid IdExamFile { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public Guid IdSubject { get; set; }
        public Guid IdBlock { get; set; }
        public Guid IdSemester { get; set; }
        //
        public int TotalTimeOfExam { get; set; }
        public string BlockName { get; set; }
        public string SubjectName { get; set; }
        public string SemesterName { get; set; }
        public string ExamFileName { get; set; }

        public string ExaminationRoomName { get; set; }
        public List<Guid> ListSupervisorID { get; set; }
        public List<string> ListStudentId { get; set; }

        [NotMapped]
        public bool IsEditing { get; set; }

    }
}
