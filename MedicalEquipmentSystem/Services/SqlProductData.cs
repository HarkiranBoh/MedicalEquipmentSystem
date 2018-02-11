using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MedicalEquipmentSystem.Models;
using MedicalEquipmentSystem.Data;

namespace MedicalEquipmentSystem.Services
{
    public class SqlProductData : IProductData
    {
        private MedicalSystemDbContext _context;

        public SqlProductData(MedicalSystemDbContext context)
        {
            _context = context;
        }
        public Product Add(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return product;
        }
        public Product Get(int id)
        {
            return _context.Products.FirstOrDefault(p => p.id == id);
        }

        public IEnumerable<Product> GetAll()
        {
            return _context.Products.OrderBy(p => p.Name);
        }
    }
}
