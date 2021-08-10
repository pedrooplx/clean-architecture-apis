using Gestao.Empresarial.API.IoC.SwaggerConfig;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gestao.Empresarial.API.IoC
{
    public static class ResolveBuilders
    {
        public static void RegisterBuilders(this IApplicationBuilder app, IApiVersionDescriptionProvider provider)
        {
            SwaggerBuilder.UseSwaggerConfig(app, provider);
        }
    }
}
