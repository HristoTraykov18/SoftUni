using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecast
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            var weather = "";
            if (number - (long)number == 0)
            {
                if (number >= sbyte.MinValue && number <= sbyte.MaxValue)
                    weather = "Sunny";
                else if (number >= int.MinValue && number <= int.MaxValue)
                    weather = "Cloudy";
                else if (number >= long.MinValue && number <= long.MaxValue)
                    weather = "Windy";
            }
            else
                weather = "Rainy";
            Console.WriteLine(weather);
        }
    }
}
