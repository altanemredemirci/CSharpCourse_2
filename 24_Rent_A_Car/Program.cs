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
 - 3 Farkl� ili�ki t�r� vard�r.
    - 1-1 OneToOne
    - 1-N OneToMany
    - N-N ManyToMany

Araba ve Marka classlar� olu�turuldu.
Aralar�ndaki 1-N ili�ki tan�mland�.
DataContext class� olu�turuldu.
Gerekli paketler kuruldu. //EntityFrameworkCore,EFSqlServer,EFDesign
DatabaseConnecitonString OnConfiguring() alt�nda yaz�ld�.
Tablo olacak classlar DbSet ile tan�mland�.
migration al�nd�. dotnet ef migrations add CreateDatabase
database olu�turuldu. dotnet ef database update
 */