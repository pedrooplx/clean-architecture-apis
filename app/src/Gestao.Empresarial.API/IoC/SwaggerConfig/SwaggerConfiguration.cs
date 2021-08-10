using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace Gestao.Empresarial.API.IoC.SwaggerConfig
{
    public static class SwaggerConfiguration
    {
        public static IServiceCollection ResolveSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(options =>
            {
                options.OperationFilter<SwaggerDefaultValues>();
            });

            return services;
        }
    }
}
