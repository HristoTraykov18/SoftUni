using System;

namespace IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine(input[i] + " -> " + ((int)input[i] - 'a'));
            }
        }
    }
}
