namespace _16_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
             *  ARRAY: Veritipi ve alacağı eleman sayısı belirlenmelidir.
                 veritipi[] diziAdi = new veritipi[uzunluk]

             *  ARRAYLIST: Veritipi ve elaman sayısı sınırlandırma yok.
                 ArrayList arrayListAdi = new ArrayList();

             *  LIST: Veritipi belirli, eleman sayısı belirsiz.
                List<string> ogrenciler = new List<string>();
                
             */


            List<string> ogrenciler = new List<string>();

            //Eleman Ekleme
            ogrenciler.Add("Altan Emre");
            ogrenciler.Add("Zehra");
            ogrenciler.Add("Ahmet");
            ogrenciler.Add("Mehmet");
            ogrenciler.Add("Kemal");
            ogrenciler.Add("Kemalettin");
            ogrenciler.Add("Kenan");

            ogrenciler.Sort();


            //Eleman Silme
            //ogrenciler.Remove("Altan Emre");
            //ogrenciler.RemoveAt(0);


            //Console.WriteLine(ogrenciler.Capacity);
            //Console.WriteLine(ogrenciler.Count);


            //int index = ogrenciler.BinarySearch("Altan Emre");
            //int index2 = ogrenciler.BinarySearch("Zehra");

            //Console.WriteLine(index);
            //Console.WriteLine(index2);

            foreach (string item in ogrenciler)
            {
                Console.WriteLine(item);
            }  

        }
    }
}
