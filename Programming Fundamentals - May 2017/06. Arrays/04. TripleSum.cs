namespace TripleSum
{
    using System;
    using System.Linq;

    class startUp
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            ushort c = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    int sum = arr[i] + arr[j];
                    if (arr.Contains(sum))
                    {
                        Console.WriteLine($"{arr[i]} + {arr[j]} == {sum}");
                        c++;
                    }
                }
            }
            if (c == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}