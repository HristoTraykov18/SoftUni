using System;
using System.Linq;

namespace SumArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1 = Console.ReadLine();
            int[] arr1 = input1.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
            string input2 = Console.ReadLine();
            int[] arr2 = input2.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
            int biggerLength = arr1.Length;
            string output = "";
            if (arr1.Length < arr2.Length)
                biggerLength = arr2.Length;
            for (int i = 0; i < biggerLength; i++)
            {
                if (arr1.Length == arr2.Length)
                    arr1[i] += arr2[i];
                else
                {
                    if (arr1.Length > arr2.Length)
                    {
                        if (i >= arr2.Length)
                            arr1[i] += arr2[i % arr2.Length];
                        else
                            arr1[i] += arr2[i];
                    }
                    else
                    {
                        if (i >= arr1.Length)
                            arr2[i] += arr1[i % arr1.Length];
                        else
                            arr2[i] += arr1[i];
                    }
                }
            }
            for (int i = 0; i < biggerLength; i++)
            {
                if (arr1.Length >= arr2.Length)
                    Console.Write(arr1[i]);
                else
                    Console.Write(arr2[i]);
                if (i != biggerLength - 1)
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}
