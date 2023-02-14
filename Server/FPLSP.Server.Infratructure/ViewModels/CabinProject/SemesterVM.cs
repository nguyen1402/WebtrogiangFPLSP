using FPLSP.Server.Domain.Entities.Cabin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPLSP.Server.Infrastructure.ViewModels.CabinProject
{
    public class SemesterVM
    {
        public Guid Id { get; set; }
        public string NameofSemester { get; set; }
        public int IndexOfSemester { get; set; }
        public int Status { get; set; }
    }
}
