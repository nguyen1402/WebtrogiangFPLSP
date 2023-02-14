using FPLSP.Server.Domain.Entities.Cabin;
using FPLSP.Server.Domain.Entities.CabinProject;
using FPLSP.Server.Domain.Entities.UsesParts;
using System.ComponentModel.DataAnnotations.Schema;

namespace FPLSP.Server.Domain.Entities.UserParts
{
    public class SubjectClassUP
    {
        public Guid? SubjectId { get; set; }
        // QuizId : Id câu hỏi 
        public Guid? ClassId { get; set; }
        [ForeignKey("SubjectId")]
        public virtual SubjectUP SubjectUP { get; set; }
        [ForeignKey("ClassId")]
        public virtual ClassUp ClassUp { get; set; }
        public int Status { get; set; }
        public int StudentAmount { get; set; }
        public string JoinCode { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateStarted { get; set; }
        public DateTime EndDate { get; set; }
        public Guid HomeroomLecturer { get; set; }
        public Guid SpecializedOfClass { get; set; }

        public virtual ICollection<News> News { get; set; }
        public virtual ICollection<BookMarkClass> bookMarkClasses { get; set; }
        public virtual ICollection<SubmitHomeWork> submitHomeWorks { get; set; }
        public virtual ICollection<HomeWork> HomeWorks { get; set; }
        public virtual ICollection<BookingCabin> BookingCabins { get; set; }
        public virtual ICollection<TeachingSchedule> TeachingSchedules { get; set; }
        public virtual ICollection<FeedBack> FeedBacks { get; set; }
        public virtual ICollection<BookingRequest> BookingRequests { get; set; }


    }
}
