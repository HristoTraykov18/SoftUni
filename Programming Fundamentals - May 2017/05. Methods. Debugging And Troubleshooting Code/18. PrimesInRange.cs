using System;
using System.Collections.Generic;

namespace PrimesInRange
{
    class Program
    {
        static List<int> PrimesInRange(int startNumber, int endNumber)
        {
            List<int> primeNumbers = new List<int>();
            if (startNumber > endNumber)
                return primeNumbers;
            for (int i = 0; i <= endNumber - startNumber; i++)
            {
                int number = startNumber + i;
                bool isPrime = true;
                for (int k = 2; k <= number / 2; k++)
                {
                    if (number % k == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (number != 0 && number != 1 && isPrime || number == 2 || number == 3 || number == 5 || number == 7)
                    primeNumbers.Add(number);
            }
            return primeNumbers;
        }
        static void Main(string[] args)
        {
            List<int> primes = PrimesInRange(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            if (primes.Count == 0)
                Console.WriteLine();
            else
            {
                string output = "";
                for (int i = 0; i < primes.Count; i++)
                    output += primes[i] + ", ";
                output = output.Remove(output.Length - 2);
                Console.WriteLine(output);
            }
        }
    }
}
