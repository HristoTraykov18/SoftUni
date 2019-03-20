using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterStats
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            int currHP = int.Parse(Console.ReadLine());
            int maxHP = int.Parse(Console.ReadLine());
            int currEn = int.Parse(Console.ReadLine());
            int maxEn = int.Parse(Console.ReadLine());
            Console.WriteLine($"Name: {name}\nHealth: " + '|' + new string('|', currHP) + new string('.', maxHP - currHP) + "|\nEnergy: " + '|' + new string('|', currEn) + new string('.', maxEn - currEn) + '|');
        }
    }
}
