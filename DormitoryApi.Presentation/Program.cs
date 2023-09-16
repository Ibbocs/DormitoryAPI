using DormitoryApi.Application.AutoMapper;
using DormitoryApi.Application.Validation.UserValid;
using DormitoryApi.Infrastructure.Extentions;
using DormitoryApi.Persistance.Extentions;
using DormitoryAPI.Presentation.Middlewares;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.HttpLogging;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Serilog.Events;
using Serilog;
using System.Collections.ObjectModel;
using System.Data;
using System.Security.Claims;
using System.Text;
using Serilog.Core;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddFluentValidation(config => config.RegisterValidatorsFromAssemblyContaining<CreatUserValidator>());

//Persistance Layer Services
builder.Services.AddPersistanceServices();

//Infrastructure Layer Services
builder.Services.AddInfrastructureService();


//Aplication
builder.Services.AddAutoMapper(typeof(MyProfile));

//Presentation
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;

}).AddJwtBearer(options =>
{
    options.TokenValidationParameters = new()
    {
        ValidateAudience = true,//tokunumuzu kim/hansi origin islede biler
        ValidateIssuer = true, //tokunu kim palylayir/yaradir
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true, //tokenin ozel keyi

        ValidAudience = builder.Configuration["Token:Audience"],

        ValidIssuer = builder.Configuration["Token:Issuer"],

        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Token:SecurityKey"])),

        //tiken omru qeder islemesi ucun
        LifetimeValidator = (notBefore, expires, securityToken, validationParameters) => expires != null ? expires > DateTime.UtcNow : false,

        NameClaimType = ClaimTypes.Name,
        RoleClaimType = ClaimTypes.Role,
    };
});
//bunun asagida midilwarede yazmisam(app.Use - bu Proqram.cs da) bu da requestlerin logu ucun lazim
builder.Services.AddHttpLogging(logging =>
{
    logging.LoggingFields = HttpLoggingFields.All;
    logging.RequestHeaders.Add("sec-ch-ua");
    logging.MediaTypeOptions.AddText("application/javascript");
    logging.RequestBodyLogLimit = 4096;
    logging.ResponseBodyLogLimit = 4096;
});

builder.Services.AddHttpContextAccessor(); //context gormek ucun http

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(swagger =>
{
    //This is to generate the Default UI of Swagger Documentation  
    swagger.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "Restaurant Final API",
        Description = "ASP.NET Core 6 Web API"
    });
    // To Enable authorization using Swagger (JWT)  
    swagger.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
    {
        Name = "Authorization",
        Type = SecuritySchemeType.Http,
        Scheme = "Bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Description = "JWT Authorization header using the Bearer scheme."
    });
    swagger.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                          new OpenApiSecurityScheme
                            {
                                Reference = new OpenApiReference
                                {
                                    Type = ReferenceType.SecurityScheme,
                                    Id = "Bearer"
                                }
                            },
                            new string[] {}

                    }
                });
});


Logger? log = new LoggerConfiguration()
    .WriteTo.Console()
    .WriteTo.File("Logs/mylog-{Date}.txt")
    .MinimumLevel.Information()
    .CreateLogger();

builder.Host.UseSerilog(log);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseMiddleware<GlobalExceptionHandlerMiddleware>();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
