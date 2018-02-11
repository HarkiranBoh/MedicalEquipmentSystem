using MedicalEquipmentSystem.Models;
using Microsoft.EntityFrameworkCore;


namespace MedicalEquipmentSystem.Data
{
    public class MedicalSystemDbContext : DbContext
    {
        public MedicalSystemDbContext(DbContextOptions options)
            :base(options)
        {

        }
        public DbSet<Resturant> Resturants {get; set;}
        public DbSet<Product> Products { get; set; }
    }
}
