using System;
using System.Linq;
using System.Collections.Generic;

namespace RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers.ElementAt(i) < 0)
                {
                    numbers.RemoveAt(i);
                    i--;
                }
            }
            if (numbers.Count > 0)
            {
                numbers.Reverse();
                for (int i = 0; i < numbers.Count; i++)
                {
                    Console.Write(numbers.ElementAt(i));
                    if (i < numbers.Count - 1)
                        Console.Write(" ");
                }
            }
            else
                Console.WriteLine("empty");
        }
    }
}