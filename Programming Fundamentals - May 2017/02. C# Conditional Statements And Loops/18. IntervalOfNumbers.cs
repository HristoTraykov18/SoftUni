using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntervalOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int smaller, bigger;
            if (num1 > num2)
            {
                bigger = num1;
                smaller = num2;
            }
            else
            {
                bigger = num2;
                smaller = num1;
            }
            for (int i = smaller; i <= bigger; i++)
                Console.WriteLine(i);
        }
    }
}
