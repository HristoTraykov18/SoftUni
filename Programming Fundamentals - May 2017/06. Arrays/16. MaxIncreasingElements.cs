using System;
using System.Linq;

namespace MaxIncreasingElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int currentSequence = 1;
            int lastSequence = 1;
            int currentStart = 0;
            int lastStart = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > numbers[i-1])
                {
                    if (currentSequence == 1)
                        currentStart = i - 1;
                    currentSequence++;
                }
                if (numbers[i] <= numbers[i-1] || i == numbers.Length - 1)
                {
                    if (lastSequence < currentSequence)
                    {
                        lastStart = currentStart;
                        lastSequence = currentSequence;
                    }
                    currentSequence = 1;
                }
            }
            for (int i = lastStart; i < lastStart + lastSequence; i++)
            {
                Console.Write(numbers[i]);
                if (i < lastStart + lastSequence)
                    Console.Write(" ");
            }
        }
    }
}