using FPLSP.Server.Domain.Dtos.StudentStatisticVM;

namespace FPLSP.Server.Domain.Dtos
{
    public class StudentStatisticsDtos
    {
        public StudentStatisticsDtos()
        {
            Quiz = new List<QuizSummit>();
            Link = new List<LinkSubmitSubject>();
            Baitap = new List<HomeworkVenha>();
        }

        public StudentStatisticsDtos(Guid idStudent, string studentCode, string studentName, bool gender, DateTime dateOfBirth, string email, string phoneNumber, string address, string imageUrl, int countSV, int countBaitap, int countDonSubmit, int countSubmit, List<QuizSummit> quiz, List<LinkSubmitSubject> link, List<HomeworkVenha> baitap)
        {
            IdStudent = idStudent;
            StudentCode = studentCode;
            StudentName = studentName;
            Gender = gender;
            DateOfBirth = dateOfBirth;
            Email = email;
            PhoneNumber = phoneNumber;
            Address = address;
            ImageUrl = imageUrl;
            CountSV = countSV;
            CountBaitap = countBaitap;
            CountDonSubmit = countDonSubmit;
            CountSubmit = countSubmit;
            Quiz = quiz;
            Link = link;
            Baitap = baitap;
        }

        public Guid IdStudent { get; set; }
        public string StudentCode { get; set; }
        public string StudentName { get; set; }
        public bool Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string ImageUrl { get; set; }

        public int CountSV { get; set; }
        public int CountBaitap { get; set; }
        public int CountDonSubmit { get; set; } = 0;
        public int CountSubmit { get; set; } = 0;
        public double Diemtrungbinh { get; set; } = 0;
        public List<QuizSummit> Quiz { get; set; }
        public List<LinkSubmitSubject> Link { get; set; }
        public List<HomeworkVenha> Baitap { get; set; }
        public List<Guid?> Listidlesson { get; set; }
        public List<Guid?> ListidQuiz { get; set; }
    }
}
