using Domain.DbModels.Common;
using Infrastructure.Persistence.Repositories.Interfaces.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Implementations.Common
{
    public class UpazilaService : IUpazilaService
    {
        private readonly IUpazilaRepository repository;

        public UpazilaService(IUpazilaRepository repository)
        {
            this.repository = repository;
        }

        public async Task<Upazila> AddUpazilaAsync(Upazila objUpazila)
        {
            return await repository.AddAsync(objUpazila);
        }

        public async Task UpdateUpazilaAsync(Upazila objUpazila)
        {
            await repository.UpdateAsync(objUpazila);
        }

        public async Task<IEnumerable<Upazila>> GetAllUpazilaAsync()
        {
            return await repository.GetAllAsync();
        }

        public async Task<Upazila> GetUpazilaByIdAsync(Upazila objUpazila)
        {
            return await repository.GetByIdAsync(objUpazila.Id);
        }
    }

}
