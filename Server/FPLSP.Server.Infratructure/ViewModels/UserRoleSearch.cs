using FPLSP.Server.Data.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPLSP.Server.Infrastructure.ViewModels
{
    public class UserRoleSearch : PagingParameters
    {
        public string? Role { get; set; }
        public string? Name { get; set; }

        public int StatusNotRole { get; set; }
    }
}
