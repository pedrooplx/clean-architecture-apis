using AutoMapper;
using Gestao.Empresarial.Application.Mappers;
using Microsoft.Extensions.DependencyInjection;

namespace Gestao.Empresarial.API.IoC.AutoMapperConfig
{
    public static class AutoMapperConfiguration
    {
        public static IServiceCollection ResolveAutoMapper(this IServiceCollection services)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new AutoMapperUseCase());
            });
            IMapper mapper = config.CreateMapper();
            
            services.AddSingleton(mapper);

            return services;
        }
    }
}
