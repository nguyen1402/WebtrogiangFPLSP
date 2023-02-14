namespace FPLSP.Server.Domain.Dtos.StudentStatisticVM
{
    public class Thongtinlop
    {


        public Guid idClass { get; set; }
        public string NameClass { get; set; }
        public string NameMon { get; set; }
        public DateTime NgayTaoLop { get; set; }
        public int CountHomework { get; set; }
        public int CountSubmit { get; set; }
        public int CountDonSubmit { get; set; }
        public int CountQuiz { get; set; }
        public int CountLessson { get; set; }
        public List<Guid?> Listidlesson { get; set; }
        public List<Guid?> Listidquiz { get; set; }
    }
}
