using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchTheThief
{
    class Program
    {
        static void Main(string[] args)
        {
            string numeralType = Console.ReadLine();
            int idCount = int.Parse(Console.ReadLine());
            long maxNumber = 0;
            switch (numeralType)
            {
                case "sbyte":
                    maxNumber = sbyte.MaxValue;
                    break;
                case "int":
                    maxNumber = int.MaxValue;
                    break;
                case "long":
                    maxNumber = long.MaxValue;
                    break;
            }
            long prevousId = long.MinValue;
            for (int i = 0; i < idCount; i++)
            {
                long currentId = long.Parse(Console.ReadLine());
                if (currentId > prevousId && currentId <= maxNumber)
                    prevousId = currentId;
            }
            Console.WriteLine(prevousId);
        }
    }
}
