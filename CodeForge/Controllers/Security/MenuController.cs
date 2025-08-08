using Microsoft.AspNetCore.Mvc;

namespace CodeForge.Controllers.Security
{
    using Application.Services.Interfaces;
    using Domain.Identity.DbModels.Security;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;

    [Route("api/[controller]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        private readonly IMenuService _menuService;

        public MenuController(IMenuService menuService)
        {
            _menuService = menuService;
        }

        [HttpPost("AddMenuAsync")]
        public async Task<IActionResult> AddMenuAsync(Menu objMenu)
        {
            var result = await _menuService.AddMenuAsync(objMenu);
            return Ok(result);
        }

        [HttpPut("UpdateMenuAsync")]
        public async Task<IActionResult> UpdateMenuAsync(Menu objMenu)
        {
            await _menuService.UpdateMenuAsync(objMenu);
            return NoContent();
        }

        [HttpGet("GetAllMenuAsync")]
        public async Task<IActionResult> GetAllMenuAsync()
        {
            var result = await _menuService.GetAllMenuAsync();
            return Ok(result);
        }

        [HttpGet("GetMenuByIdAsync")]
        public async Task<IActionResult> GetMenuByIdAsync(short id)
        {
            var menu = new Menu { Id = id };
            var result = await _menuService.GetMenuByIdAsync(menu);
            return Ok(result);
        }
    }

}
