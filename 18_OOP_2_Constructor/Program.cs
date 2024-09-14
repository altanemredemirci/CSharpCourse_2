namespace _18_OOP_2_Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nesne Oluşturma Opsiyonu 


            //1. Boş Nesne Oluşturma
            User user = new User();

            //2.Dolu Nesne Oluşturma
            User user2 = new User("altanemre", "123");
        }
    }

    class User
    {
        string Username;
        string Password;

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public User()
        {
            
        }


    }
}
