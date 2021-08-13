using Gestao.Empresarial.API.Abstractions.Controllers;
using Gestao.Empresarial.Application.Models.CompanyModels;
using Gestao.Empresarial.Application.UseCases.Abstractions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Gestao.Empresarial.API.v2.Controllers
{
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class CompaniesController : BaseController
    {
        private readonly IUseCaseAsync<GetCompanyByIdResquest, GetCompanyByIdResponse> _getCompanyByIdUseCase;
        private readonly IUseCaseAsync<CreateCompanyRequest> _createCompanyUseCase;

        public CompaniesController(
            IUseCaseAsync<GetCompanyByIdResquest, GetCompanyByIdResponse> getCompanyByIdUseCase,
            IUseCaseAsync<CreateCompanyRequest> createCompanyUseCase)
        {
            _getCompanyByIdUseCase = getCompanyByIdUseCase;
            _createCompanyUseCase = createCompanyUseCase;
        }

        [HttpGet("{Id:Guid}")]
        public IActionResult GetCompanyById(Guid id)
        {
            return Ok(_getCompanyByIdUseCase.ExecuteAsync(new GetCompanyByIdResquest { Id = id }).Result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCompany([FromBody] CreateCompanyRequest companyRequest)
        {
            await _createCompanyUseCase.ExecuteAsync(companyRequest);

            return Ok(companyRequest);
        }
    }
}
