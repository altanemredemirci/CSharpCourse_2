namespace _23_EntityFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //******* ENTITY FRAMEWORK - EF **********
            /*
            .Net tarafında kullanılan en popüler Micro ORM aracıdır.
            Micro ORM (Object Relation Mapping): Projede tanımlı nesne yapılarının aralarındaki ilişkiyi tanımlar.
            C# tarafından gönderilen bir sorgunun veritabanına gidip dönmesi - result 631ms zaman alır.
            Ado.net e göre çok yavaştır çünkü alt yapısı Ado.Net'dir ama yazılımı ve kullanımı çok daha basittir.

             EF Çeşitleri:
                 1-CodeFirst **
                 2-DatabaseFirst(DBFirst)
                 3-ModelFirst
                 4-CodeFirst(Varolan Database)


             *** Ado.Net ***
                 * Projede kullanılacak class'lar tanımlanır.(Visual Studio)
                 * Projedeki dataları tutacak veritabanı oluşturulur.(Management Studio)
                 * Projedeki her class'ın aynı isimle tablosu oluşturulur.
                 * Class daki property'ler tabloya kolon olarak verilir.
                 * Tablonun kolonlarını tanımlarken datasını tuttuğu class'ın property data type larına uygun veritipleri seçilir.
                 * Database Connection(SqlConnection) tanımlanır.

             *** EF-Code First ***
                 * Tools->Nuget Package Manager -> Manage nuget package for soluiton -> Browse -> Entity Framework Core yüklenir.
                 * Projede kullanılacak class'lar yazılır.
                 * EF paketi ile gelen DbContext classının projede SQL bağlantısını tanımlayacak,yönetecek class'a kalıtım alınır.
                 * DataContext class altında onConfiguring metodu override edilir ve Sql bağlantı cümlesi tanımlarnı.
                 * Database altında tablo olmasını istediğimiz her class DbSet<> tipinde tanımlanır.
                 * Proje üzerinde sağ tıkla -> open in terminal -> 'dotnet ef migrations add [MigrationName]' komudu yazılır. dotnet ef migrations add CreateDatabase
                 * Her migration kendisinden önce alınan migration'dan farkını tutar.
                 * Terminal alanına 'dotnet ef database update' komutu yazılarak çalıştırılır.


            Tools->Package Manager Console -> Add-Migration CreateDatabase
                                              Update-Database
             */

            Product p = new Product()
            {
                Name = "Etek",
                Stock = 10,
                Price = 1000,
                CategoryName = "Giyim"
            };

            Product p2 = new Product();

            p2.Name = "Laptop";
            p2.Stock = 100;
            p2.Price = 70000;
            p2.CategoryName = "Elektronik";


            Execute execute = new Execute();
            execute.Insert(p);
            execute.Insert(p2);
        }
    }
}
