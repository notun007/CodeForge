using Domain.DbModels.Common;
using Infrastructure.Persistence.Repositories.Interfaces.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Implementations.Common
{
    public class DivisionService : IDivisionService
    {
        private readonly IDivisionRepository repository;

        public DivisionService(IDivisionRepository repository)
        {
            this.repository = repository;
        }

        public async Task<Division> AddDivisionAsync(Division objDivision)
        {
            return await repository.AddAsync(objDivision);
        }

        public async Task UpdateDivisionAsync(Division objDivision)
        {
            await repository.UpdateAsync(objDivision);
        }

        public async Task<IEnumerable<Division>> GetAllDivisionAsync()
        {
            return await repository.GetAllAsync();
        }

        public async Task<Division> GetDivisionByIdAsync(Division objDivision)
        {
            return await repository.GetByIdAsync(objDivision.Id);
        }
    }

}
