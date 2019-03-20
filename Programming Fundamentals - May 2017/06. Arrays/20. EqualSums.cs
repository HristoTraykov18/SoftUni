using System;
using System.Linq;

namespace EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int i = 0; i < numbers.Length; i++)
            {
                int tempSum1 = 0;
                int tempSum2 = 0;
                bool negativeNumber = false;
                bool isZero = true;
                for (int k = 0; k < i; k++)
                {
                    tempSum1 += numbers[k];
                    if (numbers[k] < 0)
                    {
                        negativeNumber = true;
                    }
                    if (numbers[k] != 0)
                    {
                        isZero = false;
                    }
                }
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    tempSum2 += numbers[j];
                    if (numbers[j] < 0)
                    {
                        negativeNumber = true;
                    }
                    if (numbers[j] != 0)
                    {
                        isZero = false;
                    }
                }
                if (tempSum1 == tempSum2)
                {
                    if (tempSum1 == 0)
                    {
                        if (numbers.Length == 1)
                        {
                            Console.WriteLine(0);
                        }
                        else
                        {
                            if (negativeNumber || isZero)
                            {
                                Console.WriteLine(i);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("no");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine(i);
                        break;
                    }
                }
                else if (i == numbers.Length - 1)
                {
                    Console.WriteLine("no");
                }
            }
        }
    }
}
