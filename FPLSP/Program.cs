using AutoMapper.Extensions.ExpressionMapping;
using Blazored.LocalStorage;
using Blazored.Toast;
using CurrieTechnologies.Razor.SweetAlert2;
using FPLSP.Data;
using FPLSP.Data.ClassRoomsApiClient;
using FPLSP.Data.FPLExam;
using FPLSP.Data.ManageStudents;
using FPLSP.Data.Securities;
using FPLSP.Data.StudentsApiClient;
using FPLSP.Repositories;
using FPLSP.Repositories.Interfaces;
using FPLSP.Repositories.Interfaces.CabinProject;
using FPLSP.Repositories.Interfaces.FPLExam;
using FPLSP.Repositories.Services;
using FPLSP.Repositories.Services.BookingRequest;
using FPLSP.Repositories.Services.Cabin;
using FPLSP.Repositories.Services.CabinProject;
using FPLSP.Repositories.Services.FPLExam;
using FPLSP.Server.Data.FPLSPDbContext;
using FPLSP.Server.Data.Repositories.Implements;
using FPLSP.Server.Data.Repositories.Interfaces;
using FPLSP.Server.Domain.Entities.CoresParts;
using FPLSP.Server.Domain.Entities.UserParts;
using FPLSP.Server.Infrastructure.Services.Implements;
using FPLSP.Server.Infrastructure.Services.Implements.CabinProject.SignalRServices;
using FPLSP.Server.Infrastructure.ViewModels;
using IdentityServer4.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server.Circuits;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using MudBlazor.Services;
using System.IdentityModel.Tokens.Jwt;
using System.Reflection;
using System.Text.Json.Serialization;
var builder = WebApplication.CreateBuilder(args);
var executingAssembly = Assembly.GetExecutingAssembly();
var entryAssembly = Assembly.GetEntryAssembly();
builder.Services.AddRazorPages();
builder.Services.AddDbContextFactory<ApplicationDbContext>();
builder.Services.AddOptions();
builder.Services.AddAuthorization();
JwtSecurityTokenHandler.DefaultInboundClaimTypeMap.Clear();
builder.Services.AddServerSideBlazor();
builder.Services.AddControllersWithViews();
builder.Services.AddApiAuthorization();
builder.Services.AddSignalR();
builder.Services.AddAntDesign();
builder.Services.AddOptions();
builder.Services.AddAuthorizationCore();

builder.Services.Configure<ForwardedHeadersOptions>(options =>
{
    options.KnownNetworks.Clear();
    options.KnownProxies.Clear();
});




builder.Services.Configure<SecurityStampValidatorOptions>(options =>
{

    options.ValidationInterval = TimeSpan.FromSeconds(5);
});

builder.Services.Configure<IdentityServerSettings>(builder.Configuration.GetSection("IdentityServerSettings"));


builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();



builder.Services.AddControllers()
        .AddJsonOptions(o => o.JsonSerializerOptions
            .ReferenceHandler = ReferenceHandler.Preserve);


builder.Services.AddIdentity<UserSignIn, IdentityRole>().AddRoles<IdentityRole>().AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddIdentityServer(options =>
{
    options.Events.RaiseErrorEvents = true;
    options.Events.RaiseFailureEvents = true;
    options.Events.RaiseInformationEvents = true;
    options.Events.RaiseSuccessEvents = true;
})
   .AddConfigurationStore(options =>
   {
       options.ConfigureDbContext = b =>
       b.UseSqlServer("Data Source=66.42.55.38;Initial Catalog=FPLSP_Server_Final_Back_DEV;User ID=test;Password=E=lPJeY>-g/9QxzE;MultipleActiveResultSets=true");
   })
    .AddOperationalStore(options =>
    {
        options.ConfigureDbContext = b =>
        b.UseSqlServer("Data Source=66.42.55.38;Initial Catalog=FPLSP_Server_Final_Back_DEV;User ID=test;Password=E=lPJeY>-g/9QxzE;MultipleActiveResultSets=true");
    })
    .AddDeveloperSigningCredential();
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
.AddCookie();

//    .AddOpenIdConnect(OpenIdConnectDefaults.AuthenticationScheme,

//    options =>
//    {
//        ////var GoogleConfig = builder.Configuration.GetSection("Authentication:Google");
//        //options.SignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;

//        //options.Authority = "https://accounts.google.com/o/oauth2/auth";
//        //options.ClientId = "208792247961-e66lg5vhu7m908ko9sgd2dktlrnrs07b.apps.googleusercontent.com";
//        //options.ClientSecret = "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";
//        //options.ResponseType = "id_token token";
//        //options.CallbackPath = "/checkin-google";
//        //options.SaveTokens = true;
//        //options.ClaimActions.DeleteClaim("sid");
//        //options.ClaimActions.DeleteClaim("idp");
//        //options.Scope.Add("profile");
//        //options.Scope.Add("email");
//        var GoogleConfig = builder.Configuration.GetSection("Authentication:Google");
//        options.SignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;

