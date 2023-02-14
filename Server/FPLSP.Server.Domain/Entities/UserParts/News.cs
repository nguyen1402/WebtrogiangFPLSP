
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Domain.Entities.UsesParts;

namespace FPLSP.Server.Domain.Entities.UserParts
{
    public class News
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string? Image { get; set; }
        public int Status { get; set; }
        public DateTime CratedTime { get; set; }
        public DateTime EndDate { get; set; }
        public int Priority { get; set; }
        //xét đến khóa ngoại
        public bool IsReaded { get; set; }
        public string IdUser { get; set; }
        public Guid? IdClass { get; set; }
        public Guid? IdSubject { get; set; }
        public Guid? IdTypeOfNewFeed { get; set; }
        public Guid? IdLesson { get; set; }

        public virtual UserSignIn UserSignIn { get; set; }
        public virtual SubjectClassUP SubjectClassUP { get; set; }
        public virtual TypeOfNewFeed TypeOfNewFeed { get; set; }
        public virtual LessonUP LessonUP { get; set; }

    }
}
