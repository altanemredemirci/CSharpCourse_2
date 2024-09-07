using System.Collections;

namespace _13_ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* ******** ARRAYLIST *********
            Dizilerde, veritipi ve eleman sayısı belirtme zorunluluğu var.
            int[] diziAdi = new int[boyut] 
             
            ArrayList ise, bir veritipi zorunluluğu olmayan ve istenildiği kadar eleman eklenebilen bir koleksiyon yapısıdır.
            ArrayList de karışık veri tipleri tutabildiği için her değeri OBJECT olarak tutar.

            Tanımlarken "using System.Collections" kütüphanesi eklenmelidir.
             
             */

            #region Boş ArrayList Tanımı
            //ArrayList arrayList = new ArrayList();

            //arrayList.Add(1);
            //arrayList.Add("Altan");
            //arrayList.Add(150.5);
            //arrayList.Add('h');
            //arrayList.Add(45.6f);
            //arrayList.Add(100.5m);
            #endregion


            #region ArrayList Yazdırma
            //for (int i = 0; i < arrayList.Count; i++)
            //{
            //    Console.WriteLine(arrayList[i]);
            //}

            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion


            #region Dolu ArrayList Tanımı
            //ArrayList arrayList2 = new ArrayList() { 12, "Emre", 15.5 };

            #endregion


            #region Capacity and Count

            //ArrayList sayilar = new ArrayList() {1,2,3,4,5,6,7,8,9,1,2,3,4,5,6,7,8};
            //Console.WriteLine("COUNT:"+sayilar.Count);
            //Console.WriteLine("CAPACITY:"+sayilar.Capacity);

            #endregion


            #region ArrayList Methods

            //ArrayList sayilar = new ArrayList() { 1,2,3};
            //sayilar.Add(4);


            //Çoklu veri ekleme
            //sayilar.AddRange(new ArrayList() { 5, 6, 7 }); //collections
            //sayilar.AddRange(new int[]{8,9 });

            //ArrayList sayilar2 = new ArrayList(){10,11};
            //sayilar.AddRange(sayilar2);




            //İstenilen Index'e değer ekleme
            //sayilar.Insert(2, 5);




            //Koleksiyonun bütün elemanları siler.
            //sayilar.Clear();


            //Koleksiyon içinde değerleri index değerine göre ters sıralar.
            //sayilar.Reverse();
            //sayilar.Reverse(1,2);


            //Koleksiyondan eleman silme
            //ArrayList sehirler = new ArrayList() { "İstanbul", "Adana", "Mersin", "Hatay", "İzmir" };

            //sehirler.Remove("Adana"); //değer üzerinden siler.
            //sehirler.RemoveAt(2); // index değeri üzerinden siler.


            //sehirler.RemoveRange(1, 2); // index,silinecekElemanSayısı



            //IndexOF:Koleksiyon içerisinde istenilen elemanın ILK INDEX NUMARASINI döndürür.
            //ArrayList sehirler = new ArrayList() { "İstanbul", "Adana", "Mersin", "Hatay", "İzmir" };

            //Console.WriteLine(sehirler.IndexOf("Adana"));


            //LastIndexOF:Koleksiyon içerisinde istenilen elemanın SON INDEX NUMARASINI döndürür.
            //ArrayList sehirler = new ArrayList() { "İstanbul", "Adana", "Mersin", "Hatay", "Adana", "İzmir", "Adana" };

            //int index = sehirler.LastIndexOf("Adana");
            //int indexx = sehirler.LastIndexOf("Adana",3); // 3. indexten geriye doğru arar.
            //Console.WriteLine(index);


            //int index2 = sehirler.IndexOf("Adana", 2);
            //Console.WriteLine(index2);


            //ArrayList sayilar2 = new ArrayList();
            //sayilar2 = (ArrayList) sayilar.Clone(); //Boxing

            //sayilar.Add(5);


            //foreach (var item in sayilar)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("***********");
            //foreach (var item in sayilar2)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
        }
    }
}
