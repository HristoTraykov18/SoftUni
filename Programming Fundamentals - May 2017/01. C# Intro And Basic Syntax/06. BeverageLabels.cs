using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeverageLabels
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            double energyPer100 = double.Parse(Console.ReadLine());
            double sugarPer100 = double.Parse(Console.ReadLine());
            Console.WriteLine($"{volume}ml {name}:\n{energyPer100 * (volume / 100) + (energyPer100 * (volume % 100)) / 100}kcal, {sugarPer100 * (volume / 100) + (sugarPer100 * (volume % 100)) / 100}g sugars");
        }
    }
}
