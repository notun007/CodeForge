using Application.Services.Interfaces.Common;
using Domain.DbModels.Common;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;

namespace CodeForge.Controllers.Common
{
    //public class CountryController : Controller
    //{
    //    public IActionResult Index()
    //    {
    //        return View();
    //    }
    //}


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


        //[HttpPost("register")]
        //public async Task<IActionResult> RegisterAsync(RegisterRequest request)
        //{
        //    var origin = Request.Headers["origin"];
        //    return Ok(await _accountService.RegisterAsync(request, origin));
        //}
        //[HttpGet("confirm-email")]
        //public async Task<IActionResult> ConfirmEmailAsync([FromQuery] string userId, [FromQuery] string code)
        //{
        //    var origin = Request.Headers["origin"];
        //    await _accountService.ConfirmEmailAsync(userId, code);
        //    return Ok();
        //}
        //private string GenerateIPAddress()
        //{
        //    if (Request.Headers.ContainsKey("X-Forwarded-For"))
        //        return Request.Headers["X-Forwarded-For"];
        //    else
        //        return HttpContext.Connection.RemoteIpAddress.MapToIPv4().ToString();
        //}
    }
}
