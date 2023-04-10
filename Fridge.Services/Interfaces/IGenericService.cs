using FridgeManager.DAL;
using FridgeManager.DAL.DTO.Fridge;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FridgeManager.Services.Interfaces
{
    public interface IGenericService<T> where T : class
    {
        public Task<List<FridgeIndexDTO>> GetAllAsync();
        public Task<Fridge> GetByIdAsync(int id);
        public Task CreateAsync(FridgeDTO dto);
        public Task UpdateAsync(int id, FridgeDTO dto);
        public Task DeleteAsync(int dto);
    }
}
