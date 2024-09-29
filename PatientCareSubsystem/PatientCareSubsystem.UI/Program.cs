using PatientCareSubsystem.Data.DataAccess;
using PatientCareSubsystem.Data.Repository;


var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("connectionString"); //This Is My connection string to my database.

builder.Services.AddControllersWithViews();
builder.Services.AddTransient<ISqlDataAccess, SqlDataAccess>();
builder.Services.AddTransient<INurseRepository, NurseRepository>();
builder.Services.AddTransient<ISisterNurseRepository, SisterNurseRepository>();
builder.Services.AddTransient<INurseScheduleRepository, NurseScheduleRepository>();
builder.Services.AddTransient<IArticleRepository, ArticleRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=LandingPage}/{action=Home}/{id?}");


app.Run();
