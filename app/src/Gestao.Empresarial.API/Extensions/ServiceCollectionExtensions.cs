using Gestao.Empresarial.Application.Services.Interfaces;
using Gestao.Empresarial.Application.Services.Services;
using Gestao.Empresarial.Domain.Interfaces.Repositories;
using Gestao.Empresarial.Infrastructure.Persistence.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Gestao.Empresarial.API.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<ICompanyGateway, CompanyRepository>();

            return services;
        }
        
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<ICompanyService, CompanyService>();

            return services;
        }

    }
}
