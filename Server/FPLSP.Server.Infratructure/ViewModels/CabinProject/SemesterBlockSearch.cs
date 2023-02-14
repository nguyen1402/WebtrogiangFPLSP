using FPLSP.Server.Data.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPLSP.Server.Infrastructure.ViewModels.CabinProject
{
    public class SemesterBlockSearch : PagingParameters
    {
        public int? Status { get; set; }
        public string? Search { get; set; }
    }
}
