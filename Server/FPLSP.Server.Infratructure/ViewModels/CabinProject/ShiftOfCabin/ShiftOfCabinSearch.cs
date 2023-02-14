using FPLSP.Server.Data.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPLSP.Server.Infrastructure.ViewModels.CabinProject.ShiftOfCabin
{
    public class ShiftOfCabinSearch : PagingParameters
    {
        public string? ShiftName { get; set; }
        public int? IndexOfShift { get; set; }
        public TimeSpan? StartTime { get; set; }
        public TimeSpan? EndTime { get; set; }

        public int? Status { get; set; }
    }
}
