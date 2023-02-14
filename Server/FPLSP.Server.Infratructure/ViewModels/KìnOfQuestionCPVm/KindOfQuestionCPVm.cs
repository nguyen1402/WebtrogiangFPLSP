using FPLSP.Server.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace FPLSP.Server.Infrastructure.ViewModels.KìnOfQuestionCPVm
{
    public class KindOfQuestionCPVm
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Không được bỏ trống Tên loại câu hỏi")]
        public string QuestionTypeName { get; set; }

        // QuestionForm : Mẫu Câu hỏi
        [Required(ErrorMessage = "Không được bỏ trống Mẫu câu hỏi")]
        public QuestionForms QuestionForm { get; set; }
    }
}
