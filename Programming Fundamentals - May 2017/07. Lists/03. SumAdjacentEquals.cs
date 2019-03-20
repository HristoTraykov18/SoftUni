using System;
using System.Linq;
using System.Collections.Generic;

namespace SumAdjacentEquals
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (i > 0 && numbers.ElementAt(i) == numbers.ElementAt(i - 1))
                    i--;
                if (i + 1 < numbers.Count && numbers.ElementAt(i) == numbers.ElementAt(i + 1))
                {
                    numbers.Insert(i, numbers.ElementAt(i) + numbers.ElementAt(i + 1));
                    numbers.RemoveAt(i + 1);
                    numbers.RemoveAt(i + 1);
                    i--;
                }
            }
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.Write(numbers.ElementAt(i));
                if (i < numbers.Count)
                    Console.Write(" ");
            }
        }
    }
}