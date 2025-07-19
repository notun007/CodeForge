using Application.Services.Interfaces.Common;
using Domain.DbModels.Common;
using Infrastructure.Persistence.Repositories.Interfaces;
using Infrastructure.Persistence.Repositories.Interfaces.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;


namespace Application.Services.Implementations.Common
{   
    public class CountryService: ICountryService
    {
        private readonly ICountryRepository repository;

        public CountryService(ICountryRepository repository)
        {
           this.repository = repository;
            //_mapper = mapper;
        }

        public async Task<Country> AddCountryAsync(Country objCountry)
        {
           return await repository.AddAsync(objCountry);
        }

        public async Task UpdateCountryAsync(Country objCountry)
        {
            await repository.UpdateAsync(objCountry);
        }

        public async Task<IEnumerable<Country>> GetAllCountryAsync()
        {
           return await repository.GetAllAsync();
        }

        public async Task<Country> GetCountryByIdAsync(Country objCountry)
        {
           return await repository.GetByIdAsync(objCountry.Id);
        }

        //public async Task<Response<ManageRolePermissionsDto>> ManagePermissionsAsync(string roleId, string permissionValue, int? pageNumber, int? pageSize)
        //{
        //    var role = await _roleManager.FindByIdAsync(roleId);
        //    if (role == null) return Response<ManageRolePermissionsDto>.Fail("No Role Exists");
        //    var roleClaims = await _roleManager.GetClaimsAsync(role);
        //    var allPermissions = _permissionHelper.GetAllPermissions();

        //    if (!string.IsNullOrWhiteSpace(permissionValue))
        //    {
        //        allPermissions = allPermissions.Where(x => x.Value.ToLower().Contains(permissionValue.Trim().ToLower())).ToList();
        //    }
        //    var managePermissionsClaim = new List<ManageClaimDto>();
        //    foreach (var permission in allPermissions)
        //    {
        //        var managePermissionClaim = new ManageClaimDto { Type = permission.Type, Value = permission.Value };
        //        if (roleClaims.Any(x => x.Value == permission.Value))
        //        {
        //            managePermissionClaim.Checked = true;
        //        }
        //        managePermissionsClaim.Add(managePermissionClaim);
        //    }
        //    var paginatedList = PaginatedList<ManageClaimDto>.CreateFromLinqQueryable(managePermissionsClaim.AsQueryable(),
        //        pageNumber ?? 1, pageSize ?? 12);
        //    var manageRolePermissionsDto = new ManageRolePermissionsDto
        //    {
        //        RoleId = roleId,
        //        RoleName = role.Name,
        //        PermissionValue = permissionValue,
        //        ManagePermissionsDto = paginatedList
        //    };
        //    return allPermissions.Count > 0
        //        ? Response<ManageRolePermissionsDto>.Success(manageRolePermissionsDto, "Successfully retrieved")
        //        : Response<ManageRolePermissionsDto>.Fail(
        //            $"No Permissions exists! Something is Wrong with Permission source file");
        //}
        //public async Task<Response<RoleIdentityDto>> ManageRoleClaimAsync(ManageRoleClaimDto manageRoleClaimDto)
        //{
        //    var roleById = await _roleManager.FindByIdAsync(manageRoleClaimDto.RoleId);
        //    var roleByName = await _roleManager.GetRoleAsync(manageRoleClaimDto.RoleName);
        //    if (roleById != roleByName)
        //        return Response<RoleIdentityDto>.Fail("Forbidden");
        //    var allClaims = await _roleManager.GetClaimsAsync(roleById);
        //    var claimExists =
        //        allClaims.Where(x => x.Type == manageRoleClaimDto.Type && x.Value == manageRoleClaimDto.Value).ToList();
        //    switch (manageRoleClaimDto.Checked)
        //    {
        //        case true when claimExists.Count == 0:
        //            await _roleManager.AddClaimAsync(roleById, new Claim(manageRoleClaimDto.Type, manageRoleClaimDto.Value));
        //            break;
        //        case false when claimExists.Count > 0:
        //            {
        //                foreach (var claim in claimExists)
        //                {
        //                    await _roleManager.RemoveClaimAsync(roleById, claim);
        //                }
        //                break;
        //            }
        //    }
        //    return Response<RoleIdentityDto>.Success(new RoleIdentityDto { RoleId = manageRoleClaimDto.RoleId },
        //        "Succeeded");

        //}
    }

}
