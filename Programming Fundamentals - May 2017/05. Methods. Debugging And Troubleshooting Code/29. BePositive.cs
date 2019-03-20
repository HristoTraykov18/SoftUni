using System;
using System.Collections.Generic;

public class BePositive_Fixed
{
    public static void Main()
    {
        int countSequences = int.Parse(Console.ReadLine());

        for (int i = 0; i < countSequences; i++)
        {
            string[] input = Console.ReadLine().Trim().Split(' ');
            List<int> numbers = new List<int>();
            for (int k = 0; k < input.Length; k++)
                if (!input[k].Equals(string.Empty))
                    numbers.Add(int.Parse(input[k]));

            bool found = false;

            for (int k = 0; k < numbers.Count; k++)
            {
                int currentNum = numbers[k];
                if (currentNum >= 0)
                {
                    if (found)
                        Console.Write(" ");
                    Console.Write(currentNum);
                    found = true;
                }
                else
                {
                    if (k + 1 < numbers.Count)
                        currentNum += numbers[k + 1];
                    if (currentNum >= 0)
                    {
                        if (found)
                            Console.Write(" ");
                        Console.Write(currentNum);
                        found = true;
                        k++;
                    }
                    else
                        k++;
                }
            }
            if (!found)
                Console.WriteLine("(empty)");
            if (found)
                Console.WriteLine();
        }
    }
}