using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPLSP.Server.Infrastructure.ViewModels.QuizCPVm
{
    public class QuizAnswerExcel
    {
        public Guid Id { get; set; }
        public string Answer { get; set; }
        public int IsCorrect { get; set; }
        public Guid IdQuizQuestion { get; set; }
    }
}
