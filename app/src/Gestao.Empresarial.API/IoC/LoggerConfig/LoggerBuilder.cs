using KissLog.AspNetCore;
using KissLog.CloudListeners.RequestLogsListener;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using System;
using System.Diagnostics;
using System.Text;

namespace Gestao.Empresarial.API.IoC.LoggerConfig
{
    public static class LoggerBuilder
    {
        public static IApplicationBuilder UseLoggerConfig(this IApplicationBuilder app, IConfiguration configuration)
        {
            app.UseKissLogMiddleware(options => {
                ConfigureKissLog(options, configuration);
            });

            return app;
        }

        private static void ConfigureKissLog(IOptionsBuilder options, IConfiguration configuration)
        {
            // optional KissLog configuration
            options.Options
                .AppendExceptionDetails((Exception ex) =>
                {
                    StringBuilder sb = new StringBuilder();

                    if (ex is System.NullReferenceException nullRefException)
                    {
                        sb.AppendLine("Important: check for null references");
                    }

                    return sb.ToString();
                });

            // KissLog internal logs
            options.InternalLog = (message) =>
            {
                Debug.WriteLine(message);
            };

            // register logs output
            RegisterKissLogListeners(options, configuration);
        }

        private static void RegisterKissLogListeners(IOptionsBuilder options, IConfiguration configuration)
        {
            // multiple listeners can be registered using options.Listeners.Add() method

            // register KissLog.net cloud listener
            options.Listeners.Add(new RequestLogsApiListener(new KissLog.CloudListeners.Auth.Application(
                configuration["Secrets:ApiModelo:KissLog:OrganizationId"],
                configuration["Secrets:ApiModelo:KissLog:ApplicationId"])
            )
            {
                ApiUrl = configuration["Secrets:ApiModelo:KissLog:ApiUrl"]
            });
        }
    }
}
