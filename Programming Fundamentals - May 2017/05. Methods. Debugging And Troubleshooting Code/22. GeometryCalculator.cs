using System;

namespace GeometryCalculator
{
    class Program
    {
        static double TriangleArea(double side, double height) { return side * height / 2; }
        static double RectangleArea(double side, double height) { return side * height; }
        static double SquareArea(double side) { return side * side; }
        static double CircleArea(double radius) { return Math.PI * radius * radius; }
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            if (figure == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                Console.WriteLine($"{TriangleArea(side, height):f2}");
            }
            else if (figure == "rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                Console.WriteLine($"{RectangleArea(width, height):f2}");
            }
            else if (figure == "square")
            {
                double side = double.Parse(Console.ReadLine());
                Console.WriteLine($"{SquareArea(side):f2}");
            }
            else if (figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                Console.WriteLine($"{CircleArea(radius):f2}");
            }
        }
    }
}
