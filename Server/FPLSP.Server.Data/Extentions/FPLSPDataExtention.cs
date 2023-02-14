
using FPLSP.Server.Domain.Entities.CoresParts;
using Microsoft.EntityFrameworkCore;

namespace FPLSP.Server.Data.Extention;

public static class FPLSPDataExtention
{
    public static void SeedData(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<RoleCP>().HasData(
            new RoleCP() { Id = Guid.Parse("169a0425-7e5a-4057-9748-32f1cf3c1479"), RoleCode = "CV0", RoleName = "Admin", Status = 1, },
            new RoleCP() { Id = Guid.Parse("269a0425-7e5a-4057-9748-32f1cf3c1479"), RoleCode = "CV1", RoleName = "GiangVien", Status = 1, },
            new RoleCP() { Id = Guid.Parse("369a0425-7e5a-4057-9748-32f1cf3c1479"), RoleCode = "CV2", RoleName = "Sinh Vien", Status = 1 }
        );
        modelBuilder.Entity<SpecializedCP>().HasData(
            new SpecializedCP() { Id = Guid.Parse("169a0425-7e5a-4057-9748-32f1cf3c1479"), SpecializedCode = "CN0", SpecializationName = "UDPM", Status = 1, IdSpeciality = Guid.Parse("169a0425-7e5a-4057-9748-32f1cf3c1479"), Image = "OKE.PNG", Level = 0 },
            new SpecializedCP() { Id = Guid.Parse("269a0425-7e5a-4057-9748-32f1cf3c1479"), SpecializedCode = "CN1", SpecializationName = "TKDH", Status = 1, IdSpeciality = Guid.Parse("269a0425-7e5a-4057-9748-32f1cf3c1479"), Image = "OKE.PNG", Level = 0 },
            new SpecializedCP() { Id = Guid.Parse("369a0425-7e5a-4057-9748-32f1cf3c1479"), SpecializedCode = "CN2", SpecializationName = "MOBILE", Status = 1, IdSpeciality = Guid.Parse("369a0425-7e5a-4057-9748-32f1cf3c1479"), Image = "OKE.PNG", Level = 0 }
        );
        modelBuilder.Entity<TrainingFacilitiesCP>().HasData(
            new TrainingFacilitiesCP() { Id = Guid.Parse("169a0425-7e5a-4057-9748-32f1cf3c1479"), TrainingFacilitiesCode = "CS0", TrainingInstitutionName = "Ha Noi", Status = 1, ImageUrl = "IMG57812.PNG" },
            new TrainingFacilitiesCP() { Id = Guid.Parse("269a0425-7e5a-4057-9748-32f1cf3c1479"), TrainingFacilitiesCode = "CS1", TrainingInstitutionName = "Da Nang", Status = 1, ImageUrl = "IMG57812.PNG" },
            new TrainingFacilitiesCP() { Id = Guid.Parse("369a0425-7e5a-4057-9748-32f1cf3c1479"), TrainingFacilitiesCode = "CS2", TrainingInstitutionName = "Can Tho", Status = 1, ImageUrl = "IMG57812.PNG" });
        modelBuilder.Entity<ExamCP>().HasData(
            new ExamCP() { Id = Guid.Parse("169a0425-7e5a-4057-9748-32f1cf3c1479"), ExamCode = "ASS0", ExamName = "FinalUDPM", Status = 1, SubjectId = Guid.Parse("169a0425-7e5a-4057-9748-32f1cf3c1479") },
            new ExamCP() { Id = Guid.Parse("269a0425-7e5a-4057-9748-32f1cf3c1479"), ExamCode = "ASS1", ExamName = "FinalTKDK", Status = 1, SubjectId = Guid.Parse("269a0425-7e5a-4057-9748-32f1cf3c1479") },
            new ExamCP() { Id = Guid.Parse("369a0425-7e5a-4057-9748-32f1cf3c1479"), ExamCode = "ASS2", ExamName = "FinalMOBILE", Status = 1, SubjectId = Guid.Parse("369a0425-7e5a-4057-9748-32f1cf3c1479") }
        );
        modelBuilder.Entity<LecturersCP>().HasData(
        new LecturersCP()
        {
            Id = Guid.Parse("169a0425-7e5a-4057-9748-32f1cf3c1479"),
            LecturersCode = "GV1",
            LecturersName = "Le An Thuyen",
            Gender = true,
            Dob = System.DateTime.Now,
            Email = "leanthuyen.working@gmail.com",
            PhoneNumber = "0129120012",
            Address = "Bac Giang",
            IdentityCard = "9102012",
            IssuedOn = DateTime.Now,
            Ethnic = "Kinh",
            PassWord = "thuyen123",
            ImageUrl = "IMG_3545.PNG",
            YearsOfExperience = 3,
            HomeTown = "Bac Giang",
            Description = "Dep Trai Nhat Viet Nam",
            Status = 0,
            RoleId = Guid.Parse("169a0425-7e5a-4057-9748-32f1cf3c1479"),

            TrainingFacilitiesId = Guid.Parse("169a0425-7e5a-4057-9748-32f1cf3c1479"),
        },
        new LecturersCP()
        {
            Id = Guid.Parse("269a0425-7e5a-4057-9748-32f1cf3c1479"),
            LecturersCode = "GV2",
            LecturersName = "Le An Thuyen",
            Gender = true,
            Dob = System.DateTime.Now,
            Email = "leanthuyen.working@gmail.com",
            PhoneNumber = "0129120012",
            Address = "Bac Giang",
            PassWord = "thuyen123",
            IdentityCard = "9102012",
            IssuedOn = DateTime.Now,
            Ethnic = "Kinh",
            ImageUrl = "IMG_3545.PNG",
            YearsOfExperience = 3,
            HomeTown = "Bac Giang",
            Description = "Dep Trai Nhat Viet Nam",
            Status = 0,
            RoleId = Guid.Parse("269a0425-7e5a-4057-9748-32f1cf3c1479"),

            TrainingFacilitiesId = Guid.Parse("269a0425-7e5a-4057-9748-32f1cf3c1479"),
        },
        new LecturersCP()
        {
            Id = Guid.Parse("369a0425-7e5a-4057-9748-32f1cf3c1479"),
            LecturersCode = "GV3",
            LecturersName = "Le An Thuyen",
            Gender = true,
            Dob = System.DateTime.Now,
            Email = "leanthuyen.working@gmail.com",
            PhoneNumber = "0129120012",
            Address = "Bac Giang",
            IdentityCard = "9102012",
            IssuedOn = DateTime.Now,
            Ethnic = "Kinh",
            PassWord = "thuyen123",
            ImageUrl = "IMG_3545.PNG",
            YearsOfExperience = 3,
            HomeTown = "Bac Giang",
            Description = "Dep Trai Nhat Viet Nam",
            Status = 0,
            RoleId = Guid.Parse("369a0425-7e5a-4057-9748-32f1cf3c1479"),

            TrainingFacilitiesId = Guid.Parse("369a0425-7e5a-4057-9748-32f1cf3c1479"),
        });
        modelBuilder.Entity<ExamLinkCP>().HasData(
            new ExamLinkCP() { Id = Guid.Parse("169a0425-7e5a-4057-9748-32f1cf3c1479"), ExamLinkCode = "ASS2020", Path = "Https://thuyen.com.vn", Status = 1, CreatedDay = DateTime.Now, ExpirationDate = DateTime.Now, ExamId = Guid.Parse("169a0425-7e5a-4057-9748-32f1cf3c1479") },
            new ExamLinkCP() { Id = Guid.Parse("269a0425-7e5a-4057-9748-32f1cf3c1479"), ExamLinkCode = "ASS2020", Path = "Https://thuyen.com.vn", Status = 1, CreatedDay = DateTime.Now, ExpirationDate = DateTime.Now, ExamId = Guid.Parse("269a0425-7e5a-4057-9748-32f1cf3c1479") },
            new ExamLinkCP() { Id = Guid.Parse("369a0425-7e5a-4057-9748-32f1cf3c1479"), ExamLinkCode = "ASS2020", Path = "Https://thuyen.com.vn", Status = 1, CreatedDay = DateTime.Now, ExpirationDate = DateTime.Now, ExamId = Guid.Parse("369a0425-7e5a-4057-9748-32f1cf3c1479") });
        modelBuilder.Entity<SubjectCP>().HasData(
            new SubjectCP() { Id = Guid.Parse("169a0425-7e5a-4057-9748-32f1cf3c1479"), SubjectCode = "SUB101", SubjectName = "CSharp", Status = 1, StartDay = DateTime.Now, EndDay = DateTime.Now, CreatedDay = DateTime.Now, TotalOfSub = 16, Image = "IMG_3545.PNG" },
            new SubjectCP() { Id = Guid.Parse("269a0425-7e5a-4057-9748-32f1cf3c1479"), SubjectCode = "SUB101", SubjectName = "CSharp", Status = 1, StartDay = DateTime.Now, EndDay = DateTime.Now, CreatedDay = DateTime.Now, TotalOfSub = 16, Image = "IMG_3545.PNG" },
            new SubjectCP() { Id = Guid.Parse("369a0425-7e5a-4057-9748-32f1cf3c1479"), SubjectCode = "SUB101", SubjectName = "CSharp", Status = 1, StartDay = DateTime.Now, EndDay = DateTime.Now, CreatedDay = DateTime.Now, TotalOfSub = 16, Image = "IMG_3545.PNG" });
        modelBuilder.Entity<ContentOfExamCP>().HasData(
            new ContentOfExamCP() { Id = Guid.Parse("169a0425-7e5a-4057-9748-32f1cf3c1479"), CoeCode = "ASSDE101", Level = 2, Status = 1, CreatedTime = DateTime.Now, DateStarted = DateTime.Now, EndDate = DateTime.Now, TotalOfQuestions = 50, QuestionType = 2, Content = "Nopeer", ExamId = Guid.Parse("169a0425-7e5a-4057-9748-32f1cf3c1479") },
            new ContentOfExamCP() { Id = Guid.Parse("269a0425-7e5a-4057-9748-32f1cf3c1479"), CoeCode = "ASSDE101", Level = 2, Status = 1, CreatedTime = DateTime.Now, DateStarted = DateTime.Now, EndDate = DateTime.Now, TotalOfQuestions = 50, QuestionType = 2, Content = "Nopeer", ExamId = Guid.Parse("269a0425-7e5a-4057-9748-32f1cf3c1479") },
            new ContentOfExamCP() { Id = Guid.Parse("369a0425-7e5a-4057-9748-32f1cf3c1479"), CoeCode = "ASSDE101", Level = 2, Status = 1, CreatedTime = DateTime.Now, DateStarted = DateTime.Now, EndDate = DateTime.Now, TotalOfQuestions = 50, QuestionType = 2, Content = "Nopeer", ExamId = Guid.Parse("369a0425-7e5a-4057-9748-32f1cf3c1479") }); ;
        modelBuilder.Entity<StudentCP>().HasData(
            new StudentCP()
            {
                Id = Guid.Parse("169a0425-7e5a-4057-9748-32f1cf3c1479"),
                StudentName = "Thuyen Le An",
                StudentCode = "PH127812",
                Gender = true,
                DateOfBirth = DateTime.Now,
                Email = "thuyen@gmail.com",
                PhoneNumber = "912001201",
                Address = "tan hung",
                Password = "aaa",
                IdentityCardNumber = "12912122",
                IssuedOn = DateTime.Now,
                Ethnic = "Kinh",
                ImageUrl = "IMG_122781.PNG",
                FathersName = "jhahahahah",
                MotherName = "Nopeer",
                HomeTown = "Bac Giang",
                Description = "Dep trai",
                Status = 1,
                TrainingFacilitiesId = Guid.Parse("169a0425-7e5a-4057-9748-32f1cf3c1479")

            },
    new StudentCP()
    {
        Id = Guid.Parse("269a0425-7e5a-4057-9748-32f1cf3c1479"),
        StudentName = "Thuyen Le An",
        StudentCode = "PH127812",
        Gender = true,
        DateOfBirth = DateTime.Now,
        Email = "thuyen@gmail.com",
        PhoneNumber = "912001201",
        Address = "tan hung",
        Password = "aaa",
        IdentityCardNumber = "12912122",
        IssuedOn = DateTime.Now,
        Ethnic = "Kinh",
        ImageUrl = "IMG_122781.PNG",
        FathersName = "jhahahahah",
        MotherName = "Nopeer",
        HomeTown = "Bac Giang",
        Description = "Dep trai",
        Status = 1,
        TrainingFacilitiesId = Guid.Parse("269a0425-7e5a-4057-9748-32f1cf3c1479")
    },
     new StudentCP()
     {
         Id = Guid.Parse("369a0425-7e5a-4057-9748-32f1cf3c1479"),
         StudentName = "Thuyen Le An",
         StudentCode = "PH127812",
         Gender = true,
         DateOfBirth = DateTime.Now,
         Email = "thuyen@gmail.com",
         PhoneNumber = "912001201",
         Address = "tan hung",
         Password = "aaa",
         IdentityCardNumber = "12912122",
         IssuedOn = DateTime.Now,
         Ethnic = "Kinh",
         ImageUrl = "IMG_122781.PNG",
         FathersName = "jhahahahah",
         MotherName = "Nopeer",
         HomeTown = "Bac Giang",
         Description = "Dep trai",
         Status = 1,
         TrainingFacilitiesId = Guid.Parse("369a0425-7e5a-4057-9748-32f1cf3c1479")

     });
    }
}