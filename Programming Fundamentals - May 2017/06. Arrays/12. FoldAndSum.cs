using System;
using System.Linq;

namespace FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] sum = new int[array.Length / 2];
            for (int i = 0; i < array.Length; i++)
            {
                if (i < array.Length - (array.Length / 2) - (array.Length / 4))
                    sum[i] = array[array.Length / 2 - (array.Length / 4) + i] + array[array.Length / 2 - (array.Length / 4) - 1 - i];
                else if (i >= array.Length / 4 && i < array.Length / 2)
                    sum[i] = array[array.Length / 2 + i - array.Length / 4] + array[array.Length - i - 1 + array.Length / 4];
            }
            for (int i = 0; i < sum.Length; i++)
            {
                Console.Write(sum[i]);
                if (i != sum.Length -1)
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}
