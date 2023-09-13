using DormitoryApi.Application.AutoMapper;
using DormitoryApi.Infrastructure.Extentions;
using DormitoryApi.Persistance.Extentions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//Persistance Layer Services
builder.Services.AddPersistanceServices();

//Infrastructure Layer Services
builder.Services.AddInfrastructureService();


//Aplication
builder.Services.AddAutoMapper(typeof(MyProfile));

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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
