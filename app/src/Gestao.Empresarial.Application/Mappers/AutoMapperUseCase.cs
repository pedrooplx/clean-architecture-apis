using AutoMapper;
using Gestao.Empresarial.Application.Models.CompanyModels;
using Gestao.Empresarial.Domain.Entities;

namespace Gestao.Empresarial.Application.Mappers
{
    public class AutoMapperUseCase : Profile
    {
        public AutoMapperUseCase()
        {
            CreateMap<Company, GetCompanyByIdResponse>();
        }
    }
}
