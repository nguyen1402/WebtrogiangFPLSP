using FPLSP.Server.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace FPLSP.Server.Infrastructure.ViewModels.QuestionType
{
    public class QuestionTypeVm
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Không được bỏ trống tên loại câu hỏi")]
        public string QuestionTypeName { get; set; }
        [Required(ErrorMessage = "Không được bỏ trống mẫu câu hỏi")]
        public QuestionForms QuestionForm { get; set; }
    }
}
