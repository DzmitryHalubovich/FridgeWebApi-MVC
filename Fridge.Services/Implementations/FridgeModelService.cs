using FridgeManager.DAL;
using FridgeManager.DAL.DTO.Fridge;
using FridgeManager.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FridgeManager.Services.Implementations
{
    public class FridgeModelService : IFridgeModelService
    {
        public Task CreateAsync(FridgeDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid dto)
        {
            throw new NotImplementedException();
        }

        public Task<List<FridgeIndexDTO>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Fridge> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Guid id, FridgeDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
