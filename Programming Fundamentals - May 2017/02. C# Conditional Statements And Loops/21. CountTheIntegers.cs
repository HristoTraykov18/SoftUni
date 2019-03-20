using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountTheIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            bool n = int.TryParse(Console.ReadLine(), out int input);
            while (n == true)
            {
                count++;
                n = int.TryParse(Console.ReadLine(), out input);
            }
            Console.WriteLine(count);
        }
    }
}
