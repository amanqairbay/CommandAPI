using CommandAPI.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var config = builder.Configuration;

builder.Services.AddDbContext<CommandContext>(opt => {
    opt.UseNpgsql(config.GetConnectionString("PostgreSqlConnection"));
});

builder.Services.AddScoped<ICommandAPIRepo, SqlCommandAPIRepo>();
builder.Services.AddControllers();

var app = builder.Build();

app.UseRouting();

app.MapControllers();

app.Run();
