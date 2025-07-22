using Domain.DbModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Implementations.Common
{
    public interface IMembershipTypeService
    {
        Task<MembershipType> AddMembershipTypeAsync(MembershipType objMembershipType);
        Task UpdateMembershipTypeAsync(MembershipType objMembershipType);

        Task<IEnumerable<MembershipType>> GetAllMembershipTypeAsync();
        Task<MembershipType> GetMembershipTypeByIdAsync(MembershipType objMembershipType);
    }
}
