namespace FPLSP.Server.Data.FPLSPDbContext;

using FPLSP.Server.Data.Configurations.CabinConfigs;
using FPLSP.Server.Data.Configurations.CoreParts;
using FPLSP.Server.Data.Configurations.FPLExamConfigs;
using FPLSP.Server.Data.Configurations.UserParts;
using FPLSP.Server.Data.Extention;
using FPLSP.Server.Domain.Entities.Cabin;
using FPLSP.Server.Domain.Entities.CabinProject;
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Domain.Entities.FPLExam;
using FPLSP.Server.Domain.Entities.UserParts;
using FPLSP.Server.Domain.Entities.UsesParts;
using Microsoft.AspNetCore.Http;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
public partial class ApplicationDbContext : IdentityDbContext<UserSignIn>
{
    private readonly IHttpContextAccessor _httpContextAccessor;

    public ApplicationDbContext()
    {

    }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options,
            IHttpContextAccessor httpContextAccessor) : base(options)
    {
        _httpContextAccessor = httpContextAccessor;
        //this.ChangeTracker.LazyLoadingEnabled = false;
    }

    #region Core Parts
    public virtual DbSet<ImageCP> ImageCPs { get; set; }
    public virtual DbSet<LessonCP> LessonCPs { get; set; }
    public virtual DbSet<RoleCP> RoleCPs { get; set; }
    public virtual DbSet<SpecializedCP> SpecializedCPs { get; set; }
    public virtual DbSet<TrainingFacilitiesCP> TrainingFacilitiesCPs { get; set; }
    public virtual DbSet<ExamCP> ExamCPs { get; set; }
    public virtual DbSet<LecturersCP> Lecturers { get; set; }

    public virtual DbSet<ResourceLink> ResourceLinks { get; set; }
    public virtual DbSet<ExamLinkCP> ExamLinkCPs { get; set; }
    public virtual DbSet<KindoOfQuestionCP> KindoOfQuestionCPs { get; set; }
    public virtual DbSet<SubjectCP> SubjectCPs { get; set; }
    public virtual DbSet<LessonContentCP> LessonContentCPs { get; set; }
    public virtual DbSet<ContentOfExamCP> ContentOfExamCPs { get; set; }
    public virtual DbSet<QuizCP> QuizCps { get; set; }
    public virtual DbSet<QuizQuestionCP> QuizQuestionCps { get; set; }
    public virtual DbSet<QuizAnswerCP> QuizAnswerCps { get; set; }
    public virtual DbSet<StudentCP> StudentCPs { get; set; }

    public virtual DbSet<QuizQuestionQuizCP> QuizQuestionQuizCPs { get; set; }
    public virtual DbSet<LectuterSpecializedCP> LectuterSpecializedCPs { get; set; }
    public virtual DbSet<QuizAnswerCP> QuizAnswerCPs { get; set; }
    public virtual DbSet<SpecializedSubjectCP> SpecializedSubjectCPs { get; set; }
    public virtual DbSet<HomeWork> HomeWorks { get; set; }
    #endregion
    //
    #region User part
    public virtual DbSet<AnswerUP> AnswerUPs { get; set; }
    public virtual DbSet<UserSignIn> UserSignIns { get; set; }
    public virtual DbSet<ClassUp> ClassUps { get; set; }
    public virtual DbSet<LessonContentUP> LessonContentUPs { get; set; }
    public virtual DbSet<LessonUP> LessonUPs { get; set; }
    public virtual DbSet<QuestionType> QuestionTypes { get; set; }
    public virtual DbSet<QuizQuestionUP> QuizQuestionUPs { get; set; }
    public virtual DbSet<QuizUP> QuizUPs { get; set; }
    public virtual DbSet<ReportClassUP> ReportClassUPs { get; set; }
    public virtual DbSet<ResourceLinkUP> ResourceLinkUPs { get; set; }
    public virtual DbSet<SpecializedUP> SpecializedUPs { get; set; }
    public virtual DbSet<StudentQuizUP> StudentQuizUPs { get; set; }
    public virtual DbSet<StudentUP> StudentUPs { get; set; }
    public virtual DbSet<SubjectUP> SubjectUPs { get; set; }
    public virtual DbSet<TakeAnswerUP> TakeAnswerUPs { get; set; }
    public virtual DbSet<StudentClassUP> StudentClassUPs { get; set; }
    public virtual DbSet<SpecializedSubjectUP> SpecializedSubjectUPs { get; set; }
    public virtual DbSet<QuizQuestionQuizUP> QuizQuestionQuizUPs { get; set; }
    public virtual DbSet<LectuterSpecializedUP> LectuterSpecializedUPs { get; set; }
    public virtual DbSet<SubjectClassUP> SubjectClassUPs { get; set; }
    public virtual DbSet<VideoHistory> VideoHistories { get; set; }

    public virtual DbSet<BookMarkClass> BookMarkClasses { get; set; }
    public virtual DbSet<SubmitHomeWork> SubmitHomeWorks { get; set; }
    public virtual DbSet<News> News { get; set; }
    public virtual DbSet<TypeOfNewFeed> TypeOfNewFeeds { get; set; }

    #endregion
    // cabin và feedback
    public virtual DbSet<BookingCabin> BookingCabins { get; set; }
    public virtual DbSet<Cabin> Cabins { get; set; }
    public virtual DbSet<FeedBack> FeedBacks { get; set; }
    public virtual DbSet<Shift> Shifts { get; set; }
    public virtual DbSet<TeachingSchedule> TeachingSchedules { get; set; }
    public virtual DbSet<Block> Blocks { get; set; }
    public virtual DbSet<BookingRequest> BookingRequests { get; set; }
    public virtual DbSet<GroupCabin> GroupCabins { get; set; }
    public virtual DbSet<SemesterBlock> SemesterBlocks { get; set; }
    public virtual DbSet<Semester> Semesters { get; set; }
    //thay tien
    public virtual DbSet<FeedBackOutSide> FeedBackOutSides { get; set; }
    //fplexam
    public virtual DbSet<ExaminationRoomDetail> ExaminationRoomDetail { get; set; }
    public virtual DbSet<ExaminationRoom> ExaminationRooms { get; set; }

    public virtual DbSet<ExamStorage> ExamStorages { get; set; }

    public virtual DbSet<OnlineExamRoom> OnlineExamRooms { get; set; }
    public virtual DbSet<SupervisorExamRoom> SupervisorExamRooms { get; set; }
    public virtual DbSet<SubjectTeacher> SubjectTeachers { get; set; }









    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        //optionsBuilder.LogTo(Console.WriteLine);


        if (!optionsBuilder.IsConfigured)
        {


            optionsBuilder.UseSqlServer("Data Source=66.42.55.38;Initial Catalog=FPLSP_Server_Final_Back_DEV;User ID=test;Password=E=lPJeY>-g/9QxzE;MultipleActiveResultSets=true");

        }



    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        //core


        modelBuilder.ApplyConfiguration(new ContentOfExamCPConfiguration());
        modelBuilder.ApplyConfiguration(new ContentOfLessonCPConfiguration());
        modelBuilder.ApplyConfiguration(new ExamCPConfiguration());
        modelBuilder.ApplyConfiguration(new ExamLinkCPConfiguration());
        modelBuilder.ApplyConfiguration(new ImageCPConfiguration());
        modelBuilder.ApplyConfiguration(new LectureCPConfiguration());
        modelBuilder.ApplyConfiguration(new LessonCPConfiguration());
        modelBuilder.ApplyConfiguration(new KindoOfQuestionCPConfiguration());
        modelBuilder.ApplyConfiguration(new ResourceLinkCPConfiguration());
        modelBuilder.ApplyConfiguration(new RoleCPConfiguration());
        modelBuilder.ApplyConfiguration(new SpecializedSubjectCPConfiguration());

        modelBuilder.ApplyConfiguration(new SpecializedCPConfiguration());
        modelBuilder.ApplyConfiguration(new StudentCPConfiguration());
        modelBuilder.ApplyConfiguration(new SubjectCPConfiguration());
        modelBuilder.ApplyConfiguration(new TrainingFacilitieCPConfiguration());
        modelBuilder.ApplyConfiguration(new QuizCPConfiguration());
        modelBuilder.ApplyConfiguration(new StudentCPConfiguration());

        modelBuilder.ApplyConfiguration(new QuizQuestionQuizCPConfiguration());
        modelBuilder.ApplyConfiguration(new LectuterSpecializedCPConfiguration());

        modelBuilder.ApplyConfiguration(new QuizQuesTionCPConfiguration());
        modelBuilder.ApplyConfiguration(new QuizAnswerCPConfiguration());
        //
        modelBuilder.ApplyConfiguration(new AnswerUPConfigarution());
        modelBuilder.ApplyConfiguration(new ClassUPConfigarution());
        modelBuilder.ApplyConfiguration(new LessonContentUPConfigarution());
        modelBuilder.ApplyConfiguration(new LessonUPConfigarution());
        modelBuilder.ApplyConfiguration(new QuestionTypeConfigarution());
        modelBuilder.ApplyConfiguration(new QuizQuestionsUPConfigarution());
        modelBuilder.ApplyConfiguration(new QuizUPConfigarution());
        modelBuilder.ApplyConfiguration(new ReportClassUPConfigarution());

        modelBuilder.ApplyConfiguration(new ResourceLinkConfigarution());
        modelBuilder.ApplyConfiguration(new SpecializedUPConfigarution());
        modelBuilder.ApplyConfiguration(new StudentQuizUPConfigarution());
        modelBuilder.ApplyConfiguration(new StudentUPConfigarution());
        modelBuilder.ApplyConfiguration(new SubjectUPConfigarution());
        modelBuilder.ApplyConfiguration(new TakeAnswerUPConfigarution());
        modelBuilder.ApplyConfiguration(new StudentClassUPConfiguration());
        modelBuilder.ApplyConfiguration(new SpecializedSubjectUPConfiguration());
        modelBuilder.ApplyConfiguration(new QuizQuestionQuizUPConfiguration());
        modelBuilder.ApplyConfiguration(new LectuterSpecializedUPConfiguration());
        modelBuilder.ApplyConfiguration(new SubjectClassConfiguration());
        modelBuilder.ApplyConfiguration(new VideoHistoryConfiguration());
        modelBuilder.ApplyConfiguration(new BookMarkConfiguration());
        modelBuilder.ApplyConfiguration(new SubmitHomeWorkConfiguration());
        modelBuilder.ApplyConfiguration(new NewsConfiguration());
        modelBuilder.ApplyConfiguration(new UserSiginConfiguration());
        modelBuilder.ApplyConfiguration(new TypeOfNewFeedConfiguration());
        modelBuilder.ApplyConfiguration(new HomeWorkConfiguration());
        //cabin
        modelBuilder.ApplyConfiguration(new BookingCabinConfiguration());
        modelBuilder.ApplyConfiguration(new CabinConfiguration());
        modelBuilder.ApplyConfiguration(new FeedBackConfiguration());
        modelBuilder.ApplyConfiguration(new ShiftConfiguration());
        modelBuilder.ApplyConfiguration(new TeachingScheduleConfiguration());
        modelBuilder.ApplyConfiguration(new FeedbackOutsideConfiguration());
        modelBuilder.ApplyConfiguration(new BlockConfiguration());
        modelBuilder.ApplyConfiguration(new BookingRequestConfiguration());
        modelBuilder.ApplyConfiguration(new GroupCabinConfiguration());
        modelBuilder.ApplyConfiguration(new SemesterBlockConfiguration());
        modelBuilder.ApplyConfiguration(new SemesterConfiguration());
        //fplexam
        modelBuilder.ApplyConfiguration(new ExaminationRoomConfiguration());
        modelBuilder.ApplyConfiguration(new ExaminationRoomDetailConfiguration());


        modelBuilder.ApplyConfiguration(new ExamStorageConfiguration());
        modelBuilder.ApplyConfiguration(new OnlineExamRoomConfiguration());
        modelBuilder.ApplyConfiguration(new SupervisorExamRoomConfiguration());
        modelBuilder.ApplyConfiguration(new SubjectTeacherConfiguration());

        modelBuilder.SeedData();
    }

}
