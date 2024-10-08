using ProjectPractice.Data.Repository;
using ScriptAndConsumablesManagement.Data.DataAccess;
using ScriptAndConsumablesManagement.Data.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<ISqlDataAccess, SqlDataAccess>();
//Rozario's Services
builder.Services.AddTransient<IScriptDetailsRepo, ScriptDetailsRepo>();
builder.Services.AddTransient<IWardConsumableRepository, WardConsumableRepository>();
//Ryan's Services
builder.Services.AddTransient<IPatientInstructionRepo, PatientInstructionRepo>();
builder.Services.AddTransient<IScriptRepo, ScriptRepo>();
builder.Services.AddTransient<IScriptDetailRepo, ScriptDetailRepo>();
builder.Services.AddTransient<IScheduleRepo, ScheduleRepo>();

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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
