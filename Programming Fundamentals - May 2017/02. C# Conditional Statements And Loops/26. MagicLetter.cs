using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter1 = char.Parse(Console.ReadLine());
            char letter2 = char.Parse(Console.ReadLine());
            char letter3 = char.Parse(Console.ReadLine());

            for (int i = (int)letter1; i <= (int)letter2; i++)
            {
                if (i == (int)letter3)
                    continue;
                for (int k = (int)letter1; k <= (int)letter2; k++)
                {
                    if (k == (int)letter3)
                        continue;
                    for (int j = (int)letter1; j <= (int)letter2; j++)
                    {
                        if (j == (int)letter3)
                            continue;
                        else
                            Console.Write($"{(char)i}{(char)k}{(char)j} ");
                    }
                }
            }
        }
    }
}
