using FridgeManager.DAL;
using FridgeManager.DAL.DTO.Fridge;
using FridgeManager.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FridgeManager.Services.Implementations
{
    public class FridgeService : IFridgeService
    {
        private readonly AppDbContext _context;

        public FridgeService(AppDbContext context)
        {
            _context=context;
        }

        public async Task CreateAsync(FridgeDTO dto)
        {
            var isAlreadyExist = await
                _context.Fridges.SingleOrDefaultAsync(x=>x.Name == dto.Name && x.OwnerName == dto.OwnerName);

            if (isAlreadyExist is null)
            {
                Fridge newFridge = new Fridge
                {
                    Name = dto.Name,
                    OwnerName = dto.OwnerName,
                };

                await _context.Fridges.AddAsync(newFridge);
                await _context.SaveChangesAsync();
            }

        }

        public async Task DeleteAsync(int id)
        {
           var fridge = await _context.Fridges.SingleOrDefaultAsync(x=>x.Id==id);

            if (fridge != null)
            {
                _context.Fridges.Remove(fridge);
                await _context.SaveChangesAsync();
            }

        }

        public async Task<List<FridgeIndexDTO>> GetAllAsync()
        {
            return await _context.Fridges.Select(p=> new FridgeIndexDTO
            {
                Id = p.Id,
                Name=p.Name,
                OwnerName =p.OwnerName
            }).ToListAsync();
        }

        public async Task<Fridge> GetByIdAsync(int id)
        {
            return await _context.Fridges.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task UpdateAsync(int id, FridgeDTO dto)
        {
            var existedFridge = await _context.Fridges.SingleOrDefaultAsync(x => x.Id== id);
            
            existedFridge.Name = dto.Name;
            existedFridge.OwnerName = dto.OwnerName;

            await _context.SaveChangesAsync();
        }

    }
}
