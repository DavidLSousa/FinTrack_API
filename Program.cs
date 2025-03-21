using FinTrack_API.router;
using FinTrack_API.src.Repositories;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc(
    "v1", 
    new OpenApiInfo { Title = "FinTrack API", 
        Description = "Gerenciar portfolio de invertimento", 
        Version = "v1" 
        }
    );
});

builder.Services.AddScoped<IDatabaseRepository, MariaDBRepository>();

var app = builder.Build();
var port = Environment.GetEnvironmentVariable("PORT") ?? "5001";

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "FinTrack API V1");
    });
}

Router.Map(app);

app.Run($"http://localhost:{port}");