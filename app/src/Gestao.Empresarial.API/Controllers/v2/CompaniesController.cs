using Gestao.Empresarial.API.Abstractions.Controllers;
using Gestao.Empresarial.Application.Models.CompanyModels;
using Gestao.Empresarial.Application.UseCases.Abstractions;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Gestao.Empresarial.API.v2.Controllers
{
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class CompaniesController : BaseController
    {
        private readonly IUseCaseAsync<GetCompanyByIdResquest, GetCompanyByIdResponse> _getCompanyByIdUseCase;

        public CompaniesController(IUseCaseAsync<GetCompanyByIdResquest, GetCompanyByIdResponse> getCompanyByIdUseCase)
        {
            _getCompanyByIdUseCase = getCompanyByIdUseCase;
        }
        
        [HttpGet("{Id:Guid}")]
        public IActionResult GetCompanyById(Guid id)
        {
            return Ok(_getCompanyByIdUseCase.ExecuteAsync(new GetCompanyByIdResquest { Id = id }).Result);
        }
    }
}