//        options.Authority = "https://accounts.google.com/";
//        options.ClientId = GoogleConfig["ClientId"];
//        options.ClientSecret = GoogleConfig["ClientSecret"];
//        options.ResponseType = "id_token token";
//        options.CallbackPath = "/checkin-google";
//        options.SaveTokens = true;
//        options.ClaimActions.DeleteClaim("sid");
//        options.ClaimActions.DeleteClaim("idp");
//        options.Scope.Add("profile");
//        options.Scope.Add("email");

//        options.ClaimActions.MapJsonKey("urn:google:picture", "picture", "url");

//        options.ClaimActions.MapJsonKey("urn:google:locale", "locale", "string");
//        options.GetClaimsFromUserInfoEndpoint = true;





//        options.Events = new OpenIdConnectEvents()
//        {

//            // handle the logout redirection 
//            OnRedirectToIdentityProviderForSignOut = context =>
//            {
//                var logoutUri = "/logout";
//                context.Response.Redirect(logoutUri);
//                context.HandleResponse();

//                return Task.CompletedTask;
//            }
//        };

//    }
//);
builder.Services.AddAuthentication(options =>
{
    options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
    options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
    options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;

})
.AddGoogle(options =>
{

    var GoogleConfig = builder.Configuration.GetSection("Authentication:Google");
    options.SignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
    options.ClientId = GoogleConfig["ClientId"];
    options.ClientSecret = GoogleConfig["ClientSecret"];
    options.SaveTokens = true;
    options.CallbackPath = "/checkin-google";
    options.Scope.Add("profile");
    options.Scope.Add("email");
    options.Scope.Add("openid");

    options.ClaimActions.MapUniqueJsonKey("sub", "email");
    options.ClaimActions.MapUniqueJsonKey("role", "role");
    options.ClaimActions.MapJsonKey("urn:google:picture", "picture", "url");
    options.ClaimActions.MapJsonKey("urn:google:locale", "locale", "string");
    options.SaveTokens = true;
    options.Events.OnCreatingTicket = ctx =>
    {
        List<AuthenticationToken> tokens = ctx.Properties.GetTokens().ToList();

        tokens.Add(new AuthenticationToken()
        {
            Name = "TicketCreated",
            Value = DateTime.UtcNow.ToString()
        });

        ctx.Properties.StoreTokens(tokens);

        return Task.CompletedTask;
    };
});
builder.Services.ConfigureApplicationCookie(options =>
{
    options.AccessDeniedPath = "/accessdineds";
});
builder.Services.AddAuthorization(options =>
{
    //thêm chính sách cho ai có thể CRUD
    options.AddPolicy("CanCRUD", policy =>
    {
        policy.RequireAuthenticatedUser();
        policy.RequireClaim("IsUserCanCRUD", "true");
    });
    //chính sách ai có thể đăng nhập vào màn nào
    options.AddPolicy("FPLSP", policy =>
    {
        policy.RequireAuthenticatedUser();
        policy.RequireClaim("CanViewFPLSPProject", "true");
    });
    options.AddPolicy("CabinProject", policy =>
    {
        policy.RequireAuthenticatedUser();
        policy.RequireClaim("CanViewCabinProject", "true");
    });
});

void CheckSameSite(HttpContext httpContext, CookieOptions options)
{
    if (options.SameSite == Microsoft.AspNetCore.Http.SameSiteMode.None)
    {
        var userAgent = httpContext.Request.Headers["User-Agent"].ToString();

        if (true)
        {
            options.SameSite = Microsoft.AspNetCore.Http.SameSiteMode.Unspecified;
        }
    }
}

builder.Services.Configure<CookiePolicyOptions>(options =>
{
    options.MinimumSameSitePolicy = Microsoft.AspNetCore.Http.SameSiteMode.Unspecified;
    options.OnAppendCookie = cookieContext =>
        CheckSameSite(cookieContext.Context, cookieContext.CookieOptions);
    options.OnDeleteCookie = cookieContext =>
        CheckSameSite(cookieContext.Context, cookieContext.CookieOptions);
});
builder.Services.AddAutoMapper(configuration =>
{
    configuration.AddExpressionMapping();
}, executingAssembly, entryAssembly);
builder.Services.AddBlazoredToast();

builder.Services.AddBlazoredLocalStorage();
builder.Services.AddMudServices();
builder.Services.AddApiAuthorization();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
}
);

