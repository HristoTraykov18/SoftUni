using System;

namespace VowelOfDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol = char.Parse(Console.ReadLine());
            if (symbol == 'a' || symbol == 'e' || symbol == 'i' || symbol == 'o' || symbol == 'u' || symbol == 'y')
                Console.WriteLine("vowel");
            else if ((int)symbol > 47 && (int)symbol < 58)
                Console.WriteLine("digit");
            else
                Console.WriteLine("other");
        }
    }
}
