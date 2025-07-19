using Application.Services.Interfaces.Common;
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
            //_mapper = mapper;
        }
    }
}
