using Microsoft.AspNetCore.Mvc;

namespace CodeForge.Controllers.Security
{
    using Application.Services.Interfaces;
    using Domain.Identity.DbModels.Security;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class MenuPermissionController : ControllerBase
    {
        private readonly IMenuPermissionService _service;

        public MenuPermissionController(IMenuPermissionService service)
        {
            _service = service;
        }

        [HttpPost("AddMenuPermissionAsync")]
        public async Task<IActionResult> AddMenuPermissionAsync(MenuPermission obj)
        {
            var result = await _service.AddMenuPermissionAsync(obj);
            return Ok(result);
        }

        [HttpPut("UpdateMenuPermissionAsync")]
        public async Task<IActionResult> UpdateMenuPermissionAsync(MenuPermission obj)
        {
            await _service.UpdateMenuPermissionAsync(obj);
            return NoContent();
        }

        [HttpGet("GetAllMenuPermissionAsync")]
        public async Task<IActionResult> GetAllMenuPermissionAsync()
        {
            var result = await _service.GetAllMenuPermissionAsync();
            return Ok(result);
        }

        [HttpGet("GetMenuPermissionByIdAsync")]
        public async Task<IActionResult> GetMenuPermissionByIdAsync(short id)
        {
            var obj = new MenuPermission { Id = id };
            var result = await _service.GetMenuPermissionByIdAsync(obj);
            return Ok(result);
        }
    }

}
