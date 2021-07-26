using Gestao.Empresarial.Domain.Entities;
using Gestao.Empresarial.Domain.Gateways.Abstractions.Repository;
using Gestao.Empresarial.Domain.Interfaces.Repositories;
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

        [HttpGet]
        public IActionResult GetCompanies()
        {
            return Ok();
        }

        [HttpGet("{id:guid}")]
        public IActionResult GetCompanyById(Guid id)
        {
            return Ok();
        }
    }
}
