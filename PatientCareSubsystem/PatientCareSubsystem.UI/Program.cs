using PatientCareSubsystem.Data.DataAccess;
using PatientCareSubsystem.Data.Repository;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("connectionString"); // This is your connection string to the database.

builder.Services.AddControllersWithViews();
builder.Services.AddTransient<ISqlDataAccess, SqlDataAccess>();
builder.Services.AddTransient<INurseRepository, NurseRepository>();
builder.Services.AddTransient<ISisterNurseRepository, SisterNurseRepository>();
builder.Services.AddTransient<INurseScheduleRepository, NurseScheduleRepository>();
builder.Services.AddTransient<IArticleRepository, ArticleRepository>();

// Session and Cache configuration
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseSession(); // Ensure session is used here
app.UseAuthentication();
app.UseAuthorization();

// Set up the default route
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=LandingPage}/{action=Home}/{id?}");

app.Run();
