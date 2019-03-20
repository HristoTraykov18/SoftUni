using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfInputs = int.Parse(Console.ReadLine());
            int totalLiters = 0;
            for (int i = 0; i < numberOfInputs; i++)
            {
                int litersToAdd = int.Parse(Console.ReadLine());
                totalLiters += litersToAdd;
                if (totalLiters > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    totalLiters -= litersToAdd;
                }
            }
            Console.WriteLine(totalLiters);
        }
    }
}
