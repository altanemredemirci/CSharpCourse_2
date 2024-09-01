namespace _12_Methods_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] sayilar = { 12, 1, 3, 5, 2, 14, 12, 45, 4, 6 };

            //Console.WriteLine(sayilar.Max());
            //Console.WriteLine(sayilar.Min());

            ////Max ve Min Metot tanımı

            //int enBuyuk = sayilar[0];
            //int enKucuk = sayilar[0];

            //foreach (int item in sayilar)
            //{
            //    if (item > enBuyuk)
            //        enBuyuk = item;

            //    if (item < enKucuk)
            //        enKucuk = item;
            //}

           
            //Console.WriteLine(enBuyuk);
            //Console.WriteLine(enKucuk);

            //Ödev: static void KelimeSayilariniGoster isminde bir metod tanımlayın ve parametresi string metin olsun. Bu metod string türünde verilen metnin içindeki kelimeleri ayrıştırarak hangi kelimenin ne kaçkez tekrar ettiğini ekranda göstersin.


            string metin = "Pohpohçu pinti profesör pofur pofur pofur pofurdayarak hınçla tunç çanak içinde punç içip pülverizatör prospektüsünü papaz balığı biblosunun berisindeki papatya buketinin bu yanına bıraktıktan sonra palas pandıras Pülümürlü Pötürgelinin getirdiği pörsük pötikare pöstekiyi Paluluların pıtırcık pazarında partenojenez pasaparolasını, pertavsız pervasız pervaz peyzajını ve peronospora pestenkerani pestilini posbıyıklı pisboğaz pedagoga Pınarbaşı'nda beş peşkirle peş peşe peşin peşkeş çekti, sonra da pılını pırtını topladı.";

            KelimeSayilariniGoster(metin);
        }

        static void KelimeSayilariniGoster(string metin)
        {
            char[] ayracKarakterler = { ' ', ',', '.', '!', '?', ';', ':' };
            string[] kelimeler = metin.ToLower().Split(ayracKarakterler, StringSplitOptions.RemoveEmptyEntries);

            string[] benzersizKelimeler = new string[kelimeler.Length];
            int[] kelimeSayilari = new int[kelimeler.Length];

            int benzersizIndex = 0;

            foreach (var kelime in kelimeler)
            {
                bool bulundu = false;
                for (int i = 0; i < benzersizIndex; i++)
                {
                    if (benzersizKelimeler[i] == kelime)
                    {
                        kelimeSayilari[i]++;
                        bulundu = true;
                        break;
                    }
                }
                if (!bulundu)
                {
                    benzersizKelimeler[benzersizIndex] = kelime;
                    kelimeSayilari[benzersizIndex] = 1;
                    benzersizIndex++;
                }

            }

            Array.Sort(kelimeSayilari, benzersizKelimeler, 0, benzersizIndex);
            Array.Reverse(kelimeSayilari, 0, benzersizIndex);
            Array.Reverse(benzersizKelimeler, 0, benzersizIndex);

            Console.WriteLine("Metindeki kelime sayıları (En çok geçenlerden başlayarak):");
            for (int i = 0; i < benzersizIndex; i++)
            {
                Console.WriteLine($"{benzersizKelimeler[i]}' kelimesi {kelimeSayilari[i]} kez geçiyor.");
            }

        }
    }
}
