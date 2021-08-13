using Gestao.Empresarial.API.IoC.AutoMapperConfig;
using Gestao.Empresarial.API.IoC.DatabaseConfig;
using Gestao.Empresarial.API.IoC.HealthCheckConfig;
using Gestao.Empresarial.API.IoC.LoggerConfig;
using Gestao.Empresarial.API.IoC.SwaggerConfig;
using Gestao.Empresarial.Application.Models.CompanyModels;
using Gestao.Empresarial.Application.UseCases.Abstractions;
using Gestao.Empresarial.Application.UseCases.Company;
using Gestao.Empresarial.Domain.Interfaces.Repositories;
using Gestao.Empresarial.Infrastructure.Persistence.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Gestao.Empresarial.API.IoC
{
    public static class ResolveDependencies
    {
        public static void RegisterServices(this IServiceCollection services, IConfiguration configuration)
        {
            ResolveServices(services, configuration);
        }
        private static void ResolveServices(this IServiceCollection services, IConfiguration configuration)
        {
            HealthCheckConfiguration.ResolveHealthyCheck(services, configuration);
            VersioningConfiguration.ResolveVersioning(services);
            SwaggerConfiguration.ResolveSwagger(services);
            DatabaseConfiguration.ResolveDatabase(services, configuration);
            AutoMapperConfiguration.ResolveAutoMapper(services);
            LoggerConfiguration.ResolveLogger(services);

            ResolveGateways(services);
            ResolveUseCases(services);
            ResolveExtensions(services);
        }

        private static void ResolveGateways(this IServiceCollection services)
        {
            services.AddScoped<ICompanyGateway, CompanyRepository>();
        }
        private static void ResolveUseCases(this IServiceCollection services)
        {
            services.AddScoped<IUseCaseAsync<GetCompanyByIdResquest, GetCompanyByIdResponse>, GetCompanyByIdUseCaseAsync>();
            services.AddScoped<IUseCaseAsync<CreateCompanyRequest>, CreateCompanyUseCaseAsync>();
        }

        private static void ResolveExtensions(this IServiceCollection services)
        {
            services.AddTransient<IConfigureOptions<SwaggerGenOptions>, SwaggerOptions>();
        }
    }
}
