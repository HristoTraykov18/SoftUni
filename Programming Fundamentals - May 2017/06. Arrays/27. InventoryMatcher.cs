using System;
using System.Linq;

namespace InventoryMatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(' ').ToArray();
            long[] quantities = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            string[] prices = Console.ReadLine().Split(' ').ToArray();
            string command = Console.ReadLine();
            while (command != "done")
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (names[i] == command)
                    {
                        Console.WriteLine($"{names[i]} costs: {prices[i]}; Available quantity: {quantities[i]}");
                        break;
                    }
                }
                command = Console.ReadLine();
            }
        }
    }
}
