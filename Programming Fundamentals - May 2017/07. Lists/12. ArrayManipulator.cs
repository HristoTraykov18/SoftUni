using System;
using System.Linq;
using System.Collections.Generic;

namespace ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string[] input = Console.ReadLine().Split(' ').ToArray();
            while (input[0] != "print")
            {
                if (input[0] == "add")
                    numbers.Insert(int.Parse(input[1]), int.Parse(input[2]));
                else if (input[0] == "addMany")
                {
                    List<int> elements = new List<int>();
                    for (int i = 2; i < input.Length; i++)
                        elements.Add(int.Parse(input[i]));
                    numbers.InsertRange(int.Parse(input[1]), elements);
                }
                else if (input[0] == "contains")
                {
                    int index = numbers.IndexOf(int.Parse(input[1]));
                    Console.WriteLine(index);
                }
                
                else if (input[0] == "remove")
                    numbers.RemoveAt(int.Parse(input[1]));
                
                else if (input[0] == "shift")
                {
                    int count = int.Parse(input[1]) % numbers.Count;
                    for (int i = 0; i < count; i++)
                    {
                        numbers.Add(numbers[0]);
                        numbers.RemoveAt(0);
                    }
                }
                else if (input[0] == "sumPairs")
                {
                    List<int> tempList = new List<int>();
                    for (int i = 0; i < numbers.Count; i += 2)
                    {
                        int currentEl = numbers[i];
                        int nextEl = 0;

                        if (i < numbers.Count - 1)
                            nextEl = numbers[i + 1];

                        tempList.Add(currentEl + nextEl);
                    }
                    numbers = tempList;
                }

                input = Console.ReadLine().Split(' ').ToArray();
            }
            
            Console.WriteLine("[{0}]", string.Join(", ", numbers));
        }
    }
}