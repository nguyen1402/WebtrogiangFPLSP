using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPLSP.Server.Domain.Dtos.StudentStatisticVM
{
    public class HomeworkVenha
    {
        public string Code { get; set; }
        public string LinkHomework { get; set; }
        public Guid? idbaihoc { get; set; }
    }
}
