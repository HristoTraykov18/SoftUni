using System;
using System.Linq;

namespace RotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = int.Parse(Console.ReadLine());
            int[] sum = new int[array.Length];
            int tmp1 = 0;
            int tmp2 = 0;
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (j == 0)
                    {
                        tmp1 = array[j];
                        array[j] = array[array.Length - 1];
                    }
                    else
                    {
                        tmp2 = array[j];
                        array[j] = tmp1;
                        tmp1 = tmp2;
                    }
                    sum[j] += array[j];
                }
            }
            for (int i = 0; i < sum.Length; i++)
            {
                Console.Write(sum[i]);
                if(i < sum.Length - 1)
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}
