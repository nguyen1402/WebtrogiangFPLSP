using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPLSP.Server.Infrastructure.ViewModels.FPLExam
{
    public class StudentToExamSearch
    {
        public string? nammon { get; set; }
        public DateTime? ngaybatdau { get; set; } = null;
        public DateTime? ngayketthuc { get; set; } = null;
    }
}
