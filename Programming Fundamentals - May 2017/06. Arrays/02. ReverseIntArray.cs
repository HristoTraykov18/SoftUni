using System;

namespace ReverseIntArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] intArray = new int[n];
            string output = "";
            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = int.Parse(Console.ReadLine());
            }
            for (int i = intArray.Length - 1; i >= 0; i--)
            {
                output += intArray[i];
                if (i != 0)
                    output += " ";
            }
            Console.WriteLine(output);
        }
    }
}
