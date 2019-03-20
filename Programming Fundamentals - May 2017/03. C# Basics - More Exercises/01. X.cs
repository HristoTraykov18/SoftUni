using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int spaces = n - 2;
            int spacesFirst = 0;
            if (n == 3)
            {
                Console.WriteLine("x x");
                Console.WriteLine(" x");
                Console.WriteLine("x x");
            }
            else
                for (int i = 0; i < n; i++)
                {
                    if (i == n / 2)
                    {
                        Console.WriteLine(new string(' ', spacesFirst) + "x");
                        spaces += 2;
                        spacesFirst--;
                    }
                    else if (i > n / 2)
                    {
                        Console.WriteLine(new string(' ', spacesFirst) + "x" + new string(' ', spaces) + "x");
                        spaces += 2;
                        spacesFirst--;
                    }
                    else
                    {
                        Console.WriteLine(new string(' ', spacesFirst) + "x" + new string(' ', spaces) + "x");
                        spaces -= 2;
                        spacesFirst++;
                    }
                }
        }
    }
}
