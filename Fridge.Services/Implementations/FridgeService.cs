using FridgeManager.DAL;
using FridgeManager.DAL.DTO.Fridge;
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

        public void Create(FridgeDTO dto)
        {
            var isAlreadyExist = 
                _context.Fridges.SingleOrDefault(x=>x.Name == dto.Name && x.OwnerName == dto.OwnerName);

            if (isAlreadyExist is null)
            {
                Fridge newFridge = new Fridge
                {
                    Name = dto.Name,
                    OwnerName = dto.OwnerName,
                };

                _context.Fridges.Add(newFridge);
                _context.SaveChanges();
            }

        }

        public void Delete(int id)
        {
           var fridge =  _context.Fridges.SingleOrDefault(x=>x.Id==id);

            if (fridge != null)
            {
                _context.Fridges.Remove(fridge);
                _context.SaveChanges();
            }

        }

        public List<FridgeIndexDTO> GetAll()
        {
            return _context.Fridges.Select(p=> new FridgeIndexDTO
            {
                Id = p.Id,
                Name=p.Name,
                OwnerName =p.OwnerName
            }).ToList();
        }

        public Fridge GetById(int id)
        {
            return _context.Fridges.FirstOrDefault(x => x.Id == id);
        }

        public void Update(int id, FridgeDTO dto)
        {
            var existedFridge = _context.Fridges.SingleOrDefault(x => x.Id== id);
            
            existedFridge.Name = dto.Name;
            existedFridge.OwnerName = dto.OwnerName;

            _context.SaveChanges();
        }
    }
}
