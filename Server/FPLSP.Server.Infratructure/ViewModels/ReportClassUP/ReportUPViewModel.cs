using System.ComponentModel.DataAnnotations;

namespace FPLSP.Server.Infrastructure.ViewModels.ReportClassUP
{
    public class ReportUPViewModel
    {
        public Guid Id { get; set; }
        [RegularExpression(@"^[1-9]*$",
        ErrorMessage = "Số đánh giá phải lớn hơn 1")]
        public int ReportAmount { get; set; } // số lượt báo cáo 

        public DateTime ReportDate { get; set; }// ngày báo cáo

        public int ReportLevel { get; set; } //Mức độ báo cáo 

        [Required(ErrorMessage = "Câu hỏi không được để trống")]
        public string Question { get; set; }//câu hỏi

        [Required(ErrorMessage = "Câu trả lời không được để trống")]
        public string Answer { get; set; }// câu trả lời 

        [Required(ErrorMessage = "Mô tả không được để trống")]
        public string Describe { get; set; } //mô tả 

        [MaxLength(250, ErrorMessage = "Bạn không thể điền quá 250 kí tự")]
        [Required(ErrorMessage = "Ghi chú không được để trống")]
        public string Note { get; set; }// ghi chú 

        public int Status { get; set; }

        public Guid? ClassId { get; set; }

        public DateTimeOffset CreateTime { get; set; }

        public Guid CreateBy { get; set; }

        public DateTimeOffset ModifiedTime { get; set; }

        public Guid ModifiedBy { get; set; }

        public bool IsDeleted { get; set; }

        public Guid DeletedBy { get; set; }

        public DateTimeOffset DeletedTime { get; set; }

    }
}
