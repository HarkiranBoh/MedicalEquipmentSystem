using MedicalEquipmentSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalEquipmentSystem.Data
{
    public class MedicalSystemDbContext : DbContext
    {
        public MedicalSystemDbContext(DbContextOptions options)
            :base(options)
        {

        }
        public DbSet<Resturant> Resturants {get; set;}
    }
}
