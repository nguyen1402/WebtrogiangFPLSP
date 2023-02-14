using System.ComponentModel.DataAnnotations;

namespace FPLSP.Server.Infrastructure.ViewModels.QuizAnswerCPVm
{
    public class CreateQuizAnswerCPVm
    {
        [Required(ErrorMessage = "Không được bỏ trống Câu trả lời")]
        public string Answer { get; set; }
        [Required(ErrorMessage = "Không được bỏ trống Mã câu hỏi")]
        public Guid IdQuizQuestion { get; set; }
    }
}
