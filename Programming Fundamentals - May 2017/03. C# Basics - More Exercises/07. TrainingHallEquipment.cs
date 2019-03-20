using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingHallEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            int numOfItem = int.Parse(Console.ReadLine());
            decimal subTotal = 0;
            for (int i = 0; i < numOfItem; i++)
            {
                var itemName = Console.ReadLine();
                decimal itemPrice = decimal.Parse(Console.ReadLine());
                int itemCount = int.Parse(Console.ReadLine());
                subTotal += itemPrice * itemCount;
                if (itemCount == 1)
                    Console.WriteLine($"Adding {itemCount} {itemName} to cart.");
                else
                    Console.WriteLine($"Adding {itemCount} {itemName}s to cart.");
            }
            if (subTotal <= budget)
            {
                Console.WriteLine($"Subtotal: ${subTotal:f2}");
                Console.WriteLine($"Money left: ${(budget - subTotal):f2}");
            }
            else
            {
                Console.WriteLine($"Subtotal: ${subTotal:f2}");
                Console.WriteLine($"Not enough. We need ${(subTotal - budget):f2} more.");
            }
        }
    }
}
