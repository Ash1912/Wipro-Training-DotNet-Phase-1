var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Log incoming requests and responses
app.Use(async (context, next) =>
{
    // Log request details
    Console.WriteLine($"Request: {context.Request.Method} {context.Request.Path}");

    await next.Invoke();

    // Log response status code
    Console.WriteLine($"Response Status Code: {context.Response.StatusCode}");
});

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
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

app.Use(async (context, next) =>
{
    context.Response.Headers.Add("Content-Security-Policy", "default-src 'self'; script-src 'self'; style-src 'self';");
    await next.Invoke();
});
