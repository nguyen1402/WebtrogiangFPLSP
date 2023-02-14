using FPLSP.Server.Infrastructure.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;


namespace FPLSP.Server.API
{
    public class Program
    {
        public static IConfiguration Configuration { get; } = new ConfigurationBuilder().AddConfigurationLog().Build();

        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            string connectionString = Configuration.GetConnectionString("Logging");

            //Log.Logger = new LoggerConfiguration()
            //    .Enrich.FromLogContext()
            //    .WriteTo.Console()
            //    .WriteTo.File("Logs/Example.txt",
            //        outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj}{NewLine}{Exception}")
            //    .WriteTo.MSSqlServer(
            //        connectionString,
            //        sinkOptions: new SinkOptions()
            //        {
            //            TableName = "Logs",
            //            SchemaName = "dbo",
            //            AutoCreateSqlTable = true
            //        })
            //    .CreateLogger();

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();


                });/*.UseSerilog();*/
    }
}