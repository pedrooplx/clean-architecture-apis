using Gestao.Empresarial.API.IoC.AutoMapperConfig;
using Gestao.Empresarial.API.IoC.DatabaseConfig;
using Gestao.Empresarial.Application.Models.CompanyModels;
using Gestao.Empresarial.Application.UseCases.Abstractions;
using Gestao.Empresarial.Application.UseCases.Company;
using Gestao.Empresarial.Domain.Interfaces.Repositories;
using Gestao.Empresarial.Infrastructure.Persistence.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            DatabaseConfiguration.ResolveDatabase(services, configuration);
            AutoMapperConfiguration.ResolveAutoMapper(services);
            ResolveGateways(services);
            ResolveUseCases(services);
        }

        private static void ResolveGateways(this IServiceCollection services)
        {
            services.AddScoped<ICompanyGateway, CompanyRepository>();
        }
        private static void ResolveUseCases(this IServiceCollection services)
        {
            services.AddScoped<IUseCaseAsync<GetCompanyByIdResquest, GetCompanyByIdResponse>, GetCompanyByIdUseCaseAsync>();
        }
    }
}
