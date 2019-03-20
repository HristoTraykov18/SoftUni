using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntToHexAndBin
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string hexNumber = String.Format($"{number:X}");
            string binaryNumber = Convert.ToString(number, 2);
            Console.WriteLine(hexNumber);
            Console.WriteLine(binaryNumber);
        }
    }
}
