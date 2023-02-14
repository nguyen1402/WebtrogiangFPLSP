using FPLSP.Server.Domain.Entities.EntitiesBase;
using FPLSP.Server.Domain.Entities.FPLExam;
using FPLSP.Server.Domain.Entities.UserParts;

namespace FPLSP.Server.Domain.Entities.UsesParts;

public class SubjectUP : FullEntityBase<Guid>
{
    // SubjectName : Tên môn học
    public string SubjectCode { get; set; }
    public string SubjectName { get; set; }
    public DateTime CreatedDay { get; set; }
    public DateTime StartDay { get; set; }
    public DateTime EndDay { get; set; }
    public bool IsDemo { get; set; }
    public int TotalOfSub { get; set; }
    public int Status { get; set; }
    public string Image { get; set; }

    public virtual ICollection<QuizUP> QuizUPs { get; set; }

    public virtual ICollection<SpecializedSubjectUP> SpecializedSubjectUPs { get; set; }
    public virtual ICollection<SubjectClassUP> SubjectClassUPs { get; set; }

    public virtual ICollection<LessonUP> LessonUps { get; set; }
    public virtual ICollection<ExamStorage> ExamStorages { get; set; }
    public virtual ICollection<ExaminationRoomDetail> ExaminationRoomDetails { get; set; }
    public virtual ICollection<SubjectTeacher> SubjectTeachers { get; set; }
}