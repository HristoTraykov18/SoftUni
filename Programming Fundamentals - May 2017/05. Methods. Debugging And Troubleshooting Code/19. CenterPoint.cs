using System;

namespace CenterPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal x1 = decimal.Parse(Console.ReadLine());
            decimal y1 = decimal.Parse(Console.ReadLine());
            decimal x2 = decimal.Parse(Console.ReadLine());
            decimal y2 = decimal.Parse(Console.ReadLine());

            if (Math.Abs(x2) + Math.Abs(y2) < Math.Abs(x1) + Math.Abs(y1))
                Console.WriteLine($"({x2}, {y2})");
            else
                Console.WriteLine($"({x1}, {y1})");
        }
    }
}
