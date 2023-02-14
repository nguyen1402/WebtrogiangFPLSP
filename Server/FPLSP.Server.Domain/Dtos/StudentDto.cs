namespace FPLSP.Server.Domain.Dtos;

public class StudentDto
{
    public string StudentCode { get; set; }
    public string StudentName { get; set; }
    public bool Gender { get; set; }
    public DateTime DateOfBirth { get; set; }
}