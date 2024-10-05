namespace _19_Generic_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Onur YAĞIZ
            new BaseClass<int>().GenericProperty = 5;
            new BaseClass<string>().GenericProperty = "10";
            new ChildClass().GenericProperty = 10;
            new ChildClass2<string>().GenericProperty = "deneme";
            new ChildClass2<DateTime>().GenericProperty = DateTime.Now;
            new ChildClass3<char>().GenericProperty = "Deneme";
            new ChildClass3<DateTime>().GenericProperty = "Deneme3";





            ChildClass childClass = new ChildClass();
            childClass.GenericProperty = 0;


            ChildClass2<double> childClass2 = new ChildClass2<double>();
            childClass2.GenericProperty = 15.5;


            ChildClass3<double> childClass3 = new ChildClass3<double>();
            childClass3.GenericProperty = "Altan Emre";
            childClass3.Price = 15.5;
            childClass3.Stock = 500.5;

        }
    }

    class BaseClass<T>
    {
        public T GenericProperty { get; set; }
    }

    //Kalıtım yapılırken de Generic sınıfa ait generic parametrelere değerler gönderilmek zorunludur!
    class ChildClass : BaseClass<int>
    {
        //BaseClass'daki GenericProperty int tipinde buraya gelecek
    }

    //ChildClass2 tipinden nesne üretilirken T yerine gönderilen tip kalıtım alınan BaseClass'a gönderilerek BaseClass'ın da bu tipe göre çalışması sağlanabiir. 
    class ChildClass2<T> : BaseClass<T>
    {
        //Nesne üretilirken T yerine int gönderilmişse BaseClass'daki GenericProperty int tipinde çalışır.
    }

    //ChildClass3 generic olmasına rağmen BaseClass'ın her daim string tipinde kalıtım vermesi aşağıdaki şekilde sağlanabilir. GenericProperty her daim string olarak gelir.
    class ChildClass3<T> : BaseClass<string>
    {
        public T Price { get; set; }
        public T Stock { get; set; }
    }


}
