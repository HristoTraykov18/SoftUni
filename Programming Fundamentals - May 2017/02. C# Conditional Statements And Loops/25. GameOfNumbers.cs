using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magNumber = int.Parse(Console.ReadLine());
            int count = 0;
            bool isMagical = false;
            for (int i = n; i <= m; i++)
            {
                for (int k = n; k <= m; k++)
                {
                    count++;
                    if (i + k == magNumber)
                    {
                        Console.WriteLine($"Number found! {k} + {i} = {magNumber}");
                        isMagical = true;
                        break;
                    }
                }
                if (isMagical)
                    break;
            }
            if (!isMagical)
                Console.WriteLine($"{count} combinations - neither equals {magNumber}");
        }
    }
}
