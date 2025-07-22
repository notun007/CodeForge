using Domain.DbModels.Common;
using Infrastructure.Persistence.Repositories.Interfaces.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Implementations.Common
{
    public class MobileBankingService : IMobileBankingService
    {
        private readonly IMobileBankingRepository repository;

        public MobileBankingService(IMobileBankingRepository repository)
        {
            this.repository = repository;
        }

        public async Task<MobileBanking> AddMobileBankingAsync(MobileBanking objMobileBanking)
        {
            return await repository.AddAsync(objMobileBanking);
        }

        public async Task UpdateMobileBankingAsync(MobileBanking objMobileBanking)
        {
            await repository.UpdateAsync(objMobileBanking);
        }

        public async Task<IEnumerable<MobileBanking>> GetAllMobileBankingAsync()
        {
            return await repository.GetAllAsync();
        }

        public async Task<MobileBanking> GetMobileBankingByIdAsync(MobileBanking objMobileBanking)
        {
            return await repository.GetByIdAsync(objMobileBanking.Id);
        }
    }

}
