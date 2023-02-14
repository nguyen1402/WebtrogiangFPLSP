using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPLSP.Server.Domain.Dtos
{
    public class SemesterBlockDto
    {
        public Guid IdBlock { get; set; }
        public Guid IdSemester { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int IndexOfSemesterBlock { get; set; }
        public int Status { get; set; }
    }
}
