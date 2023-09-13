using DormitoryApi.Application.Abstraction.Services.Infrastructure.TokenService;
using DormitoryApi.Infrastructure.Implementations.Service.TokenService;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DormitoryApi.Infrastructure.Extentions
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructureService(this IServiceCollection services)
        {
            services.AddScoped<ITokenHandler, TokenHandler>();

        }
    }
}
