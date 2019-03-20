using System;

namespace FilledSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            DrawASquare(lines);
        }
        static void DrawASquare(int lines)
        {
            Console.WriteLine(new string('-', lines * 2));
            for (int i = 0; i < lines - 2; i++)
            {
                Console.Write("-");
                for (int k = 0; k < lines - 1; k++)
                    Console.Write("\\/");
                Console.WriteLine("-");
            }
            Console.WriteLine(new string('-', lines * 2));
        }
    }
}
