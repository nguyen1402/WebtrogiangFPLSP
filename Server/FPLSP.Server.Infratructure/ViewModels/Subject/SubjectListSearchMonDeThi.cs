using FPLSP.Server.Data.SeedWork;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPLSP.Server.Infrastructure.ViewModels.Subject
{
    public class SubjectListSearchMonDeThi : PagingParameters
    {
        public string? namemon { get; set; }
    }
}
