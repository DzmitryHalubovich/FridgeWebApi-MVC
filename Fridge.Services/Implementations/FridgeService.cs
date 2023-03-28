using FridgeManager.DAL;
using FridgeManager.Services.Interfaces;
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

        public List<Fridge> GetAll()
        {
            return _context.Fridges.ToList();
        }

        public Fridge GetById(int id)
        {
            return _context.Fridges.FirstOrDefault(x => x.Id == id);
        }
    }
}
