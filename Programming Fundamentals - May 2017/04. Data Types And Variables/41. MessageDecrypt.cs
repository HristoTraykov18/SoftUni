using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageDecrypt
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int linesToFollow = int.Parse(Console.ReadLine());
            string message = "";
            for (int i = 0; i < linesToFollow; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                message += (char)(letter + key);
            }
            Console.WriteLine(message);
        }
    }
}
