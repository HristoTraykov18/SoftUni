using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartOfASCII
{
    class Program
    {
        static void Main(string[] args)
        {
            int begining = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            for (int i = begining; i <= end; i++)
                Console.Write($"{(char)i} ");
            Console.WriteLine();
        }
    }
}
