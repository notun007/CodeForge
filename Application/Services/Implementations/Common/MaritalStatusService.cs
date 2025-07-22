using Domain.DbModels.Common;
using Infrastructure.Persistence.Repositories.Interfaces.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Implementations.Common
{
    public class MaritalStatusService : IMaritalStatusService
    {
        private readonly IMaritalStatusRepository repository;

        public MaritalStatusService(IMaritalStatusRepository repository)
        {
            this.repository = repository;
        }
               
        public async Task<MaritalStatus> AddMaritalStatusAsync(MaritalStatus objMaritalStatus)
        {
            return await repository.AddAsync(objMaritalStatus);
        }

        public async Task UpdateMaritalStatusAsync(MaritalStatus objMaritalStatus)
        {
            await repository.UpdateAsync(objMaritalStatus);
        }

        public async Task<IEnumerable<MaritalStatus>> GetAllMaritalStatusAsync()
        {
            return await repository.GetAllAsync();
        }

        public async Task<MaritalStatus> GetMaritalStatusByIdAsync(MaritalStatus objMaritalStatus)
        {
            return await repository.GetByIdAsync(objMaritalStatus.Id);
        }
    }

}
