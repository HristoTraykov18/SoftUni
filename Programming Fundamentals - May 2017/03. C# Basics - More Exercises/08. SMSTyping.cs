using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMSTyping
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var sms = "";
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                int digitsLength = input.Length;
                int mainDigit = (input[0] - 48);
                if (mainDigit == 0)
                    sms += (char)(32);
                else
                {
                    int offset = (mainDigit - 2) * 3;
                    if (mainDigit == 8 || mainDigit == 9)
                        offset++;
                    int letterIndex = (offset + digitsLength - 1);
                    char letter = (char)(letterIndex + 97);
                    sms += letter;
                }
            }
            Console.WriteLine(sms);
        }
    }
}
