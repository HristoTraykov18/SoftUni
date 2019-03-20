using System;
using System.Linq;

namespace CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr1 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] arr2 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            bool arr1IsFirst = true;
            int smallerArray = arr1.Length > arr2.Length ? arr2.Length : arr1.Length;
            int sameLetters = 0;
            for (int i = 0; i < smallerArray; i++)
            {
                if (arr1[i] == arr2[i])
                    sameLetters++;
                else if (arr1[i] > arr2[i] && i == sameLetters)
                    arr1IsFirst = false;
            }
            if (smallerArray == arr2.Length && arr1.Length != arr2.Length)
                arr1IsFirst = false;
            string arr1Chars = "";
            for (int i = 0; i < arr1.Length; i++)
                arr1Chars += arr1[i];
            string arr2Chars = "";
            for (int i = 0; i < arr2.Length; i++)
                arr2Chars += arr2[i];
            if (arr1IsFirst)
            {
                Console.WriteLine(arr1Chars);
                Console.WriteLine(arr2Chars);
            }
            else
            {
                Console.WriteLine(arr2Chars);
                Console.WriteLine(arr1Chars);
            }
        }
    }
}
