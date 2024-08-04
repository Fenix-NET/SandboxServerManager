using Microsoft.Extensions.DependencyInjection;
using SandboxServerManager.Application.Services;
using SandboxServerManager.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandboxServerManager.Application
{
    public static class ApplicationContainer
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IPlayerService, PlayerService>();

            return services;
        }
    }
}
