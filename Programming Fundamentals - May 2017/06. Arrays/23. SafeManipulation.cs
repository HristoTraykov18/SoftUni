using System;
using System.Linq;

namespace SafeManipulation
{
    class Program
    {
        static void Distinct(ref string[] words)
        {
            string[] tempArr = new string[words.Length];
            int removedCount = 0;
            for (int i = 0; i < words.Length; i++)
            {
                bool toRemove = false;
                for (int k = 0; k <= i; k++)
                {
                    if (words[i] == words[k] && i != k)
                    {
                        removedCount++;
                        tempArr[i] = "";
                        toRemove = true;
                        break;
                    }
                }
                if (!toRemove)
                {
                    tempArr[i] = words[i];
                }
            }

            words = new string[words.Length - removedCount];
            int removed = 0;
            for (int i = 0; i < words.Length; i++)
            {
                if (tempArr[i + removed] == "")
                {
                    removed++;
                    i--;
                }
                else
                {
                    words[i] = tempArr[i + removed];
                }
            }
        }
        static void Reverse(ref string[] words)
        {
            string[] newArray = new string[words.Length];
            for (int i = 0; i < words.Length; i++)
            {
                newArray[i] = words[words.Length - i - 1];
            }
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = newArray[i];
            }
        }
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ').ToArray();
            string[] commands = Console.ReadLine().Split(' ').ToArray();
            while (commands[0] != "END")
            {
                try {
                    if (commands[0] == "Distinct")
                    {
                        Distinct(ref words);
                    }
                    else if (commands[0] == "Reverse")
                    {
                        Reverse(ref words);
                    }
                    else
                    {
                        words[int.Parse(commands[1])] = commands[2];
                    }
                }
                catch (IndexOutOfRangeException) {
                    Console.WriteLine("Invalid input!");
                }
                commands = Console.ReadLine().Split(' ').ToArray();
            }
            for (int i = 0; i < words.Length; i++)
            {
                Console.Write(words[i]);
                if (i != words.Length - 1)
                {
                    Console.Write(", ");
                }
            }
        }
    }
}
