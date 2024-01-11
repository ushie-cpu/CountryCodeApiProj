using Entity.DTOs;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace CountryCodeApiProj.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CountryController : ControllerBase
    {
        private readonly ILogger<CountryController> _logger;
        private readonly ICountryService service;

        public CountryController(ILogger<CountryController> logger, ICountryService service)
        {
            _logger = logger;
            this.service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery]GetCountryDto request)
        {
            var result = await service.FindAsync(request);

            if(result == null) return NotFound();

            return Ok(result);
        }
    }
}
