using Gestao.Empresarial.Infrastructure.DataProviders.Repositories.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Gestao.Empresarial.API.IoC.HealthCheckConfig
{
    public static class HealthCheckConfiguration
    {
        public static IServiceCollection ResolveHealthyCheck (IServiceCollection services, IConfiguration configuration)
        {
            services.AddHealthChecks()
                .AddDbContextCheck<ApplicationDbContext>()
                .AddApplicationInsightsPublisher()
                .AddSqlServer(
                    connectionString: configuration.GetConnectionString("GestaoEmpresarialDatabaseConnection"),
                    name: "SqlDatabase"
                );

            services.AddHealthChecksUI().AddInMemoryStorage();

            return services;
        }
    }
}
