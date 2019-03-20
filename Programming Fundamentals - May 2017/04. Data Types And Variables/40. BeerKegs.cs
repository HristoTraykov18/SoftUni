using System;

namespace BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            double currentRadius = double.MinValue;
            string currentModel = "";
            for (int i = 0; i < numberOfLines; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                if ((Math.PI * radius * radius * height) > currentRadius)
                {
                    currentRadius = Math.PI * radius * radius * height;
                    currentModel = model;
                }
            }
            Console.WriteLine(currentModel);
        }
    }
}
