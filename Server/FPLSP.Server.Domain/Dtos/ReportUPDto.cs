namespace FPLSP.Server.Domain.Dtos
{
    public class ReportUPDto
    {
        public Guid Id { get; set; }

        public int ReportAmount { get; set; } // số lượt báo cáo 

        public DateTime ReportDate { get; set; }// ngày báo cáo

        public int ReportLevel { get; set; } //Mức độ báo cáo 

        public string Question { get; set; }//câu hỏi

        public string Answer { get; set; }// câu trả lời 

        public string Describe { get; set; } //mô tả 

        public string Note { get; set; }// ghi chú 

        public string ClassCode { get; set; }

        public bool IsDeleted { get; set; }
        public int Status { get; set; }

        public bool IsChecked { get; set; } = false;

    }
}
