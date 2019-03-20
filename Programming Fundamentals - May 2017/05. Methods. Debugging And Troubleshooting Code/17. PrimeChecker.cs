using System;

namespace PrimeChecker
{
    class Program
    {
        static bool IsPrime(long number)
        {
            if (number == 0 || number == 1)
                return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number != i && number % i == 0)
                    return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(IsPrime(long.Parse(Console.ReadLine())));
        }
    }
}
