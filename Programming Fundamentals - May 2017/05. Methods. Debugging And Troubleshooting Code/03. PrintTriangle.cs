using System;

namespace PrintTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            PrintTriangles(lines);
        }
        static void PrintTriangles(int lines)
        {
            int counter = lines - 1;
            for (int i = 0; i < lines; i++)
            {
                for (int k = 0; k < lines - counter; k++)
                {
                    Console.Write(k + 1);
                    if (k < lines - counter)
                        Console.Write(" ");
                }
                Console.WriteLine();
                counter--;
            }
            counter += 2;
            for (int i = 0; i < lines - 1; i++)
            {
                for (int k = 0; k < lines - counter; k++)
                {
                    Console.Write((k + 1));
                    if (k < lines - counter - 1)
                        Console.Write(" ");
                }
                Console.WriteLine();
                counter++;
            }
        }
    }
}
