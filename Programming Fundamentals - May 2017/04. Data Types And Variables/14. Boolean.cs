using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "true")
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}
