using FPLSP.Server.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace FPLSP.Server.Infrastructure.ViewModels.QuizQuesstionQuizCP
{
    public class QuizQuesstionQuizCPUpdateVM
    {
        public QuestionForms QuestionForm { get; set; }
        public string? Answer { get; set; }
        public string? Answer2 { get; set; }
        public string? Answer3 { get; set; }
        public string? Answer4 { get; set; }
        public List<string>? lsAnswer { get; set; }
        [Required(ErrorMessage = "Không được bỏ trống câu hỏi")]
        public string ContentQuestion { get; set; }

        public int StatusQuizQuiz { get; set; }
        public bool IsCorrect { get; set; }
        public bool IsCorrect2 { get; set; }
        public bool IsCorrect3 { get; set; }
        public bool IsCorrect4 { get; set; }
        public List<bool> lsIsCorrect { get; set; }
    }
}
