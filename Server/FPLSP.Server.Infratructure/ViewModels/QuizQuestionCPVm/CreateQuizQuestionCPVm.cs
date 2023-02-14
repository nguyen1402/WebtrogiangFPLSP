using FPLSP.Server.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace FPLSP.Server.Infrastructure.ViewModels.QuizQuestionCPVm
{
    public class CreateQuizQuestionCPVm
    {
        [Required(ErrorMessage = "Không được bỏ trống Loại câu hỏi")]
        public Guid? KindoOfQuestionId { get; set; }
        public QuestionForms QuestionForm { get; set; }
        [Required(ErrorMessage = "Không được bỏ trống Tên câu hỏi")]
        public string QuestionName { get; set; }
        [Required(ErrorMessage = "Không được bỏ trống Mã câu hỏi")]
        public string QuestionCode { get; set; }
        public int Status { get; set; }
    }
}
