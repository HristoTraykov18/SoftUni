using System;

namespace SignOfInt
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintSign(n);
        }
        static void PrintSign(int n)
        {
            if (n < 0)
                Console.WriteLine($"The number {n} is negative.");
            else if (n == 0)
                Console.WriteLine($"The number {n} is zero.");
            else
                Console.WriteLine($"The number {n} is positive.");
        }
    }
}
