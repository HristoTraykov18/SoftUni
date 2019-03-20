using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            long firstPrice = long.Parse(Console.ReadLine());
            long secondPrice = long.Parse(Console.ReadLine());
            long totalFirstPrice = 0;
            long totalSecondPrice = 0;
            if (firstPrice < 128 && firstPrice >= 0)
                totalFirstPrice = firstPrice * 4;
            else
                totalFirstPrice = firstPrice * 10;
            if (secondPrice < 128 && secondPrice >= 0)
                totalSecondPrice = secondPrice * 4;
            else
                totalSecondPrice = secondPrice * 10;
            Console.WriteLine(totalFirstPrice + totalSecondPrice);
        }
    }
}
