using Domain.DbModels.Member;
using Infrastructure.Persistence.Repositories.Interfaces.Member;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Implementations.Member
{
    public class MembershipService : IMembershipService
    {
        private readonly IMembershipRepository repository;

        public MembershipService(IMembershipRepository repository)
        {
            this.repository = repository;
        }

        public async Task<Membership> AddMembershipAsync(Membership objMembership)
        {
            return await repository.AddAsync(objMembership);
        }

        public async Task UpdateMembershipAsync(Membership objMembership)
        {
            await repository.UpdateAsync(objMembership);
        }

        public async Task<IEnumerable<Membership>> GetAllMembershipAsync()
        {
            return await repository.GetAllAsync();
        }

        public async Task<Membership> GetMembershipByIdAsync(Membership objMembership)
        {
            return await repository.GetByIdAsync(objMembership);
        }
    }

}
