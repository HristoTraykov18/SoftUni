using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaporStore
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal currentBalance = decimal.Parse(Console.ReadLine());
            var game = Console.ReadLine();
            decimal gameCost = 0, totalSpent = 0;
            bool notFound = false;
            while (game != "Game Time" && currentBalance > 0)
            {
                if (game == "OutFall 4")
                    gameCost = 39.99m;
                else if (game == "CS: OG")
                    gameCost = 15.99m;
                else if (game == "Zplinter Zell")
                    gameCost = 19.99m;
                else if (game == "Honored 2")
                    gameCost = 59.99m;
                else if (game == "RoverWatch")
                    gameCost = 29.99m;
                else if (game == "RoverWatch Origins Edition")
                    gameCost = 39.99m;
                else
                {
                    Console.WriteLine("Not Found");
                    notFound = true;
                    gameCost = 0;
                }
                if (gameCost > currentBalance)
                    Console.WriteLine("Too Expensive");
                if (!notFound && gameCost <= currentBalance)
                {
                    Console.WriteLine($"Bought {game}");
                    currentBalance -= gameCost;
                    totalSpent += gameCost;
                }
                notFound = false;
                game = Console.ReadLine();
            }
            if (currentBalance == 0)
                Console.WriteLine("Out of money!");
            else
                Console.WriteLine($"Total spent: ${totalSpent:f2}. Remaining: ${currentBalance:f2}");
        }
    }
}
