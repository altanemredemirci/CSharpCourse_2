
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_EntityFramework
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=202-HOCAPC\\SQLDERS; Database=ETicaret; Integrated Security=true; TrustServerCertificate=true");
        }

        // Database altında tablo olmasını istediğimiz her class DbSet<> tipinde tanımlanır.
        public DbSet<Product> Products { get; set; }
    }

}
    

