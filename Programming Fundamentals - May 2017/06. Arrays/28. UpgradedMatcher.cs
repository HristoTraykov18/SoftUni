using System;
using System.Linq;

namespace UpgradedMatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(' ').ToArray();
            long[] quantities = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            decimal[] prices = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();
            string[] command = Console.ReadLine().Split(' ').ToArray();
            while (command[0] != "done")
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (names[i] == command[0])
                    {
                        try 
                        {
                            if (Convert.ToInt64(command[1]) <= quantities[i])
                            {
                                Console.WriteLine($"{names[i]} x {command[1]} costs {(prices[i] * Convert.ToInt64(command[1])):F2}");
                                quantities[i] -= Convert.ToInt64(command[1]);
                                break;
                            }
                            else
                            {
                                Console.WriteLine($"We do not have enough {command[0]}");
                                break;
                            }
                        }
                        catch
                        {
                            Console.WriteLine($"We do not have enough {command[0]}");
                            break;
                        }
                    }
                }
                command = Console.ReadLine().Split(' ').ToArray();
            }
        }
    }
}