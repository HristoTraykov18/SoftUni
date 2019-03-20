using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingFloats
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberA = double.Parse(Console.ReadLine());
            double numberB = double.Parse(Console.ReadLine());
            double eps = 0.000001;
            bool isDifferent = true;
            if (numberA - numberB >= eps || numberB - numberA >= eps)
                Console.WriteLine(!isDifferent);
            else
                Console.WriteLine(isDifferent);
        }
    }
}
