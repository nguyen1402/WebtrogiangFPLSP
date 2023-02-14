using FPLSP.Server.Data.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPLSP.Server.Infrastructure.ViewModels.CabinProject.TeachingSchedule
{
    public class TeachingScheduleSearch : PagingParameters
    {
        public int? IndexOfTeachingSchedule { get; set; }
    }
}