builder.Services.AddControllers().AddNewtonsoftJson();
builder.Services.AddHttpContextAccessor();
builder.Services.AddScoped<HttpContextAccessor>();
builder.Services.AddHttpClient();
builder.Services.AddScoped<HttpClient>();
builder.Services.AddSingleton<CryptoServices>();
builder.Services.AddTransient<IProfileService, ProfileService>();
builder.Services.AddScoped<ITokenServices, TokenSevices>();
builder.Services.AddScoped<ITokenServices, TokenSevices>();
builder.Services.AddScoped<ProtectedSessionStorage>();
builder.Services.AddSingleton<CustomAuthStateProvider>();
builder.Services.AddScoped<CustomClaimsForUser>();
builder.Services.AddTransient<INewFeedRepo, NewFeedRepo>();
builder.Services.AddSingleton<HashParameterValues>();

builder.Services.AddTransient<IEmailSender, SendMailService>();
builder.Services.AddTransient<ISenderNotification, SenderNotification>();
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddSweetAlert2();
builder.Services.AddTransient<IClassSubjectApiClient, ClassSubjectApiClient>();
builder.Services.AddScoped<IUserClaimsPrincipalFactory<UserSignIn>, UserClaimsPrincipalFactory<UserSignIn, IdentityRole>>();
builder.Services.AddTransient<IProfileService, ProfileService>();
builder.Services.AddTransient<IBookMarkClassRepo, BookMarkClassRepo>();
builder.Services.AddTransient<IAnswerUPRepo, AnswerUPRepo>();
builder.Services.AddTransient<IClassRoomApiClient, ClassRoomApiClient>();
builder.Services.AddTransient<IContentOfExamCPRepo, ContentOfExamCPRepo>();
builder.Services.AddTransient<IExamCPServicesRepo, ExamCPServicesRepo>();
builder.Services.AddTransient<IExamLinkCPRepo, ExamLinkCPRepo>();
builder.Services.AddTransient<IQuizQuesstionQuizCPClient, QuizQuesstionQuizCPClient>();
builder.Services.AddTransient<IImageCPRepo, ImageCPRepo>();
builder.Services.AddTransient<IKindoOfQuestionCPRepo, KindoOfQuestionCPRepo>();
builder.Services.AddTransient<ILecturersCPRepo, LecturersCPRepo>();
builder.Services.AddTransient<ISubjectsSpecializedUPRepo, SubjectsSpecializedUPRepo>();
builder.Services.AddTransient<ILessonContentCPRepo, LessonContentCPRepo>();
builder.Services.AddTransient<ILessonContentUPRepo, LessonContentUPRepo>();
builder.Services.AddTransient<ILessonCPRepo, LessonCPRepo>();
builder.Services.AddTransient<ILessonUPRepo, LessonUPRepo>();
builder.Services.AddTransient<IRoleCPRepo, RoleCPRepo>();
builder.Services.AddTransient<ICopySubjectInClassRepo, CopySubjectInClassRepo>();
builder.Services.AddTransient<IManageStudentApiClient, ManageStudentApiClient>();
builder.Services.AddTransient<IQuizQuesstionQuizUPClient, QuizQuesstionQuizUPClient>();
builder.Services.AddTransient<IQuizAnswerCPRepo, QuizAnswerCPRepo>();
builder.Services.AddTransient<IQuizCPRepo, QuizCPRepo>();
builder.Services.AddTransient<IQuizQuestionCPRepo, QuizQuestionCPRepo>();
builder.Services.AddTransient<IQuizQuestionUPRepo, QuizQuestionUPRepo>();
builder.Services.AddTransient<ITypeOfNewFeedRepo, TypeOfNewFeedRepo>();
builder.Services.AddTransient<IQuizUPRepo, QuizUPRepo>();
builder.Services.AddTransient<IReportClassUPRepo, ReportClassUPRepo>();
builder.Services.AddTransient<IResourceLinkRepo, ResourceLinkRepocs>();
builder.Services.AddTransient<IResourceLinkUPRepo, ResourceLinkUPRepo>();
builder.Services.AddTransient<ISemesterCPRepo, SemesterCPRepo>();
builder.Services.AddTransient<ISpecializedCPRepo, SpecializedCPRepo>();
builder.Services.AddTransient<IRepository<StudentUP>, Repository<StudentUP>>();
builder.Services.AddTransient<IStudentClassUPRepo, StudentClassUPRepo>();
builder.Services.AddTransient<IStudentCPApiClient, StudentCPApiClient>();
builder.Services.AddTransient<IStudentQuizUPRepo, StudentQuizUPRepo>();
builder.Services.AddTransient<IStudentsApiClient, StudentsApiClient>();
builder.Services.AddTransient<IStudentUPRepo, StudentUPRepo>();
builder.Services.AddTransient<ISubjectClient, SubjectClient>();
builder.Services.AddTransient<ISubjectUPRepo, SubjectUPRepo>();
builder.Services.AddTransient<ITakeAnswerUPRepo, TakeAnswerUPRepo>();
builder.Services.AddTransient<ITaskRepositories<ClassUPViewModel>, TaskClassServices>();
builder.Services.AddTransient<ITrainingFacilitiesCPRepo, TrainingFacilitiesCPRepo>();
builder.Services.AddTransient<ISpecializedUPRepo, SpecializedUPRepo>();
builder.Services.AddTransient<IDoQuizRepository, DoQuizRepository>();
builder.Services.AddTransient<ILectuterSpecializedCPCilents, LectuterSpecializedCPCilents>();
builder.Services.AddTransient<IRoleUserIdentityRepo, RoleUserIdentityRepo>();
builder.Services.AddTransient<IUserIdentityRepo, UserIdentityRepo>();
builder.Services.AddTransient<IVideoHistoryRepo, VideoHistoryRepo>();
builder.Services.AddTransient<ISubmitHomeworkForStudentRepo, SubmitHomeworkForStudentRepo>();
builder.Services.AddTransient<IHomeWorkClient, HomeWorkClient>();
builder.Services.AddTransient<ISubmitHomeWorkApiClient, SubmitHomeWorkApiClient>();
builder.Services.AddTransient<ICopySubjectInClassRepo, CopySubjectInClassRepo>();
builder.Services.AddTransient<IHomeWorkClient, HomeWorkClient>();
builder.Services.AddTransient<IDashboardClient, DashboardClient>();
builder.Services.AddTransient<IGroupCabinRepo, GroupCabinRepo>();
builder.Services.AddTransient<ICabinRepo, CabinRepo>();
builder.Services.AddTransient<IBookingRequestRepo, BookingRequestRepo>();
builder.Services.AddTransient<IBookingCabinApiClient, BookingCabinApiClient>();
builder.Services.AddTransient<ITeachingScheduleApiClient, TeachingScheduleApiClient>();
builder.Services.AddTransient<IShiftOfCabinApiClient, ShiftCabinApiClient>();
builder.Services.AddTransient<IBlockRepo, BlockRepo>();
builder.Services.AddTransient<ISemesterBlockRepo, SemesterBlockRepo>();
builder.Services.AddTransient<ISemesterRepo, SemesterRepo>();

