using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Class_Object_1
{
    internal class User
    {
        internal string username;
        internal string password;
        internal string name;
        internal string surname;
        internal string email;


        internal static void CreateUser(List<User> list)
        {

            User user = new User();
            Console.WriteLine("Adınız:");
            user.name = Console.ReadLine();

            Console.WriteLine("Soyadınız:");
            user.surname = Console.ReadLine();

            Console.WriteLine("Kullanıcı Adı:");
            user.username = Console.ReadLine();

            Console.WriteLine("Email:");
            user.email = Console.ReadLine();

            Console.WriteLine("Password:");
            user.password = Console.ReadLine();

            list.Add(user);
        }

        internal static void ListUser(List<User> users)
        {
            foreach (User user in users)
            {
                Console.WriteLine($"Kullanıcı adı:{user.username}, Name: {user.name}, Surname: {user.surname}, Email: {user.email}");
            }
        }

        internal static void FindUser(List<User> users)
        {
            Console.WriteLine("Email giriniz:");
            string email = Console.ReadLine();
            foreach (User user in users)
            {
                if (email == user.email)
                {
                    Console.WriteLine($"Kullanıcı adı:{user.username}, Name: {user.name}, Surname: {user.surname}, Email: {user.email}");
                }
            }
        }

        internal void CreateUser2(List<User> list) //NonStatic
        {
            Console.WriteLine("Adınız:");
            this.name = Console.ReadLine();

            Console.WriteLine("Soyadınız:");
            this.surname = Console.ReadLine();

            Console.WriteLine("Kullanıcı Adı:");
            this.username = Console.ReadLine();

            Console.WriteLine("Email:");
            this.email = Console.ReadLine();

            Console.WriteLine("Password:");
            this.password = Console.ReadLine();

            list.Add(this);
        }

        internal static User CreateUser3() 
        {
            User user = new User();
            Console.WriteLine("Adınız:");
            user.name = Console.ReadLine();

            Console.WriteLine("Soyadınız:");
            user.surname = Console.ReadLine();

            Console.WriteLine("Kullanıcı Adı:");
            user.username = Console.ReadLine();

            Console.WriteLine("Email:");
            user.email = Console.ReadLine();

            Console.WriteLine("Password:");
            user.password = Console.ReadLine();

            return user;
        }
    }
}
