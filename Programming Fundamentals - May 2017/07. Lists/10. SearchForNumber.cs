using System;
using System.Linq;
using System.Collections.Generic;

namespace SearchForNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string nums = Console.ReadLine();
            List<int> numList = nums.Split(' ').Select(Int32.Parse).ToList();

            string command = Console.ReadLine();
            List<int> commandNums = command.Split(' ').Select(Int32.Parse).ToList();

            List<int> newList = new List<int>();
            for (int i = 0; i < commandNums.ElementAt(0); i++)
                newList.Add(numList.ElementAt(i));
            
            for (int i = 0; i < commandNums.ElementAt(1); i++)
                newList.RemoveAt(0);

            bool foundNum = false;
            foreach (int num in newList)
            {
                if (num == commandNums.ElementAt(2))
                {
                    Console.WriteLine("YES!");
                    foundNum = true;
                    break;
                }
            }
            if (!foundNum)
                Console.WriteLine("NO!");
        }
    }
}
