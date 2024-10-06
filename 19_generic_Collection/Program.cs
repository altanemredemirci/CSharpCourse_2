using System.Collections;

namespace _19_Generic_Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // GENERIC LIST
            //List<int> list = new List<int>();
            //list.Add(11);
            //list.Add(12);

            //foreach (int item in list)
            //{
            //    Console.WriteLine(item);
            //}


            //STACK Koleksiyonun LIFO(last in first out)
            //Stack<string> stack = new Stack<string>();
            //stack.Push("Altan");
            //stack.Push("Emre");
            //stack.Push("Şerafettin");
            //stack.Push("Mehmet");

            //foreach (string item in stack)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(stack.Pop()); // Son elemanı Dışarı çıkarır
            //Console.WriteLine(stack.Peek()); // Sadece son elemanı ekrana yazar.
            //Console.WriteLine(stack.Peek());


            Queue<int> ints = new Queue<int>();
            ints.Enqueue(11);
            ints.Enqueue(12);
            ints.Enqueue(13);

            //Console.WriteLine(ints.Dequeue()); // Pop() gibi çalışır.
            //Console.WriteLine(ints.Dequeue());
            Console.WriteLine(ints.Peek());
            Console.WriteLine(ints.Peek());

        }
    }
}
