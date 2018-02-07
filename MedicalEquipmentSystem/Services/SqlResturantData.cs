using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MedicalEquipmentSystem.Models;
using MedicalEquipmentSystem.Data;

namespace MedicalEquipmentSystem.Services
{
    public class SqlResturantData : IResturantData
    {
        private MedicalSystemDbContext _context;

        public SqlResturantData(MedicalSystemDbContext context)
        {
            _context = context;
        }
        public Resturant Add(Resturant resturant)
        {
            _context.Resturants.Add(resturant);
            _context.SaveChanges();
            return resturant;
        }
        public Resturant Get(int id)
        {
            return _context.Resturants.FirstOrDefault(r => r.id == id);
        }

        public IEnumerable<Resturant> GetAll()
        {
            return _context.Resturants.OrderBy(r => r.Name);
        }
    }
}
