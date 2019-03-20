using System;
using System.Linq;
using System.Collections.Generic;

namespace SqrtNums
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> sqrtNums = new List<int>();
            foreach  (int num in nums)
                if (Math.Sqrt(num) == (int)Math.Sqrt(num))
                    sqrtNums.Add(num);
            sqrtNums.Sort((a, b) => b.CompareTo(a));

            for (int i = 0; i < sqrtNums.Count; i++)
            {
                Console.Write(sqrtNums.ElementAt(i));
                if (i < sqrtNums.Count - 1)
                    Console.Write(" ");
            }
        }
    }
}