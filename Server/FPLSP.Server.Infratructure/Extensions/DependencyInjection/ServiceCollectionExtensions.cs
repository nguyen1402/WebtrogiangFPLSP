using AutoMapper.Extensions.ExpressionMapping;
using FPLSP.Server.Data.FPLSPDbContext;
using FPLSP.Server.Data.Repositories.Implements;
using FPLSP.Server.Data.Repositories.Interfaces;
using FPLSP.Server.Infrastructure.Services.Implements;
using FPLSP.Server.Infrastructure.Services.Implements.FPLExam;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.Services.Interfaces.FPLExam;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Events;
using Serilog.Sinks.MSSqlServer;
using System.Collections.ObjectModel;
using System.Data;
using System.Reflection;

namespace FPLSP.Server.Infrastructure.Extensions.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {

        using (var serviceProvider = services.BuildServiceProvider())
        {
            var executingAssembly = Assembly.GetExecutingAssembly();
            var entryAssembly = Assembly.GetEntryAssembly();
            var configuration = serviceProvider.GetRequiredService<IConfiguration>();
            services.AddAutoMapper(configuration =>
            {
                configuration.AddExpressionMapping();
            }, executingAssembly, entryAssembly);

            services.AddDbContext<ApplicationDbContext>(option => option.UseSqlServer(configuration.GetConnectionString("Data")), ServiceLifetime.Transient);
            //services.AddDistributedCache(configuration.GetSection("DistributedCache").Get<DistributedCacheConfiguration>());

            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            //
            // Nơi AddTransient => Dependency Injection các Service được Define ở Infrastructure

            services.AddScoped<IStudentServices, StudentServices>();

            services.AddScoped<ISubjectServices, SubjectServices>();
            services.AddScoped<ILessonCPServices, LessonCPServices>();
            services.AddTransient<IExamCPServices, ExamCPServices>();
            services.AddTransient<IExamLinkCPServices, ExamLinkCPServices>();
            services.AddTransient<IContentOfExamCPServices, ContentOfExamCPServices>();
            services.AddTransient<IImageCPServices, ImageCPServices>();
            services.AddTransient<IDoQuizService, DoQuizService>();
            services.AddTransient<IClassSubjectServices, ClassSubjectServices>();
            services.AddTransient<ISubmitHomeWorkServices, SubmitHomeWorkServices>();
            services.AddTransient<IResourceLinkUPServices, ResourceLinkUPServices>();
            services.AddTransient<IDashboardService, DashboardService>();
            services.AddTransient<IHomeWorkServices, HomeWorkServices>();
            services.AddTransient<ISubjectTeacherService, SubjectTeacherService>();
            return services;
        }
    }

    public static IConfigurationBuilder AddConfigurationLog(this IConfigurationBuilder builder) // Config json để lưu Log
    {
        builder.SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Production"}.json", optional: true);
        return builder;
    }

    public static ILoggingBuilder AddLoggingBuilder(this ILoggingBuilder log) //Config Logging
    {
        var configuration = new ConfigurationBuilder().AddConfigurationLog().Build();
        var columnOptions = new ColumnOptions
        {
            AdditionalColumns = new Collection<SqlColumn>
            {
                new SqlColumn("UserName", SqlDbType.NVarChar)
            }
        };
        var logger = new LoggerConfiguration()
            .ReadFrom.Configuration(configuration)
            .Enrich.FromLogContext()
            .WriteTo.Console()
            .WriteTo.MSSqlServer(configuration.GetConnectionString("Logging"),
                sinkOptions: new MSSqlServerSinkOptions { TableName = "Log" }
                , null, null, LogEventLevel.Information, null, columnOptions: columnOptions, null, null)
            .CreateLogger();
        log.AddSerilog(logger);
        return log;
    }
}