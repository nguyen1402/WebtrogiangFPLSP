namespace FPLSP.Server.Domain.Dtos.StudentStatisticVM
{
    public class LinkSubmitSubject
    {
        public Guid Idbaihoc { get; set; }
        public Guid Idstudent { get; set; }
        public string SubjectName { get; set; }
        public string NameLesson { get; set; }
        public string SubmitLink { get; set; }
        public int StatusSubmitHomework { get; set; }
        public int IndexOfLesson { get; set; }
        public int Soluongnopbai { get; set; }
    }
}
