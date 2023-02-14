using FPLSP.Server.Data.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPLSP.Server.Infrastructure.ViewModels.CabinProject.Cabin
{
    public class CabinSearchViewModel : PagingParameters
    {
        public string? CabinName { get; set; }
        public int? IndexOfCabin { get; set; }
        public DateTime? CreateTime { get; set; }
        public string? BuildingName { get; set; }
        public int? Status { get; set; }
    }
}
