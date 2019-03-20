using System;

namespace TemperatureConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit = double.Parse(Console.ReadLine());
            Console.WriteLine($"{TemperatureConverter(fahrenheit):f2}");
        }
        static double TemperatureConverter(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }
}
