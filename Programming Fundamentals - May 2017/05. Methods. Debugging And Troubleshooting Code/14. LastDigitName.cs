using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastDigitName
{
    class Program
    {
        static string NameOfLastDigit(string number)
        {
            switch (number[number.Length-1])
            {
                case '1':
                    return "one";
                case '2':
                    return "two";
                case '3':
                    return "three";
                case '4':
                    return "four";
                case '5':
                    return "five";
                case '6':
                    return "six";
                case '7':
                    return "seven";
                case '8':
                    return "eight";
                case '9':
                    return "nine";
            }
            return "zero";
        }
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            Console.WriteLine(NameOfLastDigit(number));
        }
    }
}
