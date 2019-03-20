using System;
using System.Linq;

namespace LargestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input1 = Console.ReadLine().Split(' ').ToArray();
            string[] input2 = Console.ReadLine().Split(' ').ToArray();
            int shorterLength = input1.Length;
            int longerLength = input2.Length;
            int countLeft = 0;
            int countRight = 0;
            if (input2.Length < input1.Length)
            {
                shorterLength = input2.Length;
                longerLength = input1.Length;
            }
            for (int i = 0; i < shorterLength; i++)
            {
                if (input1[input1.Length - 1 - i] == input2[input2.Length - 1 - i])
                    countRight++;
                if (input1[i] == input2[i])
                    countLeft++;
            }
            int output = countLeft < countRight ? countRight : countLeft;
            Console.WriteLine(output);
        }
    }
}
