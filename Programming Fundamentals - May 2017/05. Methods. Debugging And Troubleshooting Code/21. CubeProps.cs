using System;

namespace CubeProps
{
    class Program
    {
        static double CalculateFace(double cubeSide)  { return cubeSide * Math.Sqrt(2); }
        static double CalculateSpace(double cubeSide) { return cubeSide * Math.Sqrt(3); }
        static double CalculateVolume(double cubeSide) { return Math.Pow(cubeSide, 3); }
        static double CalculateArea(double cubeSide) { return 6 * Math.Pow(cubeSide, 2); }
        static void Main(string[] args)
        {
            double cubeSide = double.Parse(Console.ReadLine());
            string whatToCalculate = Console.ReadLine();
            if (whatToCalculate == "face")
                Console.WriteLine($"{CalculateFace(cubeSide):f2}");
            else if (whatToCalculate == "space")
                Console.WriteLine($"{CalculateSpace(cubeSide):f2}");
            else if (whatToCalculate == "volume")
                Console.WriteLine($"{CalculateVolume(cubeSide):f2}");
            else if (whatToCalculate == "area")
                Console.WriteLine($"{CalculateArea(cubeSide):f2}");
        }
    }
}
