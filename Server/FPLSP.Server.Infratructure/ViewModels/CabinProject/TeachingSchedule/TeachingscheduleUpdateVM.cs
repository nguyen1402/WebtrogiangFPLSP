using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPLSP.Server.Infrastructure.ViewModels.CabinProject.TeachingSchedule
{
    public class TeachingscheduleUpdateVM
    {
        public DateTime ImportTime { get; set; }
        public Guid IdAdminImport { get; set; }
        public Guid SubjectId { get; set; }
        public Guid ClassId { get; set; }
        public Guid IdShift { get; set; }

        public DateTime TeachingDay { get; set; }
        public int IndexOfTeachingSchedule { get; set; }
        public int Status { get; set; }
        //
        public Guid IdBlock { get; set; }

        public Guid IdSemester { get; set; }
    }
}
