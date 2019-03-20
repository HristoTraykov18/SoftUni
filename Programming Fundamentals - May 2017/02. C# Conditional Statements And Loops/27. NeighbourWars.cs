using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeighbourWars
{
    class Program
    {
        static void Main(string[] args)
        {
            int peshoDamage = int.Parse(Console.ReadLine());
            int goshoDamage = int.Parse(Console.ReadLine());
            int peshoHP = 100, goshoHP = 100, round = 1, defendingHP = 100;
            var user = "";
            var winner = "";
            var ability = "";
            var defending = "";
            while (defendingHP > 1)
            {
                if (round % 2 == 0)
                {
                    peshoHP -= goshoDamage;
                    user = "Gosho";
                    defending = "Pesho";
                    defendingHP = peshoHP;
                    ability = "Thunderous fist";
                }
                else if (round % 2 == 1)
                {
                    goshoHP -= peshoDamage;
                    user = "Pesho";
                    defending = "Gosho";
                    defendingHP = goshoHP;
                    ability = "Roundhouse kick";
                }
                if (defendingHP < 1)
                    break;
                Console.WriteLine($"{user} used {ability} and reduced {defending} to {defendingHP} health.");
                if (round % 3 == 0)
                {
                    goshoHP += 10;
                    peshoHP += 10;
                }
                round++;
            }
            if (goshoHP < 1)
                winner = "Pesho";
            else if (peshoHP < 1)
                winner = "Gosho";
            Console.WriteLine($"{winner} won in {round}th round.");
        }
    }
}
