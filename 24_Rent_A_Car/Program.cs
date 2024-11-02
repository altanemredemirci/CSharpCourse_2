namespace _24_Rent_A_Car
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
        }
    }
}

/*
 ******** RELATIONS *********
 - 3 Farklý iliþki türü vardýr.
    - 1-1 OneToOne
    - 1-N OneToMany
    - N-N ManyToMany

Araba ve Marka classlarý oluþturuldu.
Aralarýndaki 1-N iliþki tanýmlandý.
DataContext classý oluþturuldu.
Gerekli paketler kuruldu. //EntityFrameworkCore,EFSqlServer,EFDesign
DatabaseConnecitonString OnConfiguring() altýnda yazýldý.
Tablo olacak classlar DbSet ile tanýmlandý.
migration alýndý. dotnet ef migrations add CreateDatabase
database oluþturuldu. dotnet ef database update
 */