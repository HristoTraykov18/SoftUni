using System;
using System.Linq;

namespace ArrayStatistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int minNumber = int.MaxValue;
            int maxNumber = int.MinValue;
            int sum = 0;
            double avg = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (minNumber > numbers[i])
                {
                    minNumber = numbers[i];
                }
                if (maxNumber < numbers[i])
                {
                    maxNumber = numbers[i];
                }
                sum += numbers[i];
                avg += numbers[i];
            }
            avg /= numbers.Length;
            Console.WriteLine($"Min = {minNumber}");
            Console.WriteLine($"Max = {maxNumber}");
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Average = {avg}");
        }
    }
}
