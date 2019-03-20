using System;

namespace MaxMethod
{
    class Program
    {
        static long GetMax(int a, int b)
        {
            if (a > b)
                return a;
            return b;
        }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if (a > b)
                Console.WriteLine(GetMax(a, c));
            else
                Console.WriteLine(GetMax(b, c));
        }
    }
}
