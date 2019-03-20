using System;
using System.Linq;
using System.Collections.Generic;

namespace SumReversedNums
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine().Split(' ').ToList();
            int sum = 0;
            string temp = "";
            foreach (string number in numbers)
            {
                char[] digitsInNumber = number.ToCharArray();
                Array.Reverse(digitsInNumber);
                foreach (char digit in digitsInNumber)
                    temp += digit;
                sum += int.Parse(temp);
                temp = "";
            }
            Console.WriteLine(sum);
        }
    }
}