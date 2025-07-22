using Domain.DbModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Implementations.Common
{
    public interface IMobileBankingService
    {
        Task<MobileBanking> AddMobileBankingAsync(MobileBanking objMobileBanking);
        Task UpdateMobileBankingAsync(MobileBanking objMobileBanking);

        Task<IEnumerable<MobileBanking>> GetAllMobileBankingAsync();
        Task<MobileBanking> GetMobileBankingByIdAsync(MobileBanking objMobileBanking);
    }
}
