using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPLSP.Server.Infrastructure.ViewModels.FPLExam
{
    public class SubjectTeacherViewModel
    {
        public string? Name { get; set; }
        public Guid IdTeacher { get; set; }
        public Guid IdSubject { get; set; }
        public DateTime AddingTime { get; set; }
        public int Status { get; set; }
    }
}
