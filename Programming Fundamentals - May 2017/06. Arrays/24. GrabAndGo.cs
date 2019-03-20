using System;
using System.Linq;

namespace GrabAndGo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbersArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int number = int.Parse(Console.ReadLine());
            int index = -1;
            for (int i = 0; i < numbersArr.Length; i++)
            {
                if (number == numbersArr[i])
                {
                    index = i;
                }
            }

            if (index == -1)
            {
                Console.WriteLine("No occurrences were found!");
            }

            else
            {
                long sum = 0;
                for (int k = 0; k < index; k++)
                {
                    sum += numbersArr[k];
                }
                Console.WriteLine(sum);
            }
        }
    }
}
