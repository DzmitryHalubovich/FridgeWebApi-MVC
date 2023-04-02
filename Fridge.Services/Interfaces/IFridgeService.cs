using FridgeManager.DAL;
using FridgeManager.DAL.DTO.Fridge;

namespace FridgeManager.Services.Interfaces
{
    public interface IFridgeService
    {
        public List<FridgeIndexDTO> GetAll();
        public Fridge GetById(int id);

        public void Create(FridgeDTO dto);
        public void Update(int id, FridgeDTO dto);
        public void DeleteAsync(int dto);
    }
}
