using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MedicalEquipmentSystem.Models;

namespace MedicalEquipmentSystem.ViewModels
{
    public class HomeIndexViewModel
    {
        public IEnumerable<Resturant> restaurant { get; set; }
        public string CurrentMessage { get; set; }
    }
}
