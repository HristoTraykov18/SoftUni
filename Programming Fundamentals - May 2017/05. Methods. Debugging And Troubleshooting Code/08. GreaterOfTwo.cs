using System;

namespace GreaterOfTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            if (type == "char")
                Console.WriteLine(GetGreaterChar());
            else if (type == "int")
                Console.WriteLine(GetGreaterInt());
            else
                Console.WriteLine(GetLongerString());
        }
        static int GetGreaterInt()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (a > b)
                return a;
            return b;
        }
        static char GetGreaterChar()
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            if (a > b)
                return a;
            return b;
        }
        static string GetLongerString()
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            if (a.CompareTo(b) >= 0)
                return a;
            return b;
        }
    }
}
