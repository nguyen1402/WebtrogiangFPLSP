using FPLSP.Server.Domain.Entities.UserParts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPLSP.Server.Domain.Entities.Cabin
{
    public class FeedBackOutSide
    {
        public int Id { get; set; }
        public string Note { get; set; }
        public string ContentOfFeedback { get; set; }
        public string ClassName { get; set; }
        public string StudentCode { get; set; }
        public string StudentName { get; set; }
       


    }
}
