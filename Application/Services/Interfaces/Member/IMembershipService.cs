using Domain.DbModels.Common;
using Domain.DbModels.Member;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Implementations.Member
{
    public interface IMembershipService
    {
        Task<Membership> AddMembershipAsync(Membership objMembership);
        Task UpdateMembershipAsync(Membership objMembership);

        Task<IEnumerable<Membership>> GetAllMembershipAsync();
        Task<Membership> GetMembershipByIdAsync(Membership objMembership);
    }
}
