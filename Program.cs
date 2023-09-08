var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World! We deployed from Github to Azure! One further update. Another one. Next!");

app.Run();
