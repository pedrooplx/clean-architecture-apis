using Gestao.Empresarial.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gestao.Empresarial.API.Controllers
{
    [Route("api/[controller]")]
    public class CompaniesController : BaseController
    {
        private readonly ICompanyService _companyService;
        public CompaniesController(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        [HttpGet]
        public IActionResult GetCompanies()
        {
            return Ok(_companyService.GetCompanies());
        }

        [HttpGet("{id:guid}")]
        public ActionResult GetCompanyById(Guid id)
        {
            return Ok(_companyService.GetCompanyById(id));
        }
    }
}
