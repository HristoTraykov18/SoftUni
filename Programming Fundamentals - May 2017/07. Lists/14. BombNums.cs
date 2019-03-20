using System;
using System.Linq;
using System.Collections.Generic;

namespace BombNums
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> bombSpecs = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int bombNumber = bombSpecs.ElementAt(0);
            int bombRange = bombSpecs.ElementAt(1);

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers.ElementAt(i) == bombNumber)
                {
                    int startIndex = 0;
                    int endIndex = numbers.Count;
                    if (i - bombRange > 0)
                        startIndex = i - bombRange;
                    if (i + bombRange + 1 < numbers.Count)
                        endIndex = i + bombRange + 1;
                    for (int j = startIndex; j < endIndex; j++)
                        numbers.RemoveAt(startIndex);
                    i--;
                }
            }
            int sum = 0;
            foreach (int number in numbers)
                sum += number;
            Console.WriteLine(sum);
        }
    }
}