using DormitoryApi.Application.Abstraction.Services.Persistance;
using DormitoryApi.Application.IRepositories.IBedRepos;
using DormitoryApi.Application.IRepositories.IDormitoryRepos;
using DormitoryApi.Application.IRepositories.IFacultyRepos;
using DormitoryApi.Application.IRepositories.IFloorRepos;
using DormitoryApi.Application.IRepositories.IRoomRepos;
using DormitoryApi.Application.IRepositories.IStaffRepos;
using DormitoryApi.Application.IRepositories.IStudentRepos;
using DormitoryApi.Application.UnitOfWork;
using DormitoryApi.Domain.Entities.Autho;
using DormitoryApi.Persistance.Concreates.Repositories.BedRepos;
using DormitoryApi.Persistance.Concreates.Repositories.DormitoryRepos;
using DormitoryApi.Persistance.Concreates.Repositories.FacultyRepos;
using DormitoryApi.Persistance.Concreates.Repositories.FloorRepos;
using DormitoryApi.Persistance.Concreates.Repositories.RoomRepos;
using DormitoryApi.Persistance.Concreates.Repositories.StaffRepos;
using DormitoryApi.Persistance.Concreates.Repositories.StudentRepos;
using DormitoryApi.Persistance.Configurations;
using DormitoryApi.Persistance.Context;
using DormitoryApi.Persistance.Implementations.Services;
using DormitoryApi.Persistance.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DormitoryApi.Persistance.Extentions
{
    public static class ServiceRegistration
    {
        public static void AddPersistanceServices(this IServiceCollection services)
        {
            services.AddDbContext<DormitoryDbContext>(options => options.UseSqlServer(Connection.ConnectionStringForDormitoryApiDB));

            services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<DormitoryDbContext>();


            services.AddScoped<IBedReadRepository, BedReadRepository>();
            services.AddScoped<IBedWriteRepository, BedWriteRepository>();

            services.AddScoped<IDormitoryReadRepository, DormitoryReadRepository>();
            services.AddScoped<IDormitoryWriteRepository, DormitoryWriteRepository>();

            services.AddScoped<IFacultyReadRepository, FacultyReadRepository>();
            services.AddScoped<IFacultyWriteRepository, FacultyWriteRepository>();

            services.AddScoped<IFloorReadRepository, FloorReadRepository>();
            services.AddScoped<IFloorWriteRepository, FloorWriteRepository>();

            services.AddScoped<IRoomReadRepository, RoomReadRepository>();
            services.AddScoped<IRoomWriteRepository, RoomWriteRepository>();

            services.AddScoped<IStaffReadRepository, StaffReadRepository>();
            services.AddScoped<IStaffWriteRepository, StaffWriteRepository>();

            services.AddScoped<IStudentReadRepository, StudentReadRepository>();
            services.AddScoped<IStudentWriteRepository, StudentWriteRepository>();

            services.AddScoped(typeof(IUnitOfWork<>), typeof(UnitOfWork<>));

            //Services
            //services.AddScoped<IUserService, UserService>();


            services.AddScoped<IBedSevice, BedService>();
            services.AddScoped<IDormitorySevice, DormitoryService>();
            services.AddScoped<IFacultySevice, FacultyService>();
            services.AddScoped<IFloorSevice, FloorService>();
            services.AddScoped<IStaffSevice, StaffService>();
            services.AddScoped<IStudentSevice, StudentService>();
        }
    }
}
