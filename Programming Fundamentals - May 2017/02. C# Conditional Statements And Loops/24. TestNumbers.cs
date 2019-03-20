using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            int sum = 0, count = 0;
            for (int i = n; i > 0; i--)
            {
                for (int k = 1; k <= m; k++)
                {
                    sum += (i * k) * 3;
                    count++;
                    if (sum >= max)
                        break;
                }
                if (sum >= max)
                {
                    Console.WriteLine(count + " combinations");
                    Console.WriteLine($"Sum: {sum} >= {max}");
                    break;
                }
            }
            if (sum < max)
            {
                Console.WriteLine(count + " combinations");
                Console.WriteLine($"Sum: {sum}");
            }
        }
    }
}
