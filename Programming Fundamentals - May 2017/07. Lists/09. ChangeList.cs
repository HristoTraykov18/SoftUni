using System;
using System.Linq;
using System.Collections.Generic;

namespace ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            string nums = Console.ReadLine();
            List<int> numList = nums.Split(' ').Select(Int32.Parse).ToList();

            string command = Console.ReadLine();
            List<string> commandList = command.Split(' ').ToList();

            while (command != "Odd" && command != "Even")
            {
                if (commandList.ElementAt(0) == "Delete")
                {
                    numList.RemoveAll(number => number == Convert.ToInt32(commandList.ElementAt(1)));
                }
                else if (commandList.ElementAt(0) == "Insert")
                {
                    numList.Insert(Convert.ToInt32(commandList.ElementAt(2)), Convert.ToInt32(commandList.ElementAt(1)) );
                }
                command = Console.ReadLine();
                commandList = command.Split(' ').ToList();
            }
            for (int i = 0; i < numList.Count; i++)
            {
                if (commandList.ElementAt(0) == "Odd" && numList.ElementAt(i) % 2 == 1)
                {
                    Console.Write(numList.ElementAt(i));
                    if (i < numList.Count - 1)
                        Console.Write(" ");
                }
                else if (commandList.ElementAt(0) == "Even" && numList.ElementAt(i) % 2 == 0)
                {
                    Console.Write(numList.ElementAt(i));
                    if (i < numList.Count - 1)
                        Console.Write(" ");
                }
            }

        }
    }
}
