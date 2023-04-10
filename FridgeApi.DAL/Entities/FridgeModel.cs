using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FridgeManager.DAL.Entities
{
    public class FridgeModel 
    {
        [Key]
        public Guid FridgeModelId { get; set; }

        [Required]
        public string Name { get; set; }

        public int? year { get; set; }


        public Guid FridgeId  { get; set; }
        public Fridge Fridge { get; set; }
    }
}
