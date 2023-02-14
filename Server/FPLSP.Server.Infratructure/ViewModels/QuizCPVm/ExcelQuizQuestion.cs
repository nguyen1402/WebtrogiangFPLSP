using FPLSP.Server.Domain.Entities.CoresParts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPLSP.Server.Infrastructure.ViewModels.QuizCPVm
{
    public class ExcelQuizQuestion
    {
        public ExcelQuizQuestion()
        {
            ListIsCorrect = new List<string>();
            ListAnswer = new List<QuizAnswerExcel>();
        }
        public Guid Id { get; set; }
        public Guid IdQuiz { get; set; }
        public int Index { get; set; }
        public Guid IdQuestion { get; set; }
        public string ContentQuestion { get; set; }

        public List<QuizAnswerExcel> ListAnswer { get; set; }

        public string QuestionTypeName { get; set; }
        public List<string> ListIsCorrect { get; set; }

        public bool IsEditing { get; set; }
    }
}
