using FridgeManager.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FridgeManager.DAL.DTO.Fridge
{
    public class FridgeDTO
    {
        public Guid FridgeId { get; set; }
        public string Name { get; set; }
        public string OwnerName { get; set; }

        public FridgeModel FridgeModel { get; set; }
    }
}
