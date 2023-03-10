using Microsoft.EntityFrameworkCore;
using UniversityManagementV2.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddSqlServer<UniversityDbContext>(builder.Configuration.GetConnectionString("Default"));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

using(var scope = app.Services.CreateScope())
{
    var ctx = scope.ServiceProvider.GetRequiredService<UniversityDbContext>();
    ctx.Database.Migrate();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
