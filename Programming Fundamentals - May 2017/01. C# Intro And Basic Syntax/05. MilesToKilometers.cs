using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilesToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal miles = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"{(miles * 1.60934M):f2}");
        }
    }
}
