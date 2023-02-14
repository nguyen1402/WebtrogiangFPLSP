using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Domain.Entities.UsesParts;

namespace FPLSP.Server.Domain.Entities.UserParts
{
    public class HomeWork
    {
        public Guid Id { get; set; }
        public string LinkHomeWork { get; set; }
        public Guid? IdClass { get; set; }
        public Guid? IdSubject { get; set; }
        public Guid? IdLesson { get; set; }
        public string? IdUser { get; set; }


        public virtual SubjectClassUP SubjectClassUP { get; set; }
        public virtual UserSignIn UserSignIn { get; set; }
        public virtual LessonUP LessonUP { get; set; }

    }
}
