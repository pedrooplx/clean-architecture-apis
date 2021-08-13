using AutoMapper;
using Gestao.Empresarial.Application.Models.CompanyModels;
using Gestao.Empresarial.Application.UseCases.Abstractions;
using Gestao.Empresarial.Domain.Interfaces.Repositories;
using System.Threading.Tasks;

namespace Gestao.Empresarial.Application.UseCases.Company
{
    public class CreateCompanyUseCaseAsync : IUseCaseAsync<CreateCompanyRequest>
    {
        private readonly ICompanyGateway _companyGateway;
        private readonly IMapper _mapper;

        public CreateCompanyUseCaseAsync(ICompanyGateway companyGateway, IMapper mapper)
        {
            _companyGateway = companyGateway;
            _mapper = mapper;
        }

        public async Task ExecuteAsync(CreateCompanyRequest request)
        {
            var company = _mapper.Map<Gestao.Empresarial.Domain.Entities.Company>(request);
            await _companyGateway.Create(company);
        }
    }
}
