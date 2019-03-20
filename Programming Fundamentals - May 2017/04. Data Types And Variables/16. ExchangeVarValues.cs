using System;

namespace ExchangeVarValues
{
    class Program
    {
        static void Main(string[] args)
        {
          int a = 5;
          int b = 10;
          int temp = b;
          Console.WriteLine($"Before:\n a = {a}\nb = {b}");
          b = a;
          a = temp;
          Console.WriteLine($"After:\n a = {a}\nb = {b}");
        }
    }
}
