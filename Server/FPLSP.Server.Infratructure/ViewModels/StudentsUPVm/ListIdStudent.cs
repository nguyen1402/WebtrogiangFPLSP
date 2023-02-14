namespace FPLSP.Server.Infrastructure.ViewModels.StudentsUPVm
{
    public class ListIdStudent
    {
        public ListIdStudent()
        {
            idstudents = new List<Guid?>();
        }

        public List<Guid?> idstudents { get; set; }
    }
}
