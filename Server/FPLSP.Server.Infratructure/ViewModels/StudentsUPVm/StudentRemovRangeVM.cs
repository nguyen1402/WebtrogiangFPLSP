namespace FPLSP.Server.Infrastructure.ViewModels.StudentsUPVm;

public class StudentRemovRangeVM
{
    public List<Guid> ListGuisId { get; set; }

    public StudentRemovRangeVM()
    {
        ListGuisId = new List<Guid>();
    }
}