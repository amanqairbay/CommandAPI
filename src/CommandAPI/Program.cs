using CommandAPI.Data;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Serialization;
using Npgsql;

var builder = WebApplication.CreateBuilder(args);
var config = builder.Configuration;

var npgsqlBuilder = new NpgsqlConnectionStringBuilder();
npgsqlBuilder.ConnectionString = config.GetConnectionString("PostgreSqlConnection");
npgsqlBuilder.Username = config["UserID"];
npgsqlBuilder.Password = config["Password"];

builder.Services.AddDbContext<CommandContext>(opt => { opt.UseNpgsql(npgsqlBuilder.ConnectionString); });
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddScoped<ICommandAPIRepo, SqlCommandAPIRepo>();

builder.Services.AddControllers().AddNewtonsoftJson(s => {
    s.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
});

var app = builder.Build();
var env = app.Environment;

if (env.IsDevelopment()) { app.UseDeveloperExceptionPage(); }

app.UseRouting();
app.MapControllers();

app.Run();
