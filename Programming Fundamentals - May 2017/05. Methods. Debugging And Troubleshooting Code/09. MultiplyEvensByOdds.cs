using System;

namespace MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMultipleOfEvensAndOdds(n));
        }
        public static int GetMultipleOfEvensAndOdds(int n)
        {
            int sumEvens = 0;
            int sumOdds = 0;
            while (Math.Abs(n) > 0)
            {
                int lastNumber = n % 10;
                if (lastNumber % 2 == 0)
                    sumEvens += lastNumber;
                else
                    sumOdds += lastNumber;
                n /= 10;
            }
            return sumEvens * sumOdds;
        }
    }
}
