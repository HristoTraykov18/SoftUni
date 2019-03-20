using System;
using System.Linq;

namespace RoutingNumbersAwayFrom0
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double[] arr = input.Split(' ').Select(n => Convert.ToDouble(n)).ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
                arr[i] = Math.Round(arr[i], MidpointRounding.AwayFromZero);
                Console.WriteLine($" => {arr[i]}");
            }
        }
    }
}
