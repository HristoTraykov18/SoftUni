using System;

namespace BoatSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstBoatChar = char.Parse(Console.ReadLine());
            char secondBoatChar = char.Parse(Console.ReadLine());
            int followingLines = int.Parse(Console.ReadLine());
            int firstBoatPosition = 0;
            int secondBoatPosition = 0;
            int upgrades = 0;
            for (int i = 1; i <= followingLines; i++)
            {
                if (firstBoatPosition > 49)
                {
                    Console.WriteLine((char)(firstBoatChar + upgrades));
                    break;
                }
                else if (secondBoatPosition > 49)
                {
                    Console.WriteLine((char)(secondBoatChar + upgrades));
                    break;
                }
                string userInput = Console.ReadLine();
                if (userInput == "UPGRADE")
                    upgrades += 3;
                else
                {
                    if (i % 2 == 1)
                        firstBoatPosition += userInput.Length;
                    else if (i % 2 == 0)
                        secondBoatPosition += userInput.Length;
                }
            }
            if (firstBoatPosition > secondBoatPosition && firstBoatPosition < 50)
                Console.WriteLine((char)(firstBoatChar + upgrades));
            else if (secondBoatPosition > firstBoatPosition && secondBoatPosition < 50)
                Console.WriteLine((char)(secondBoatChar + upgrades));
        }
    }
}
