using System;
using System.Linq;

public class CommandsSequence_Fixed
{
    public static void Main()
    {
        int sizeOfArray = int.Parse(Console.ReadLine());
        long[] array = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
        string command = Console.ReadLine();

        while (!command.Equals("stop"))
        {
            int[] args = new int[2];
            string[] stringParams = command.Split(' ');

            if (stringParams[0].Equals("add") || stringParams[0].Equals("subtract") 
                || stringParams[0].Equals("multiply"))
            {
                args[0] = int.Parse(stringParams[1]);
                args[1] = int.Parse(stringParams[2]);
            }

            PerformAction(array, stringParams[0], args);
            PrintArray(array);
            command = Console.ReadLine();
        }
    }

    static void PerformAction(long[] arr, string action, int[] args)
    {
        int pos = args[0];
        int value = args[1];

        switch (action)
        {
            case "multiply":
                arr[pos - 1] *= value;
                break;
            case "add":
                arr[pos - 1] += value;
                break;
            case "subtract":
                arr[pos - 1] -= value;
                break;
            case "lshift":
                ArrayShiftLeft(arr);
                break;
            case "rshift":
                ArrayShiftRight(arr);
                break;
        }
    }

    private static void ArrayShiftRight(long[] array)
    {
        for (int i = array.Length - 1; i > 0; i--)
        {
            long temp = array[i - 1];
            array[i - 1] = array[i];
            array[i] = temp;
        }
    }
    private static void ArrayShiftLeft(long[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            long temp = array[i + 1];
            array[i + 1] = array[i];
            array[i] = temp;
        }
    }
    private static void PrintArray(long[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
            if (i != array.Length -1)
                Console.Write(" ");
        }
        Console.WriteLine();
    }
}
