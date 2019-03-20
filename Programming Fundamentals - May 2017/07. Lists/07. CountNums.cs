using System;
using System.Linq;
using System.Collections.Generic;

namespace CountNums
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            Dictionary<int, int> dict = new Dictionary<int, int>();
            nums.Sort();
            for (int i = 0; i < nums.Count; i++)
            {
                int counter = 0;
                int currentNum = nums.ElementAt(i);
                for (int k = i; k < nums.Count; k++)
                {
                    if (nums.ElementAt(k) == currentNum)
                        counter++;
                }
                if (!dict.ContainsKey(currentNum))
                    dict.Add(currentNum, counter);
            }
            for (int i = 0; i < dict.Count; i++)
                Console.WriteLine(dict.ElementAt(i).Key + " -> " + dict.ElementAt(i).Value);
        }
    }
}