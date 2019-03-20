using System;

namespace SieveOfEratosthes
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            bool[] primes = new bool[length + 1];
            for (int i = 0; i < primes.Length; i++)
                primes[i] = true;
            primes[0] = false;
            primes[1] = false;
            for (int i = 4; i < primes.Length; i += 2)
                primes[i] = false;
            for (int i = 6; i < primes.Length; i += 3)
                primes[i] = false;
            for (int i = 10; i < primes.Length; i += 5)
                primes[i] = false;
            for (int i = 14; i < primes.Length; i += 7)
                primes[i] = false;
            for (int i = 0; i < primes.Length; i++)
                if (primes[i])
                    for (int k = 11; k < i; k++)
                        if (i % k == 0)
                            primes[i] = false;
            for (int i = 0; i < primes.Length; i++)
            {
                if (primes[i])
                {
                    if (i != primes.Length)
                        Console.Write(i + " ");
                    else
                        Console.Write(i);
                }
            }
        }
    }
}
