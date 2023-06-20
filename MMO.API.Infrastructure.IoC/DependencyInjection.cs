using Microsoft.Extensions.DependencyInjection;
using MMO.API.Core.Entities;
using MMO.API.Core.Interfaces;
using MMO.API.Core.Repositories;
using MMO.API.Core.Services;
using MMO.API.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace MMO.API.Infrastructure.IoC
{
    public static class DependencyInjection
    {
        public static void AddDependencyResolver(this IServiceCollection services)
        {
            services.AddScoped<IClientService, ClientService>();

            services.AddScoped<IRepository<Client>, Repository<Client>>();
        }
    }
}
