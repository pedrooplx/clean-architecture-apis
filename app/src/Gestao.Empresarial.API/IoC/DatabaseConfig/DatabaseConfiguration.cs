using Gestao.Empresarial.Infrastructure.DataProviders.Repositories.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gestao.Empresarial.API.IoC.DatabaseConfig
{
    public static class DatabaseConfiguration
    {
        public static IServiceCollection ResolveDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("GestaoEmpresarialDatabaseConnection"));
            });

            return services;
        }
    }
}
