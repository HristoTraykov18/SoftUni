using System;
using System.Numerics;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger result = 1;
            uint input = uint.Parse(Console.ReadLine());
            for (int i = 1; i <= input; i++)
                result *= i;
            Console.WriteLine(result);
        }
    }
}
