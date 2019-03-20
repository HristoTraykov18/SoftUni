using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            var imperialUnitName = Console.ReadLine();
            decimal imperialUnit = decimal.Parse(Console.ReadLine());
            var metricUnitName = "";
            decimal multiplyBy = 0;
            switch (imperialUnitName)
            {
                case "miles":
                    metricUnitName = "kilometers";
                    multiplyBy = 1.6m;
                    break;
                case "inches":
                    metricUnitName = "centimeters";
                    multiplyBy = 2.54m;
                    break;
                case "feet":
                    metricUnitName = "centimeters";
                    multiplyBy = 30m;
                    break;
                case "yards":
                    metricUnitName = "meters";
                    multiplyBy = 0.91m;
                    break;
                case "gallons":
                    metricUnitName = "liters";
                    multiplyBy = 3.8m;
                    break;
            }
            Console.WriteLine($"{imperialUnit} {imperialUnitName} = {(imperialUnit * multiplyBy):f2} {metricUnitName}");
        }
    }
}
