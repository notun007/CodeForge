using Domain.Identity.DbModels.Security;
using Domain.Identity.ViewModels.Security;
using Infrastructure.Identity.Context;
using Infrastructure.Identity.Interfaces.Security;
using Infrastructure.Identity.RepositoryBase;
using Infrastructure.Shared.GenericRepository;
using Microsoft.EntityFrameworkCore;


namespace Infrastructure.Identity.Implementations.Security
{
    public class MenuPermissionRepository : Repository<IdentityContext, MenuPermission>, IMenuPermissionRepository
    {       
        public MenuPermissionRepository(IdentityContext dbContext) : base(dbContext)
        {
        }

        public async Task<List<ModuleViewModel>> GetModuleMenuByRole(string roleId)
        {


            try
            {
                var moduleList = new List<ModuleViewModel>();
                var parentList = new List<UserMenuViewModel>();
                var childList = new List<ChildMenuViewModel>();


                var modules = await _context.Modules.Where(x => x.IsActive == true).OrderBy(x => x.SerialNo).ToListAsync();

                foreach (var item in modules)
                {
                    var modulParentMenu = await _context.Menus.Where(x => x.IsParent == true && x.SecModuleId == item.Id).ToListAsync();
                    if (modulParentMenu.Count > 0)
                    {
                        foreach (var parents in modulParentMenu)
                        {
                            var childMenus = await (from m in _context.Menus
                                                    join mp in _context.MenuPermissions on m.Id equals mp.SecMenuId
                                                    join r in _context.UserRoles on mp.SecRoleId equals r.RoleId
                                                    where (mp.SecRoleId == roleId && m.IsActive == true && m.SecModuleId == parents.SecModuleId && m.IsParent == false && m.ParentMenuId == parents.Id && mp.IsActive == true)
                                                    select new ChildMenuViewModel
                                                    {
                                                        label = m.Title,
                                                        labelBn = m.TitleBn,
                                                        icon = m.Icon,
                                                        routerLink = m.Link,
                                                        ParentSerialNo = m.ParentSerialNo,
                                                        ChildSerialNo = m.ChildSerialNo
                                                    }).Distinct().OrderBy(x => x.ChildSerialNo).ToListAsync();

                            if (childMenus != null && childMenus.Count > 0)
                            {
                                var UserMenuobj = new UserMenuViewModel();
                                UserMenuobj.label = item.Name;
                                UserMenuobj.labelBn = item.NameBn;
                                UserMenuobj.Icon = item.Icon;
                                UserMenuobj.items.AddRange(childMenus);
                                parentList.Add(UserMenuobj);
                            }
                        }
                        if (parentList.Count > 0)
                        {
                            var objduls = new ModuleViewModel();
                            objduls.label = item.Name;
                            objduls.labelBn = item.NameBn;
                            objduls.Icon = item.Icon;
                            objduls.items.AddRange(parentList);
                            moduleList.Add(objduls);
                            parentList = new List<UserMenuViewModel>();
                        }
                    }
                }
                //}
                return moduleList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }

}
