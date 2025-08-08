using Application.Services.Interfaces;
using Domain.Identity.DbModels.Security;
using Microsoft.AspNetCore.Mvc;

namespace CodeForge.Controllers.Security
{

    [Route("api/[controller]")]
    [ApiController]
    public class ModuleController : ControllerBase
    {
        private readonly IModuleService _moduleService;

        public ModuleController(IModuleService moduleService)
        {
            _moduleService = moduleService;
        }

        [HttpPost("AddModuleAsync")]
        public async Task<IActionResult> AddModuleAsync(Module objModule)
        {
            var result = await _moduleService.AddModuleAsync(objModule);
            return Ok(result);
        }

        [HttpGet("GetAllModuleAsync")]
        public async Task<IActionResult> GetAllModuleAsync()
        {
            var result = await _moduleService.GetAllModuleAsync();
            return Ok(result);
        }

        [HttpGet("GetModuleByIdAsync")]
        public async Task<IActionResult> GetModuleByIdAsync(short id)
        {
            var module = new Module { Id = id };
            var result = await _moduleService.GetModuleByIdAsync(module);
            return Ok(result);
        }
    }
}
