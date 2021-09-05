using Cel.CelestialMechanics.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Cel.CelestialMechanics.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MecanicaCelesteController : ControllerBase
    {
        private readonly IMecanicaSistemaSolarFactory _mecanicaSistemaSolarFactory;

        public MecanicaCelesteController(IMecanicaSistemaSolarFactory mecanicaSistemaSolarFactory)
        {
            _mecanicaSistemaSolarFactory = mecanicaSistemaSolarFactory;
        }

        [HttpGet]
        public IActionResult Get(DateTime? data)
        {
            if (!data.HasValue)
                return BadRequest("Data não informada.");

            return Ok(_mecanicaSistemaSolarFactory.Builder((DateTime)data));
        }
    }
}
