using Microsoft.AspNetCore.Mvc;

namespace CodeForge.Controllers.Security
{
    using Application.Services.Interfaces;
    using Domain.Identity.DbModels.Security;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;

    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationRoleController : ControllerBase
    {
        private readonly IApplicationRoleService _roleService;

        public ApplicationRoleController(IApplicationRoleService roleService)
        {
            _roleService = roleService;
        }

        [HttpPost("AddRoleAsync")]
        public async Task<IActionResult> AddRoleAsync(ApplicationRole role)
        {
            var result = await _roleService.AddRoleAsync(role);
            return Ok(result);
        }

        [HttpPut("UpdateRoleAsync")]
        public async Task<IActionResult> UpdateRoleAsync(ApplicationRole role)
        {
            await _roleService.UpdateRoleAsync(role);
            return NoContent();
        }

        [HttpGet("GetAllRolesAsync")]
        public async Task<IActionResult> GetAllRolesAsync()
        {
            var result = await _roleService.GetAllRolesAsync();
            return Ok(result);
        }

        [HttpGet("GetRoleByIdAsync")]
        public async Task<IActionResult> GetRoleByIdAsync(string id)
        {
            var result = await _roleService.GetRoleByIdAsync(id);
            return Ok(result);
        }
    }

}
