using System;

namespace LastNumbersSums
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            long k = long.Parse(Console.ReadLine());
            long[] arr = new long[n];
            arr[0] = 1;
            for (long i = 1; i < n; i++)
            {
                for (long p = 1; p <= k; p++)
                {
                    if (i - p >= 0)
                        arr[i] += arr[i - p];
                }
            }
            string output = "";
            for (int i = 0; i < arr.Length; i++)
            {
                output += arr[i];
                if (i != arr.Length - 1)
                    output += " ";
            }
            Console.WriteLine(output);
        }
    }
}
