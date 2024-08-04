using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SandboxServerManager.Core.Interfaces;
using SandboxServerManager.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandboxServerManager.Infrastructure
{
    public static class InfrastructureContainer 
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<SandboxContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("SandboxConnString")));

            services.AddScoped<IPlayerRepository, PlayerRepository>();

            return services;
        }
    }
}
