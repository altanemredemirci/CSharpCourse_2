namespace _22_Ado.Net_ExecuteReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Execute execute = new Execute();
            var categories = execute.CategoryList();

            foreach (var item in categories)
            {
                Console.WriteLine(item.CategoryName);
            }

        }
    }
}
