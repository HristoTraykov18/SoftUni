using System;
using System.Linq;

namespace Heists
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] prices = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            string[] command = Console.ReadLine().Split(' ').ToArray();
            long earned = 0;
            long lost = 0;
            while (command[0] != "Jail" && command[1] != "Time")
            {
                lost += uint.Parse(command[1]);
                foreach (char symbol in command[0])
                {
                    if (symbol == '%') 
                        earned += prices[0];
                    else if (symbol == '$')
                        earned += prices[1];
                }
                command = Console.ReadLine().Split(' ').ToArray();
            }
            if (lost > earned)
                Console.WriteLine($"Have to find another job. Lost: {Math.Abs(lost - earned)}.");
            else
                Console.WriteLine($"Heists will continue. Total earnings: {Math.Abs(earned - lost)}.");
        }
    }
}
