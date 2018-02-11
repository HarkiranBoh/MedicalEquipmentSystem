using MedicalEquipmentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalEquipmentSystem.Services
{
   public interface IProductData
    {

        IEnumerable<Product> GetAll();
        Product Get(int id);
    }
}
