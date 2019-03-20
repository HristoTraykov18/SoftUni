using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNASequences
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            var letter1 = "";
            var letter2 = "";
            var letter3 = "";
            var sign = "";
            for (int i = 1; i < 5; i++)
            {
                if (i == 1)
                    letter1 = "A";
                else if (i == 2)
                    letter1 = "C";
                else if (i == 3)
                    letter1 = "G";
                else if (i == 4)
                    letter1 = "T";
                for (int k = 1; k < 5; k++)
                {
                    if (k == 1)
                        letter2 = "A";
                    else if (k == 2)
                        letter2 = "C";
                    else if (k == 3)
                        letter2 = "G";
                    else if (k == 4)
                        letter2 = "T";
                    for (int j = 1; j < 5; j++)
                    {
                        if (j == 1)
                            letter3 = "A";
                        else if (j == 2)
                            letter3 = "C";
                        else if (j == 3)
                            letter3 = "G";
                        else if (j == 4)
                            letter3 = "T";
                        if ((i + k + j) >= input)
                            sign = "O";
                        else
                            sign = "X";
                        Console.Write(sign + letter1 + letter2 + letter3 + sign + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
