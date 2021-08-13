using HealthChecks.UI.Client;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;

namespace Gestao.Empresarial.API.IoC.HealthCheckConfig
{
    public static class HealthCheckBuilder
    {
        public static IApplicationBuilder UseLoggerConfig(this IApplicationBuilder app)
        {
            app.UseHealthChecks("/healthcheck-infos", new HealthCheckOptions
            {
                Predicate = _ => true,
                ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse
            });

            app.UseHealthChecksUI(options =>
            {
                options.AsideMenuOpened = false;
                options.UIPath = "/healthcheck-ui";
                options.ApiPath = "/healthcheck";
            });

            return app;
        }
    }
}
