using MedicalEquipmentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalEquipmentSystem.ViewModels
{
    public class ProductViewModel
    {
        public IEnumerable<Product> product { get; set; }
        public string Name { get; set; }
        public string CurrentMessage { get; set; }

    }
}
