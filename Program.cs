var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Use Heroku's PORT environment variable
var port = Environment.GetEnvironmentVariable("PORT") ?? "5000";
app.Urls.Add($"http://*:{port}");

app.UseStaticFiles();
app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Auth}/{action=Login}/{id?}");
});

app.Run();
