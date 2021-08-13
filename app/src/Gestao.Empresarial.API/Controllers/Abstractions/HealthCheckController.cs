using Gestao.Empresarial.API.Abstractions.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Newtonsoft.Json;
using System.Net;
using System.Threading.Tasks;

namespace Gestao.Empresarial.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class HealthCheckController : BaseController
    {
        private readonly HealthCheckService _healthCheckService;

        public HealthCheckController(HealthCheckService healthCheckService)
        {
            _healthCheckService = healthCheckService;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            HealthReport report = await _healthCheckService.CheckHealthAsync();

            if (report.Status == HealthStatus.Healthy)
                return Ok(report);

            return StatusCode((int)HttpStatusCode.ServiceUnavailable, report);
        }
    }
}
