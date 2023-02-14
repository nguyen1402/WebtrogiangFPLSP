using FPLSP.Server.Data.FPLSPDbContext;
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Infrastructure.Extensions.DependencyInjection;
using FPLSP.Server.Infrastructure.Services.Implements;
using FPLSP.Server.Infrastructure.Services.Implements.Cabin;
using FPLSP.Server.Infrastructure.Services.Implements.CabinProject;
using FPLSP.Server.Infrastructure.Services.Implements.CabinProject.SignalRServices;
using FPLSP.Server.Infrastructure.Services.Implements.FPLExam;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.Services.Interfaces.Cabin;
using FPLSP.Server.Infrastructure.Services.Interfaces.CabinProject;
using FPLSP.Server.Infrastructure.Services.Interfaces.FPLExam;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using Microsoft.IdentityModel.Logging;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;

namespace FPLSP.Server.API;

public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {


        services.AddIdentity<UserSignIn, IdentityRole>().AddEntityFrameworkStores<ApplicationDbContext>()
           .AddEntityFrameworkStores<ApplicationDbContext>();


        services.AddAuthentication(options =>
        {
            options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        })
                      .AddJwtBearer("Bearer", options =>
                      {
                          options.Authority = "https://localhost:7001";

                          options.RequireHttpsMetadata = false;
                          options.TokenValidationParameters = new TokenValidationParameters
                          {
                              ValidateAudience = false
                          };
                      });
        IdentityModelEventSource.ShowPII = true;
        services.AddDbContext<ApplicationDbContext>(op => op.UseSqlServer("Data Source=66.42.55.38;Initial Catalog=FPLSP_Server_Final_Back_DEV;User ID=test;Password=E=lPJeY>-g/9QxzE;MultipleActiveResultSets=true"));
        services.AddApplication();
        //services.AddGrpc();

        services.AddTransient<ITeachingScheduleServices, TeachingScheduleServices>();
        services.AddTransient<IShiftOfCabinServices, ShiftOfCabinServices>();
        services.AddTransient<IBookingCabinServices, BookingCabinServices>();
        services.AddTransient<ISubjectsSpecializedUPServices, SubjectsSpecializedUPServices>();
        services.AddHealthChecks();
        services.AddControllers();
        services.AddDbContext<ApplicationDbContext>();
        services.AddTransient<IRoleUserServices, RoleUserServices>();
        services.AddTransient<INewFeedServices, NewFeedServices>();
        services.AddTransient<IBookMarkClassService, BookMarkClassServies>();
        services.AddTransient<IUseridentityServices, UseridentityServices>();
        services.AddScoped<IAnswerUPServices, AnswerUPServices>();
        services.AddScoped<IQuestionTypeServices, QuestionTypeServices>();
        services.AddScoped<IUseridentityServices, UseridentityServices>();
        services.AddScoped<IStudentSubmitHomeWork, StudentSubmitHomeWork>();
        services.AddScoped<ISubmitHomeWorkServices, SubmitHomeWorkServices>();
        services.AddTransient<IQuizQuesstionQuizUPServices, QuizQuesstionQuizUPServices>();
        services.AddTransient<ITypeOfNewFeedServices, TypeOfNewFeedServices>();
        services.AddTransient<ICopySubjectInClass, CopySubjectInClass>();
        services.AddScoped<IClassServices, ClassServices>();
        services.AddScoped<IQuizzForStudentServices, QuizzForStudentServices>();

        services.AddScoped<IContentOfExamCPServices, ContentOfExamCPServices>();
        services.AddScoped<IExamCPServices, ExamCPServices>();
        services.AddScoped<IExamLinkCPServices, ExamLinkCPServices>();
        services.AddScoped<IImageCPServices, ImageCPServices>();
        services.AddTransient<IVideoHistoryServices, VideoHistoryServices>();
        services.AddScoped<IKindoOfQuestionCPServices, KindoOfQuestionCPServices>();
        services.AddTransient<ILectuterSpecializedUPServices, LectuterSpecializedUPServices>();
        services.AddScoped<ILecturersCPServices, LecturersCPServices>();
        services.AddScoped<ILessonContentUPServices, LessonContentUPServices>();

        services.AddScoped<ILessonContentCPServices, LessonContentCPServices>();
        services.AddScoped<ILessonCPServices, LessonCPServices>();

        services.AddScoped<ILessonUPServices, LessonUPServices>();

        services.AddScoped<IManageStudentUpServices, ManageStudentUpServices>();
        services.AddScoped<IQuizAnswerCPServices, QuizAnswerCPServices>();

        services.AddScoped<IQuizCPServices, QuizCPServices>();
        services.AddScoped<IQuizQuestionCPServices, QuizQuestionCPServices>();

        services.AddScoped<IQuizQuestionUPServices, QuizQuestionUPServices>();
        services.AddScoped<IQuizUPServices, QuizUPServices>();
        services.AddScoped<IReportClassUPServices, ReportClassUPServices>();
        services.AddScoped<IResourceLinkServices, ResourceLinkServices>();

        services.AddScoped<IResourceLinkUPServices, ResourceLinkUPServices>();
        services.AddScoped<ISemesterCPServices, SemesterCPServices>();

        services.AddScoped<ISpecializedCPServices, SpecializedCPServices>();
        services.AddScoped<ISpecializedUPServices, SpecializedUPServices>();
        services.AddScoped<IStudentClassUPServices, StudentClassUPServices>();
        services.AddScoped<IStudentCPServices, StudentCPServices>();
        services.AddScoped<IStudentQuizUPServices, StudentQuizUPServices>();

        services.AddScoped<IStudentServices, StudentServices>();
        services.AddScoped<IStudentUpServices, StudentUpServices>();
        services.AddScoped<ISubjectServices, SubjectServices>();
        services.AddScoped<ISubjectUPServices, SubjectUPServices>();
        services.AddScoped<ITakeAnswerUPServices, TakeAnswerUPServices>();
        services.AddScoped<ITrainingFacilitiesCPServices, TrainingFacilitiesCPServices>();
        services.AddScoped<ITrainingFacilityServices, TrainingFacilityServices>();
        services.AddScoped<IRoleCPServices, RoleCPServices>();
        services.AddScoped<ILectuterSpecializedCPServices, LectuterSpecializedCPServices>();
        services.AddTransient<IQuizQuesstionQuizCPServices, QuizQuesstionQuizCPServices>();
        services.AddTransient<ISubmitHomeworkForStudentServices, SubmitHomeworkForStudentServices>();

        services.AddTransient<IGroupCabinServices, GroupCabinServices>();
        services.AddTransient<ICabinServices, CabinServices>();
        services.AddTransient<IBookingRequestServices, BookingRequestServices>();
        services.AddTransient<IBlockServices, BlockServices>();
        services.AddTransient<ISemesterBlockServices, SemesterBlockServices>();
        services.AddTransient<ISemesterServices, SemesterServices>();
        //FPLExam
        services.AddTransient<IExamFileServices, ExamFileServices>();

        services.AddScoped<IOnlineExamRoomServices, OnlineExamRoomServices>();
        services.AddScoped<ISupervisorExamRoomServices, SupervisorExamRoomServices>();
        services.AddScoped<IExaminationRoomServices, ExaminationRoomServices>();
        services.AddScoped<IExaminationRoomDetailServices, ExaminationRoomDetailServices>();




        services.AddTransient<ApplicationDbContext>();
        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo { Title = "FPLSP.Server.Api", Version = "v1" });
        });
        services.AddCors(options =>
            options.AddPolicy(
                "AllowInternal",
                policy => policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod()
                    .SetIsOriginAllowedToAllowWildcardSubdomains()
            ));
        // Cấu hình để các Localhost mới đầu mã khác có thể chỏ vào và thao tác với các API
        services.AddCors(options =>
        {
            options.AddPolicy("CorsPolicy",
                builder => builder
                    .SetIsOriginAllowed((host) => true)
                    .AllowAnyMethod()
                    .AllowAnyHeader()

                    .AllowCredentials()
                    );
        });
        services.AddMvc();
        services.AddSignalR();
        services.AddControllers();
        services.Configure<ForwardedHeadersOptions>(options =>
        {
            options.ForwardedHeaders =
                ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto;
        });

    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        app.UseSwagger();
        app.UseCors("CorsPolicy");
        app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "FPLSP.Server.Api v1"));
        app.UseHealthChecks("/health");
        app.UseHttpsRedirection();
        app.UseRouting();
        app.UseForwardedHeaders(new ForwardedHeadersOptions
        {
            ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
        });
        app.UseCors("AllowInternal");
        app.UseStaticFiles();
        app.UseStaticFiles(new StaticFileOptions()
        {
            FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), @"StaticFiles")),
            RequestPath = new PathString("/StaticFiles")
        });





        app.UseAuthentication(); //Added

        app.UseAuthorization();


        app.UseEndpoints(endpoints =>
        {
            endpoints.MapHub<NotificationHub>("/notificationhub");
            endpoints.MapHub<SignalRHubBookingServices>("/SignalRCabinHub");

            endpoints.MapControllers();
        });
    }
}