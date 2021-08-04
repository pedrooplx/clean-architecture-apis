using AutoMapper;
using Gestao.Empresarial.Application.Models.CompanyModels;
using Gestao.Empresarial.Application.UseCases.Abstractions;
using Gestao.Empresarial.Domain.Interfaces.Repositories;
using System.Threading.Tasks;

namespace Gestao.Empresarial.Application.UseCases.Company
{
    public class GetCompanyByIdUseCaseAsync : IUseCaseAsync<GetCompanyByIdResquest, GetCompanyByIdResponse>
    {
        private readonly ICompanyGateway _companyGateway;
        private readonly IMapper _mapper;
        public GetCompanyByIdUseCaseAsync(ICompanyGateway companyGateway, IMapper mapper)
        {
            _companyGateway = companyGateway;
            _mapper = mapper;
        }

        public async Task<GetCompanyByIdResponse> ExecuteAsync(GetCompanyByIdResquest request)
        {
            var company = await _companyGateway.GetById(request.Id);

            return _mapper.Map<GetCompanyByIdResponse>(company);
        }
    }
}
