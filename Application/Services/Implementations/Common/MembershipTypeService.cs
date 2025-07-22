using Domain.DbModels.Common;
using Infrastructure.Persistence.Repositories.Interfaces.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Implementations.Common
{
    public class MembershipTypeService : IMembershipTypeService
    {
        private readonly IMembershipTypeRepository repository;

        public MembershipTypeService(IMembershipTypeRepository repository)
        {
            this.repository = repository;
        }

        public async Task<MembershipType> AddMembershipTypeAsync(MembershipType objMembershipType)
        {
            return await repository.AddAsync(objMembershipType);
        }

        public async Task UpdateMembershipTypeAsync(MembershipType objMembershipType)
        {
            await repository.UpdateAsync(objMembershipType);
        }

        public async Task<IEnumerable<MembershipType>> GetAllMembershipTypeAsync()
        {
            return await repository.GetAllAsync();
        }

        public async Task<MembershipType> GetMembershipTypeByIdAsync(MembershipType objMembershipType)
        {
            return await repository.GetByIdAsync(objMembershipType.Id);
        }
    }

}
