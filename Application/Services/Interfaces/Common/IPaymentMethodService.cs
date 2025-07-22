using Domain.DbModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Interfaces.Common
{
    public interface IPaymentMethodService
    {
        Task<PaymentMethod> AddPaymentMethodAsync(PaymentMethod objPaymentMethod);
        Task UpdatePaymentMethodAsync(PaymentMethod objPaymentMethod);

        Task<IEnumerable<PaymentMethod>> GetAllPaymentMethodAsync();
        Task<PaymentMethod> GetPaymentMethodByIdAsync(PaymentMethod objPaymentMethod);
    }
}
