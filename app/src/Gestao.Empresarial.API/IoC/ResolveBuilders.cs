using Gestao.Empresarial.API.IoC.HealthCheckConfig;
using Gestao.Empresarial.API.IoC.LoggerConfig;
using Gestao.Empresarial.API.IoC.SwaggerConfig;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.Extensions.Configuration;

namespace Gestao.Empresarial.API.IoC
{
    public static class ResolveBuilders
    {
        public static void RegisterBuilders(
            this IApplicationBuilder app, 
            IApiVersionDescriptionProvider provider, 
            IConfiguration configuration
            )
        {
            HealthCheckBuilder.UseLoggerConfig(app);
            SwaggerBuilder.UseSwaggerConfig(app, provider);
            LoggerBuilder.UseLoggerConfig(app, configuration);
        }
    }
}
