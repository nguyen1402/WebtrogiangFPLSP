using FPLSP.Server.Domain.Entities.UsesParts;
using System.ComponentModel.DataAnnotations.Schema;

namespace FPLSP.Server.Domain.Entities.UserParts
{
    public class VideoHistory
    {


        public Guid IdStudent { get; set; }

        public Guid IdLessonContent { get; set; }
        public DateTime TimeOfSaveHistory { get; set; }
        public DateTime WatchedTime { get; set; }
        public bool IsBookMarked { get; set; }
        public int Status { get; set; }
        [ForeignKey("IdStudent")]
        public virtual StudentUP StudentUP { get; set; }
        [ForeignKey("IdLessonContent")]
        public virtual LessonContentUP LessonContentUP { get; set; }
    }
}
