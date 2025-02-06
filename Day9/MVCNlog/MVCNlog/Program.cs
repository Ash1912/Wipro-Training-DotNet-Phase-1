using Microsoft.EntityFrameworkCore;
using MVCNlog.Models;
using MVCNlog.Services;
using NLog;
using NLog.Web;

var builder = WebApplication.CreateBuilder(args);

// Set up NLog for Dependency Injection (DI)
builder.Host.ConfigureLogging(logging =>
{
    logging.ClearProviders();  // Clear default providers
    logging.SetMinimumLevel(Microsoft.Extensions.Logging.LogLevel.Trace);  // Set minimum log level
}).UseNLog();  // Use NLog as the logging provider

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<UserDbContext>(op => op.UseSqlServer(builder.Configuration.GetConnectionString("NewConn")));

//Dependency Injection - AddSingleton, AddScoped and AddTransient
builder.Services.AddScoped<UserService>();

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