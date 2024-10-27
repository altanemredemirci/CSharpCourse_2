using _23_EntityFramework_1_DBFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace _23_EntityFramework_1_DBFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* ********* DATABASE FIRST **********
             * Microsoft.EntityFrameworkCore,Microsoft.EntityFrameworkCore.SqlServer,Microsoft.EntityFrameworkCore.Tools,Microsoft.EntityFrameworkCore.Design paketlerini kur.
             * Tools -> Nuget Package Manager -> Package Manager Console 
             'Scaffold-DbContext "Server=.\SQLDERS;Database=Northwind; uid=sa; pwd=1; Trusted_Connection=True; TrustServerCertificate=true;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models ' kodunu çalıştır.
             
             */

            //OneToOne, OneToMany, ManyToMany


            NorthwindContext db = new NorthwindContext();

            #region Ürün Adı Chai olan ürünün bilgileri

            //Birden fazla adı Chai olan ürün gelebileceği için mutlaka product tipinde bir liste tanımlanmalı
            //List<Product> p = db.Products.Where(i => i.ProductName == "Chai").ToList();

            //Product p = db.Products.Where(i => i.ProductName == "Chai").FirstOrDefault();

            //Product p = db.Products.FirstOrDefault(i => i.ProductName == "Chai");

            //Product p = db.Products.Where(i => i.ProductName == "Chai").SingleOrDefault();

            #endregion

            #region Belirli bir catagory altındaki ürünler

            //var products = db.Products.Where(i => i.CategoryId == 1).ToList();
            //List<Product> products2 = db.Products.Where(i => i.CategoryId == 1).ToList();

            #endregion

            #region Ürünleri kategori adları ile getir

            var products = db.Products.Include(i=> i.Category).ToList();


            #endregion


        }
    }
}
