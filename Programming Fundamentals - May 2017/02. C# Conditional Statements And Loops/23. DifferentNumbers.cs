using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int bigger = 0, smaller = 0;
            if (a > b)
            {
                bigger = a;
                smaller = b;
            }
            else if (b > a)
            {
                bigger = b;
                smaller = a;
            }
            if (bigger - smaller >= 4)
            {
                for (int i = smaller; i <= bigger - 4; i++)
                {
                    for (int k = smaller + 1; k <= bigger - 3; k++)
                    {
                        for (int j = smaller + 2; j <= bigger - 2; j++)
                        {
                            for (int m = smaller + 3; m <= bigger - 1; m++)
                            {
                                for (int n = smaller + 4; n <= bigger; n++)
                                {
                                    if (n > m && m > j && j > k && k > i)
                                        Console.WriteLine(i + " " + k + " " + j + " " + m + " " + n);
                                }
                            }
                        }
                    }
                }
            }
            else
                Console.WriteLine("No");
        }
    }
}
