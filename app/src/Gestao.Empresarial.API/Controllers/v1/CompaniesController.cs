using Gestao.Empresarial.API.Abstractions.Controllers;
using Gestao.Empresarial.Application.Models.CompanyModels;
using Gestao.Empresarial.Application.UseCases.Abstractions;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Gestao.Empresarial.API.v1.Controllers
{
    [ApiVersion("1.0")]
    //[ApiVersion("1.0", Deprecated = true)]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class CompaniesController : BaseController
    {
        private readonly IUseCaseAsync<GetCompanyByIdResquest, GetCompanyByIdResponse> _getCompanyByIdUseCase;

        public CompaniesController(IUseCaseAsync<GetCompanyByIdResquest, GetCompanyByIdResponse> getCompanyByIdUseCase)
        {
            _getCompanyByIdUseCase = getCompanyByIdUseCase;
        }

        [HttpGet]
        public IActionResult GetCompanies()
        {
            return Ok("Retorno Ok!");
        }
        
        [HttpGet("{Id:Guid}")]
        public IActionResult GetCompanyById(Guid id)
        {
            return Ok(_getCompanyByIdUseCase.ExecuteAsync(new GetCompanyByIdResquest { Id = id }).Result);
        }
    }
}
