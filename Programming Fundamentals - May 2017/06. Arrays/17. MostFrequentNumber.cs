using System;
using System.Linq;

namespace MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int length = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > length)
                {
                    length = numbers[i];
                }
            }
            int[] numbersCounts = new int[length + 1];
            int firstBiggest = 0;
            bool isBigger = true;
            for (int i = 0; i < numbers.Length; i++)
            {
                numbersCounts[numbers[i]]++;
                for (int k = 0; k < numbersCounts.Length; k++)
                {
                    if (numbersCounts[numbers[i]] <= numbersCounts[k] && k != numbers[i])
                    {
                        isBigger = false;
                    }
                }
                if (isBigger)
                {
                    firstBiggest = numbers[i];
                }
                isBigger = true;
            }
            int mostFrequentCount = 0;
            int mostFrequentNumber = 0;
            for (int i = 0; i < numbersCounts.Length; i++)
            {
                if (numbersCounts[i] > mostFrequentCount)
                {
                    mostFrequentNumber = i;
                    mostFrequentCount = numbersCounts[i];
                }
            }
            if (numbersCounts[firstBiggest] == mostFrequentCount)
            {
                mostFrequentNumber = firstBiggest;
            }
            Console.WriteLine(mostFrequentNumber);
        }
    }
}
