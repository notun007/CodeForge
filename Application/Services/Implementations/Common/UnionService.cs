using Domain.DbModels.Common;
using Infrastructure.Persistence.Repositories.Interfaces.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Implementations.Common
{
    public class UnionService : IUnionService
    {
        private readonly IUnionRepository repository;

        public UnionService(IUnionRepository repository)
        {
            this.repository = repository;
        }

        public async Task<Union> AddUnionAsync(Union objUnion)
        {
            return await repository.AddAsync(objUnion);
        }

        public async Task UpdateUnionAsync(Union objUnion)
        {
            await repository.UpdateAsync(objUnion);
        }

        public async Task<IEnumerable<Union>> GetAllUnionAsync()
        {
            return await repository.GetAllAsync();
        }

        public async Task<Union> GetUnionByIdAsync(Union objUnion)
        {
            return await repository.GetByIdAsync(objUnion.Id);
        }
    }

}
