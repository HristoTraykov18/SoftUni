using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                int n = int.Parse(Console.ReadLine());
                if (Math.Abs(n) % 2 == 0)
                    Console.WriteLine("Please write an odd number.");
                else
                {
                    Console.WriteLine($"The number is: {Math.Abs(n)}");
                    break;
                }
            }
        }
    }
}
