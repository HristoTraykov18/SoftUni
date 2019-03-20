using System;
using System.Linq;
using System.Collections.Generic;

namespace AppendLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> tokens = Console.ReadLine().Split('|').ToList();
            List<int> result = new List<int>();

            for (int i = tokens.Count - 1; i > -1; i--)
            {
                string token = tokens.ElementAt(i);
                for (int j = 0; j < token.Length; j++)
                {
                    int number = 0;
                    string numberAsString = "";
                    bool isNumber = int.TryParse(token[j].ToString(), out number);
                    while (isNumber || token[j] == '-')
                    {
                        numberAsString += token[j];
                        if (j + 1 < token.Length)
                        {
                            j++;
                            isNumber = int.TryParse(token[j].ToString(), out number);
                        }
                        else
                            isNumber = false;
                    }
                    if (numberAsString.Length > 0)
                    {
                        number = int.Parse(numberAsString);
                        Console.Write(number);
                        if (i < tokens.Count && j < token.Length)
                            Console.Write(" ");
                    }
                }
            }
        }
    }
}