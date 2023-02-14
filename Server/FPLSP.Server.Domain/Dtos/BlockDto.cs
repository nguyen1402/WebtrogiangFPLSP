using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPLSP.Server.Domain.Dtos
{
    public class BlockDto
    {
        public Guid  Id { get; set; }
        public string NameOfBlock { get; set; }
        public int IndexOfBlock { get; set; }
        public int Status { get; set; }
    }
}
