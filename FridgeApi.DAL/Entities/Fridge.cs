using FridgeManager.DAL.Entities;

namespace FridgeManager.DAL
{
    public class Fridge
    {
        public Guid FridgeId { get; set; }
        public string Name { get; set; }
        public string OwnerName { get; set; }
        public FridgeModel Model { get; set; }
    }
}
