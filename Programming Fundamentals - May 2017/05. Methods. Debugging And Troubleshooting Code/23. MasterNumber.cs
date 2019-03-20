using System;

namespace MasterNumber
{
    class Program
    {
        static bool IsSymmetric(string number)
        {
            if (number.Length == 1)
                return false;
            char[] numbers = new char[number.Length / 2];
            for (int i = 0; i < number.Length / 2; i++)
                numbers[i] = number[i];
            for (int i = 0; i < number.Length / 2; i++)
            {
                if (number[number.Length - i - 1] != numbers[i])
                    return false;
            }
            return true;
        }
        static bool DivisibleBy7(string number)
        {
            int sum = 0;
            for (int i = 0; i < number.Length; i++)
                sum += number[i] - 41;
            if (sum % 7 != 0)
                return false;
            return true;
        }
        static bool HasEvenDigit(string number)
        {
            for (int i = 0; i < number.Length; i++)
                if (number[i] % 2 == 0)
                    return true;
            return false;
        }
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                if (IsSymmetric(i.ToString()) && DivisibleBy7(i.ToString()) && HasEvenDigit(i.ToString()))
                    Console.WriteLine(i);
            }
        }
    }
}
