using DormitoryApi.Domain.Entities.Autho;
using DormitoryApi.Persistance.Configurations;
using DormitoryApi.Persistance.Context;
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
        }
    }
}
