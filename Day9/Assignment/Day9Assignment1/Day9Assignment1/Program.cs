using Day9Assignment1.Models;
using Day9Assignment1.Services;
using Microsoft.EntityFrameworkCore;
using NLog;
using NLog.Web;

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseNLog();

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<UserDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("NewConn")));

builder.Services.AddScoped<IUserService, UserService>();

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

try
{
    // Log the application startup success
    var logger = LogManager.GetCurrentClassLogger(); // Get logger
    logger.Info("Application starting up...");

    // Run the application
    app.Run();
}
catch (Exception ex)
{
    // Log application startup failures
    var logger = LogManager.GetCurrentClassLogger(); // Get logger
    logger.Fatal(ex, "Application start-up failed.");
}
finally
{
    // Ensure all logs are flushed at application shutdown
    LogManager.Shutdown();  // Properly close NLog
}
