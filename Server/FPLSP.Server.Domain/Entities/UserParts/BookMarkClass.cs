using FPLSP.Server.Domain.Entities.CoresParts;

namespace FPLSP.Server.Domain.Entities.UserParts
{
    public class BookMarkClass
    {
        public Guid Id { get; set; }
        public int Status { get; set; }
        public int Priority { get; set; }

        public bool IsBookMark { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string IdUser { get; set; }



        public Guid? IdClass { get; set; }
        public Guid? IdSubject { get; set; }

        public virtual UserSignIn UserSignIn { get; set; }
        public virtual SubjectClassUP SubjectClassUP { get; set; }
    }
}
