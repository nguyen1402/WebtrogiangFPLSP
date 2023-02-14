using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPLSP.Server.Domain.Dtos
{
    public class SemesterDto
    {
        public Guid Id { get; set; }
        public string NameofSemester { get; set; }
        public int IndexOfSemester { get; set; }
        public int Status { get; set; }
    }
}
