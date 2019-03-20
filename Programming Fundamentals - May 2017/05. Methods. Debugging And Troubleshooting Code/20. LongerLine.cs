using System;

namespace LongerLine
{
    class Program
    {
        static void FindLongerLine(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            double line1 = Math.Abs((x1 + y1) - (x2 + y2));
            double line2 = Math.Abs((x3 + y3) - (x4 + y4));

            if (line2 > line1)
            {
                if (Math.Abs(x4 + y4) < Math.Abs(x3 + y3))
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
                else
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
            }
            else
            {
                if (Math.Abs(x2 + y2) < Math.Abs(x1 + y1))
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                else
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
        }
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());
            FindLongerLine(x1, y1, x2, y2, x3, y3, x4, y4);
        }
    }
}
