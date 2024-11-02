using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_Rent_A_Car
{
    internal class DataContext:DbContext //EntityFrameworkCore paketi kuruldu. 
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //EntityFrameworkCore.SqlServer paketi kuruldu.
            optionsBuilder.UseSqlServer("Server=202-3\\SQLDERS; Database=RentACarDB; uid=sa; pwd=1; TrustServerCertificate=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Araba>()
                .Property(x => x.Model)
                .HasColumnType("varchar(50)");

            modelBuilder.Entity<Araba>()
                .Property(x => x.Vites)
                .HasMaxLength(30);

            modelBuilder.Entity<Araba>()
                .Property(x => x.Yakit)
                .HasColumnType("varchar(30)");
        }

        //Tablo olmasını istediğimiz classları DbSet ile tanımladık.
        public DbSet<Araba> Arabas { get; set; }
        public DbSet<Marka> Markas { get; set; }
        public DbSet<Kiralama> Kiralamas { get; set; }
        public DbSet<Musteri> Musteris { get; set; }


    }
}
