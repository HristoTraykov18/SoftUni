using System;
using System.Numerics;

namespace FactorialTrailingZeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger result = 1;
            uint input = uint.Parse(Console.ReadLine());
            for (int i = 1; i <= input; i++)
                result *= i;
            string resultStr = result.ToString();
            int counter = 0;
            int consecutiveZeroes = 0;
            bool lastWasZero = false;
            for (int i = 0; i < resultStr.Length; i++)
            {
                if (resultStr[i] == '0')
                {
                    counter++;
                    consecutiveZeroes++;
                    lastWasZero = true;
                }
                if (lastWasZero && resultStr[i] != '0')
                {
                    counter -= consecutiveZeroes;
                    lastWasZero = false;
                    consecutiveZeroes = 0;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
