using Domain.DbModels.Common;
using Infrastructure.Persistence.Repositories.Interfaces.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Implementations.Common
{
    public class GenderService : IGenderService
    {
        private readonly IGenderRepository repository;

        public GenderService(IGenderRepository repository)
        {
            this.repository = repository;
        }

        public async Task<Gender> AddGenderAsync(Gender objGender)
        {
            return await repository.AddAsync(objGender);
        }

        public async Task UpdateGenderAsync(Gender objGender)
        {
            await repository.UpdateAsync(objGender);
        }

        public async Task<IEnumerable<Gender>> GetAllGenderAsync()
        {
            return await repository.GetAllAsync();
        }

        public async Task<Gender> GetGenderByIdAsync(Gender objGender)
        {
            return await repository.GetByIdAsync(objGender.Id);
        }
    }

}
