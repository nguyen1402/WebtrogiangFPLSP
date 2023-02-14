using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPLSP.Server.Infrastructure.ViewModels.CabinProject.GroupCabin
{
    public class GroupCabinListVM
    {
        public Guid IdCabin { get; set; }
        public string CabinName { get; set; }
        public DateTime DateOfGrouping { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int Status { get; set; }
        public int IndexOfGroupCabin { get; set; }
        public bool? Checked { get; set; }
    }
}
