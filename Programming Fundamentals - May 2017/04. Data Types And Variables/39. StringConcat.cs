using System;

namespace StringConcat
{
    class Program
    {
        static void Main(string[] args)
        {
            char separator = char.Parse(Console.ReadLine());
            string oddOrEven = Console.ReadLine();
            bool isEven = false;
            if (oddOrEven == "even")
                isEven = true;
            int numberOfLines = int.Parse(Console.ReadLine());
            string output = "";
            for (int i = 1; i <= numberOfLines; i++)
            {
                string input = Console.ReadLine();
                if (isEven && i % 2 == 0)
                {
                    output += input;
                    output += separator;
                }
                else if (!isEven && i % 2 == 1)
                {
                    output += input;
                    output += separator;
                }
            }
            output = output.Remove(output.Length - 1);
            Console.WriteLine(output);
        }
    }
}
