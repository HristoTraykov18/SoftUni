using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            int openingBrackets = 0;
            int closingBrackets = 0;
            bool isBalanced = true;
            for (int i = 0; i < numberOfLines; i++)
            {
                string input = Console.ReadLine();
                if (closingBrackets > openingBrackets || (openingBrackets > closingBrackets + 1))
                    isBalanced = false;
                if (input == "(")
                    openingBrackets++;
                else if (input == ")")
                    closingBrackets++;
            }
            if (openingBrackets != closingBrackets)
                isBalanced = false;
            if (isBalanced)
                Console.WriteLine("BALANCED");
            else
                Console.WriteLine("UNBALANCED");
        }
    }
}
