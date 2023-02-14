using FPLSP.Server.Domain.Entities.EntitiesBase;
using FPLSP.Server.Domain.Entities.UserParts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPLSP.Server.Domain.Entities.Cabin
{
    public class FeedBack : EntityBase<Guid>
    {
      
        public string Note { get; set; }
        public int IndexOfFeedBack { get; set; }
        public int Status { get; set; }
        public DateTime FeedBackTime { get; set; }
        public string ContentOfFeedback { get; set; }
        //khoas ngoa
        public Guid SubjectId { get; set; }
        public Guid ClassId { get; set; }
        public Guid IdStudent { get; set; }
        //
        public virtual SubjectClassUP SubjectClassUP { get; set; }
        public virtual StudentUP StudentUP { get; set; }
    }
}