//FPLExam
builder.Services.AddTransient<IExamFileRepo, ExamFileRepo>();
builder.Services.AddTransient<IExaminationRoomDetailRepo, ExaminationRoomDetailRepo>();
builder.Services.AddTransient<IExaminationRoomRepo, ExaminationRoomRepo>();
builder.Services.AddTransient<IOnlineExamRoomRepo, OnlineExamRoomRepo>();
builder.Services.AddTransient<ISupervisorExamRoomRepocs, SupervisorExamRoomRepocs>();
builder.Services.AddScoped<CircuitHandler, CircuitHandlerService>();
builder.Services.AddSingleton<IUserInRoomRepo, UserInRoomRepo>();
builder.Services.AddTransient<ISubjectTeacherRepo, SubjectTeacherRepo>();
builder.Services.AddSingleton<StateDelegateAcceptTojoin>();
builder.Services.AddProtectedBrowserStorage();
builder.Services.AddScoped<AuthenticationStateProvider, RevalidatingIdentityAuthenticationStateProvider<UserSignIn>>();
builder.Services.AddDataProtection();

//background services
////builder.Services.AddHostedService<BackGroundExamOnlineServices>();
builder.Services.AddHttpClient("examapi", client =>
{
    client.BaseAddress = new Uri(builder.Configuration["BackEndAPIURL"]);
});


builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.Configuration["BackEndAPIURL"]) });
builder.Services.AddControllersWithViews();



builder.WebHost.UseWebRoot("wwwroot");

builder.WebHost.UseStaticWebAssets();
var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");

    app.UseHsts();
}
app.UseForwardedHeaders(new ForwardedHeadersOptions()
{
    ForwardedHeaders = Microsoft.AspNetCore.HttpOverrides.ForwardedHeaders.XForwardedFor | Microsoft.AspNetCore.HttpOverrides.ForwardedHeaders.XForwardedProto
});


app.UseSession();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseCookiePolicy();
app.UseIdentityServer();
app.UseAuthentication();
app.UseAuthorization();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");
app.UseEndpoints(enpoint =>
{
    enpoint.MapHub<SignalRHubBookingServices>("/SignalRCabinHub");
    enpoint.MapHub<NotificationHub>("/notificationhub");

    enpoint.MapControllers();
    enpoint.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");

    enpoint.MapDefaultControllerRoute();
});
app.Run();