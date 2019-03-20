using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefractorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                int currentNumber = i;
                while (i > 0)
                {
                    sum += i % 10;
                    i = i / 10;
                }
                bool isSpecial = false;
                isSpecial = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{currentNumber} -> {isSpecial}");
                sum = 0;
                i = currentNumber;
            }
        }
    }
}
