using Application.Services.Interfaces.Common;
using Domain.DbModels.Common;
using Infrastructure.Persistence.Repositories.Interfaces.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Implementations.Common
{

    public class PaymentMethodService : IPaymentMethodService
    {
        private readonly IPaymentMethodRepository repository;

        public PaymentMethodService(IPaymentMethodRepository repository)
        {
            this.repository = repository;
        }

        public async Task<PaymentMethod> AddPaymentMethodAsync(PaymentMethod objPaymentMethod)
        {
            return await repository.AddAsync(objPaymentMethod);
        }

        public async Task UpdatePaymentMethodAsync(PaymentMethod objPaymentMethod)
        {
            await repository.UpdateAsync(objPaymentMethod);
        }

        public async Task<IEnumerable<PaymentMethod>> GetAllPaymentMethodAsync()
        {
            return await repository.GetAllAsync();
        }

        public async Task<PaymentMethod> GetPaymentMethodByIdAsync(PaymentMethod objPaymentMethod)
        {
            return await repository.GetByIdAsync(objPaymentMethod.Id);
        }
    }

}
