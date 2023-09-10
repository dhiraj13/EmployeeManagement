var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

// Add Static Files Middleware
app.UseStaticFiles();

app.Run();
