using System;
using System.Linq;

namespace ExtractMiddleElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int[] arr = input.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
            int elementsCount = 0;
            if (arr.Length == 1)
                elementsCount = 1;
            else if (arr.Length % 2 == 0)
                elementsCount = 2;
            else
                elementsCount = 3;
            int[] midElements = new int[elementsCount];
            switch (elementsCount)
            {
                case 1:
                    midElements[0] = arr[0];
                    break;
                case 2:
                    midElements[0] = arr[arr.Length / 2 - 1];
                    midElements[1] = arr[arr.Length / 2];
                    break;
                case 3:
                    midElements[0] = arr[arr.Length / 2 - 1];
                    midElements[1] = arr[arr.Length / 2];
                    midElements[2] = arr[arr.Length / 2 + 1];
                    break;
            }
            Console.Write("{ ");
            for (int i = 0; i < midElements.Length; i++)
            {
                Console.Write(midElements[i]);
                if (i != midElements.Length - 1)
                    Console.Write(", ");
            }
            Console.WriteLine(" }");
        }
    }
}
