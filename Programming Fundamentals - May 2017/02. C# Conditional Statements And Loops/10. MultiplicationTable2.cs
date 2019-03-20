using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            for (int i = 1; i < 11; i++)
            {
                if (i == 1)
                    i = b;
                if (b > 10)
                {
                    Console.WriteLine($"{a} X {b} = {a * b}");
                    break;
                }
                else
                    Console.WriteLine($"{a} X {b} = {a * b++}");
            }
        }
    }
}
