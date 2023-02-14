using FPLSP.Server.Domain.Entities.EntitiesBase;

namespace FPLSP.Server.Domain.Entities.UserParts
{
    public class ReportClassUP : FullEntityBase<Guid>
    {
        // 
        public int ReportAmount { get; set; } // số lượt báo cáo 
        public DateTime ReportDate { get; set; }// ngày báo cáo
        public int ReportLevel { get; set; } //Mức độ báo cáo 
        public string Question { get; set; }//câu hỏi
        public string Answer { get; set; }// câu trả lời 
        public string Describe { get; set; } //mô tả 
        public string Note { get; set; }// ghi chú 
        public int Status { get; set; }
        public Guid? ClassId { get; set; }

        public ClassUp ClassUp { get; set; }
    }
}
