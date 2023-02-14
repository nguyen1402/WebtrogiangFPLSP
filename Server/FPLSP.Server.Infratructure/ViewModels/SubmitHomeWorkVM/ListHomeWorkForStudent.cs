namespace FPLSP.Server.Infrastructure.ViewModels.SubmitHomeWorkVM
{
    public class ListHomeWorkForStudent
    {
        public Guid Id { get; set; }
        public string Titile { get; set; }
        public List<SetMultipleClass> setMultipleClasses { get; set; }

        public DateTime? SubmitTime { get; set; }
        public string? SubmitLink { get; set; }
        public int Status { get; set; }
        public Guid IdStudent { get; set; }



    }

    public class SetMultipleClass
    {
        public Guid IdClass { get; set; }
        public string JoinCode { get; set; }
        public Guid IdSubject { get; set; }
        public Guid IdLesson { get; set; }
        public string ClassNanme { get; set; }
        public string SubjectName { get; set; }
        public DateTime StartedDate { get; set; }
        public DateTime EndTime { get; set; }
        public bool IsChecked { get; set; } = false;

    }
}
