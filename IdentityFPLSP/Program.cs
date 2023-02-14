using FPLSP.Server.Domain.Entities.CoresParts;
using IdentityFPLSP.Context;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

//var seed = args.Contains("/ConfigSeed");
//if (seed)
//{
//    args = args.Except(new[] { "/ConfigSeed" }).ToArray();
//}
var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
var assembly = typeof(Program).Assembly.GetName().Name;
var IdentityConn = builder.Configuration.GetConnectionString("Data");



//ConfigSeed.EnsureSeedData(IdentityConn);

builder.Services.AddDbContext<IdentityDbContext>(options =>
    options.UseSqlServer(IdentityConn,
        b => b.MigrationsAssembly(assembly)));
builder.Services.AddIdentity<UserSignIn, IdentityRole>()
    .AddEntityFrameworkStores<IdentityDbContext>();

builder.Services.AddIdentityServer(options =>
{
    options.Events.RaiseErrorEvents = true;
    options.Events.RaiseFailureEvents = true;
    options.Events.RaiseInformationEvents = true;
    options.Events.RaiseSuccessEvents = true;
})
    .AddAspNetIdentity<UserSignIn>()
    .AddConfigurationStore(options =>
    {
        options.ConfigureDbContext = b =>
        b.UseSqlServer(IdentityConn, opt => opt.MigrationsAssembly(assembly));
    })
    .AddOperationalStore(options =>
    {
        options.ConfigureDbContext = b =>
        b.UseSqlServer(IdentityConn, opt => opt.MigrationsAssembly(assembly));
    })
    .AddDeveloperSigningCredential();

builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy1",
        builder => builder
            .SetIsOriginAllowed((host) => true)
            .AllowAnyMethod()
            .AllowAnyHeader()

            .AllowCredentials()
            );
});
builder.Services.AddControllersWithViews();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("CorsPolicy1");
app.UseHttpsRedirection();
app.UseIdentityServer();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
