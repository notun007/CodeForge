using Application.Services.Interfaces.Common;
using Domain.DbModels.Common;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;

namespace CodeForge.Controllers.Common
{    

    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly ICountryService _countryService;
        public CountryController(ICountryService countryService)
        {
            _countryService = countryService;
        }

        [HttpGet("GetAllCountryAsync")]
        public async Task<IActionResult> GetAllCountryAsync()
        {
            return Ok(await _countryService.GetAllCountryAsync());
        }

        [HttpGet("GetCountryByIdAsync")]
        public async Task<IActionResult> GetCountryByIdAsync(Int16 id)
        {
            Country objCountry = new Country();
            objCountry.Id = id;

            return Ok(await _countryService.GetCountryByIdAsync(objCountry));
        }

    }
}
