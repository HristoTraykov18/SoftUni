using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseDrink2
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            if (profession == "Athlete")
                Console.WriteLine($"The {profession} has to pay {(quantity * 0.7):f2}."); //Water
            else if (profession == "Businessman" || profession == "Businesswoman")
                Console.WriteLine($"The {profession} has to pay {(quantity):f2}."); //Coffee
            else if (profession == "SoftUni Student")
                Console.WriteLine($"The {profession} has to pay {(quantity * 1.7):f2}."); //Beer
            else
                Console.WriteLine($"The {profession} has to pay {(quantity * 1.2):f2}."); //Tea
        }
    }
}
