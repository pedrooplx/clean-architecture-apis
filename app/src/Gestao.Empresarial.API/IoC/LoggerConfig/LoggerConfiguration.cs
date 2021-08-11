using KissLog;
using KissLog.AspNetCore;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Gestao.Empresarial.API.IoC.LoggerConfig
{
    public static class LoggerConfiguration
    {
        public static IServiceCollection ResolveLogger(this IServiceCollection services)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<ILogger>((context) =>
            {
                return Logger.Factory.Get();
            });

            services.AddLogging(logging =>
            {
                logging.AddKissLog();
            });

            return services;
        }
    }
}
