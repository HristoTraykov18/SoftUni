using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexVar
{
    class Program
    {
        static void Main(string[] args)
        {
            var hexNumber = Console.ReadLine();
            Console.WriteLine(Convert.ToInt32(hexNumber, 16));
        }
    }
}
