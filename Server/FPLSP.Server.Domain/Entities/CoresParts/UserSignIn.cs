using FPLSP.Server.Domain.Entities.FPLExam;
using FPLSP.Server.Domain.Entities.UserParts;
using Microsoft.AspNetCore.Identity;

namespace FPLSP.Server.Domain.Entities.CoresParts
{
    public class UserSignIn : IdentityUser
    {


        public UserSignIn()
        {

        }
        public Guid IdTrainingFacility { get; set; }
        public virtual TrainingFacilitiesCP TrainingFacilitiesCPs { get; set; }
        public virtual ICollection<News> News { get; set; }
        public virtual ICollection<BookMarkClass> BookMarkClasses { get; set; }
        public virtual ICollection<HomeWork> HomeWorks { get; set; }
        public virtual ICollection<ExamStorage> ExamStorages { get; set; }
        public virtual ICollection<OnlineExamRoom> onlineExamRooms { get; set; }

    }
}
