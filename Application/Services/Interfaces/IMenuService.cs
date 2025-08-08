using Domain.Identity.DbModels.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Interfaces
{
    public interface IMenuService
    {
        Task<Menu> AddMenuAsync(Menu objMenu);
        Task UpdateMenuAsync(Menu objMenu);
        Task<IEnumerable<Menu>> GetAllMenuAsync();
        Task<Menu> GetMenuByIdAsync(Menu objMenu);
    }

}
