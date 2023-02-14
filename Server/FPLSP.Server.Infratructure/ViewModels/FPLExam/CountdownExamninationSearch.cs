using FPLSP.Server.Data.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPLSP.Server.Infrastructure.ViewModels.FPLExam
{
    public class CountdownExamninationSearch : PagingParameters
    {
        public string SubjectName { get; set; }
        public DateTime? StartTime { get; set; } = null;

        public DateTime? EndTime { get; set; } = null;

        public int TimeOderby { get; set; } = 0;
    }
}
