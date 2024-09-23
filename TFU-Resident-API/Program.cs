using Microsoft.EntityFrameworkCore;
using TFU_Resident_API.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
// ??ng ký DbContext cho Database 1
builder.Services.AddDbContext<TFU_Resident_API.Models.SoftwareOwnerTFU.AppDbContext1>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Database1")));

// ??ng ký DbContext cho Database 2
//builder.Services.AddDbContext<AppDbContext2>(options =>
//    options.UseSqlServer(builder.Configuration.GetConnectionString("Database2")));

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
