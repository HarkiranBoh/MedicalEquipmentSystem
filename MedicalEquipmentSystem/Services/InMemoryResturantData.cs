using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MedicalEquipmentSystem.Models;

namespace MedicalEquipmentSystem.Services
{
    public class InMemoryResturantData : IResturantData
    {
        public InMemoryResturantData()
        {
            _restaurants = new List<Resturant>

            {
                new Resturant  { id = 1, Name ="One" },
                new Resturant  { id = 2, Name = "Two" },
                new Resturant  { id = 3, Name = "Three" }
            };
        }

        public IEnumerable<Resturant> GetAll()
        {
            return _restaurants.OrderBy(r => r.Name);
        }

        public Resturant Get(int id)
        {
            return _restaurants.FirstOrDefault(r => r.id == id);
        }

        List<Resturant> _restaurants;
    }
}
