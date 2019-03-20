using System;

namespace ReversedNums
{
    class Program
    {
        static string ReversedNumber(string number)
        {
            string reversedNumber = "";
            for (int i = number.Length - 1; i >= 0; i--)
            {
                reversedNumber += number[i];
            }
            return reversedNumber;
        }
        static void Main(string[] args)
        {   
            string number = Console.ReadLine();
            Console.WriteLine(ReversedNumber(number));
        }
    }
}
