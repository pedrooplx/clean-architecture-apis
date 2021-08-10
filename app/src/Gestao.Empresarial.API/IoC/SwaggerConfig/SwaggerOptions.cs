using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;

namespace Gestao.Empresarial.API.IoC.SwaggerConfig
{
    public class SwaggerOptions : IConfigureOptions<SwaggerGenOptions>
    {
        readonly IApiVersionDescriptionProvider provider;

        public SwaggerOptions(IApiVersionDescriptionProvider provider)
        {
            this.provider = provider;
        }

        public void Configure(SwaggerGenOptions options)
        {
            foreach (var description in provider.ApiVersionDescriptions)
            {
                options.SwaggerDoc(description.GroupName, CreateInfoForApiVersion(description));
            }
        }

        static OpenApiInfo CreateInfoForApiVersion(ApiVersionDescription description)
        {
            var swaggerInfos = new OpenApiInfo()
            {
                Title = "API Modelo",
                Version = description.ApiVersion.ToString(),
                Description = "API Modelo para novos desenvolvimentos",
                Contact = new OpenApiContact()
                {
                    Email = "pedrooplx@gmail.com",
                    Name = "Pedro Henrique",
                    Url = new Uri("https://www.linkedin.com/in/pedrooplx/")
                },
                License = new OpenApiLicense()
                {
                    Name = "MIT",
                    Url = new Uri("https://opensource.org/licenses/MIT")
                },
                TermsOfService = new Uri("https://opensource.org/licenses/MIT")
            };

            if (description.IsDeprecated)
            {
                swaggerInfos.Description = "Essa versão está obsoleta";
            }

            return swaggerInfos;
        }
    }
}
