using CommandAPI.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<ICommandAPIRepo, MockCommandAPIRepo>();
builder.Services.AddControllers();

var app = builder.Build();

app.UseRouting();

app.MapControllers();

app.Run();
