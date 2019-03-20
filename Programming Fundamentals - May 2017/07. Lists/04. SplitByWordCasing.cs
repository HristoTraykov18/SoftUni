using System;
using System.Linq;
using System.Collections.Generic;

namespace SplitByWordCasing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split(new Char[] {',', ';', ':', '.', '!', '(', ')'
                                                                , '\"', '\'', '\\', '/', '[', ']', ' '})/*.Select(int.Parse)*/.ToList();
            List<string> lowerCaseWords = new List<string>();
            List<string> mixedCaseWords = new List<string>();
            List<string> upperCaseWords = new List<string>();
            for (int i = 0; i < words.Count; i++)
            {
                string currentWord = words.ElementAt(i);
                if (currentWord == "")
                {
                    words.Remove(currentWord);
                    i--;
                }
                else
                {
                    int upperLettersCounter = 0;
                    bool isMixed = false;
                    for (int j = 0; j < currentWord.Length; j++)
                    {
                        if (Char.IsPunctuation(currentWord[j]) || Char.IsDigit(currentWord[j]))
                            isMixed = true;
                        else if (Char.IsUpper(currentWord[j]))
                            upperLettersCounter++;
                    }
                    if (upperLettersCounter == currentWord.Length)
                        upperCaseWords.Add(currentWord);
                    else if (upperLettersCounter == 0 && !isMixed)
                        lowerCaseWords.Add(currentWord);
                    else
                        mixedCaseWords.Add(currentWord);
                }
            }
            Console.Write("Lower-case: ");
            for (int i = 0; i < lowerCaseWords.Count; i++)
            {
                Console.Write(lowerCaseWords.ElementAt(i));
                if (i < lowerCaseWords.Count - 1)
                    Console.Write(", ");
            }
            Console.WriteLine();
            Console.Write("Mixed-case: ");
            for (int i = 0; i < mixedCaseWords.Count; i++)
            {
                Console.Write(mixedCaseWords.ElementAt(i));
                if (i < mixedCaseWords.Count - 1)
                    Console.Write(", ");
            }
            Console.WriteLine();
            Console.Write("Upper-case: ");
            for (int i = 0; i < upperCaseWords.Count; i++)
            {
                Console.Write(upperCaseWords.ElementAt(i));
                if (i < upperCaseWords.Count - 1)
                    Console.Write(", ");
            }
        }
    }
}