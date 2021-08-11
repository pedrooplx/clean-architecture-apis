using Gestao.Empresarial.API.Abstractions.Controllers;
using Gestao.Empresarial.Application.Models.CompanyModels;
using Gestao.Empresarial.Application.UseCases.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace Gestao.Empresarial.API.v1.Controllers
{
    [ApiVersion("1.0", Deprecated = true)]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class CompaniesController : BaseController
    {
        private readonly ILogger _logger;
        private readonly IUseCaseAsync<GetCompanyByIdResquest, GetCompanyByIdResponse> _getCompanyByIdUseCase;

        public CompaniesController(
            IUseCaseAsync<GetCompanyByIdResquest, GetCompanyByIdResponse> getCompanyByIdUseCase,
            ILogger<CompaniesController> logger)
        {
            _getCompanyByIdUseCase = getCompanyByIdUseCase;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetCompanies()
        {
            _logger.LogInformation(DateTime.Now.ToString());

            return Ok("Retorno Ok!");
        }
    }
}
