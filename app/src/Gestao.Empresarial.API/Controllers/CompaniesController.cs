using Gestao.Empresarial.Application.Models.CompanyModels;
using Gestao.Empresarial.Application.UseCases.Abstractions;
using Gestao.Empresarial.Domain.Interfaces.Repositories;
using Gestao.Empresarial.Infrastructure.Persistence.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Gestao.Empresarial.API.Controllers
{
    [Route("api/[controller]")]
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
            return Ok(_getCompanyByIdUseCase.ExecuteAsync(new GetCompanyByIdResquest { Id = id }));
        }
    }
}
