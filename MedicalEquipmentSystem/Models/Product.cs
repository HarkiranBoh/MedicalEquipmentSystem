using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalEquipmentSystem.Models
{
    public class Product
    {
        public int id { get; set; }

        [Display(Name = "Form")]
        [Required, MaxLength(80)]
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
    }

  
}
