using System;

namespace Fibonacci
{
    class Program
    {
        static long FibonacciNumber(int number)
        {
            int firstNumber = 0;
            int secondNumber = 1;
            int fibonacciNumber = 0;
            if (number == 0)
                return 1;
            else
                for (int i = 0; i < number; i++)
                {
                    fibonacciNumber = firstNumber + secondNumber;
                    firstNumber = secondNumber;
                    secondNumber = fibonacciNumber;
                }
            return fibonacciNumber;
        }
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(FibonacciNumber(number));
        }
    }
}