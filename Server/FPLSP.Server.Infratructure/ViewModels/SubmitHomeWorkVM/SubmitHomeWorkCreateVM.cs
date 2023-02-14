using System.ComponentModel.DataAnnotations;

namespace FPLSP.Server.Infrastructure.ViewModels.SubmitHomeWorkVM
{
    public class SubmitHomeWorkCreateVM
    {
        [DataType(DataType.DateTime, ErrorMessage = "Nhập đúng định dạng thời gian")]
        public DateTime StartedDate { get; set; } = DateTime.Now;
        [DataType(DataType.DateTime, ErrorMessage = "Nhập đúng định dạng thời gian")]
        public DateTime EndTime { get; set; } = DateTime.Now;
        public DateTime? SubmitTime { get; set; } = DateTime.Now;
        public Guid IdClass { get; set; }
        public Guid IdSubject { get; set; }
        public List<Guid?> LsIdStudent { get; set; }
        public Guid IdLesson { get; set; }
        public string Titile { get; set; }
    }
}
