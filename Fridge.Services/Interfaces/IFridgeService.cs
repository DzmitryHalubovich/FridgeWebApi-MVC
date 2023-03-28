using FridgeManager.DAL;

namespace FridgeManager.Services.Interfaces
{
    public interface IFridgeService
    {
        public List<Fridge> GetAll();
        public Fridge GetById(int id);
    }
}
