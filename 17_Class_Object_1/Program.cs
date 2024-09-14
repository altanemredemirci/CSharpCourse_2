namespace _17_Class_Object_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcı Yapısı var (username,password,name,surname,email)
            // Listeye 3 Adet kullanıcı kaydı yapınız.
            List<User> users = new List<User>();

            #region Listeye Ekleme
            User u1 = new User();
            u1.username = "Ahmet123";
            u1.password = "asd1";
            u1.name = "Ahmet";
            u1.surname = "Yıl";
            u1.email = "ahmetyil11199292@hotmail.com";

            User u2 = new User();
            u2.username = "Mehmet312";
            u2.password = "123as";
            u2.name = "Mehmet";
            u2.surname = "Yılmaz";
            u2.email = "mehmetyilmaz11199292@hotmail.com";

            User u3 = new User()
            {
                username = "ahmet132123",
                password = "asd1",
                name = "Ahmet",
                surname = "Yıldız",
                email = "ahmetyildiz11199292@hotmail.com"
            };


            //users.Add(u1);
            //users.Add(u2);
            //users.Add(u3);

            users.AddRange(new List<User> { u1, u2, u3 });


            //User u4 = new User();
            //Console.WriteLine("Adınız:");
            //u4.name = Console.ReadLine();

            //Console.WriteLine("Soyadınız:");
            //u4.surname = Console.ReadLine();

            //Console.WriteLine("Kullanıcı Adı:");
            //u4.username = Console.ReadLine();

            //Console.WriteLine("Email:");
            //u4.email = Console.ReadLine();

            //Console.WriteLine("Password:");
            //u4.password = Console.ReadLine();

            //users.Add(u4);
            #endregion


            //User.CreateUser(users);
            //User.CreateUser(users);

            //User. Create,List,Email göre find

            //User.ListUser(users);

            //Console.WriteLine("\n\n");
            //User.FindUser(users);



            //NonStatic Meethod 
            //User user = new User();
            //user.CreateUser2(users);


            //Static User Döndüren Metot

            //var kullanici = User.CreateUser3();

            //users.Add(kullanici);

            //users.Add(User.CreateUser3());





            User u4 = new User()
            {
                username = "ahmet132123",
                password = "asd1",
                name = "Ahmet",
                surname = "Yıldız",
                email = "ahmetyildiz11199292@hotmail.com"
            };



            List<User> kullanicilar = new List<User>()
            {
                new User{username = "ahmet132123",password = "asd1",name = "Ahmet",surname = "Yıldız",email = "ahmetyildiz11199292@hotmail.com"},
                new User{username = "ahmet132123",password = "asd1",name = "Ahmet",surname = "Yıldız",email = "ahmetyildiz11199292@hotmail.com"},
                new User{username = "ahmet132123",password = "asd1",name = "Ahmet",surname = "Yıldız",email = "ahmetyildiz11199292@hotmail.com"}
            };
        }

       
    }
}
