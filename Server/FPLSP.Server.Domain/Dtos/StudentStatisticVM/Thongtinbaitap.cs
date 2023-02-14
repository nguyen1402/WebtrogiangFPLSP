using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPLSP.Server.Domain.Dtos.StudentStatisticVM
{
    public class Thongtinbaitap
    {
        public Guid Idstudent { get; set; }
        public Guid IdLesson { get; set; }
        public string SubjectName { get; set; }
        public Guid Idsubject { get; set; }
        public string SubmitLink { get; set; }
        public int StatusSubmitHomework { get; set; }
        public int IndexOfLesson { get; set; }
         
                          
                         
                          
                          
                         
                          
                         
    }
}
