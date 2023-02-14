namespace FPLSP.Repositories.Interfaces
{
    public interface ICopySubjectInClassRepo
    {
        Task<bool> Copy(Guid idsubject);
    }
}
