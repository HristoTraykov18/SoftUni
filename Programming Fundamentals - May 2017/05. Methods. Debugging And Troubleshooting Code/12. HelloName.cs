using System;

namespace HelloName
{
    class Program
    {
        static void Hello(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Hello(name);
        }
    }
}
