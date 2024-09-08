namespace _17_Class_Object
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Eticaret => Products (name,price,image,stock)

            //Product p1 = new Product();
            //p1.price = 1000;
            //p1.name = "TShirt";
            //p1.image = "tshirt1.png";
            //p1.stock = 100;
            //p1.barcode = 1;


            //Product p2 = new Product();
            //p2.price = 2000;
            //p2.name = "Gömlek";
            //p2.image = "gomlek1.png";
            //p2.stock = 100;
            //p2.barcode = 2;


            //Product p3 = new Product();
            //p3.price = 2500;
            //p3.name = "Etek";
            //p3.image = "etek1.png";
            //p3.stock = 100;
            //p3.barcode = 3;


            List<Product> products = new List<Product>();
            //products.Add(p1);
            //products.Add(p2);
            //products.Add(p3);

            //foreach (Product product in products)
            //{
            //    Console.WriteLine($"Ad: {product.name} Fiyat: {product.price} Resim: {product.image}");
            //}


            //Console.WriteLine("Barkod Numarası:");
            //int barkod = Convert.ToInt32(Console.ReadLine());

            //foreach (Product product in products)
            //{
            //    if (product.barcode == barkod)
            //    {
            //        Console.WriteLine($"Ad: {product.name} Fiyat: {product.price} Resim: {product.image}");
            //    }               
            //}


            //***** List koleksiyonu:
           
        }
    }

    class Product
    {
        //Bir DataAccessModifier belirtilmez ise Class altındaki property lerin hepsi Default olarak PRIVATE erişime sahiptir.
        internal int barcode;
        internal string name;
        internal string image;
        internal double price;
        internal int stock;

        //void CreateProduct()
        //{
        //    ima
        //}

    }
    

}


