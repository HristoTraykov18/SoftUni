using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            decimal studioPrice = 0, doublePrice = 0, suitePrice = 0;
            switch (month)
            {
                case "May":
                case "October":
                    studioPrice = 50 * nights;
                    doublePrice = 65 * nights;
                    suitePrice = 75 * nights;
                    if (nights > 7)
                    {
                        if (month == "October")
                            studioPrice -= 50;
                        studioPrice *= 0.95m;
                    }
                    break;
                case "June":
                case "September":
                    studioPrice = 60 * nights;
                    doublePrice = 72 * nights;
                    suitePrice = 82 * nights;
                    if (nights > 7 && month == "September")
                        studioPrice -= 60;
                    if (nights > 14)
                        doublePrice *= 0.9m;
                    break;
                case "July":
                case "August":
                case "December":
                    studioPrice = 68 * nights;
                    doublePrice = 77 * nights;
                    suitePrice = 89 * nights;
                    if (nights > 14)
                        suitePrice *= 0.85m;
                    break;
            }
            Console.WriteLine($"Studio: {studioPrice:f2} lv.\nDouble: {doublePrice:f2} lv.\nSuite: {suitePrice:f2} lv.");
        }
    }
}
