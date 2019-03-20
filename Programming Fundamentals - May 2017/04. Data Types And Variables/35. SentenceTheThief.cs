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
            long minNumber = 0;
            switch (numeralType)
            {
                case "sbyte":
                    maxNumber = sbyte.MaxValue;
                    minNumber = sbyte.MinValue;
                    break;
                case "int":
                    maxNumber = int.MaxValue;
                    minNumber = int.MinValue;
                    break;
                case "long":
                    maxNumber = long.MaxValue;
                    minNumber = long.MinValue;
                    break;
            }
            long id = long.MinValue;
            for (int i = 0; i < idCount; i++)
            {
                long currentId = long.Parse(Console.ReadLine());
                if (currentId > id && currentId <= maxNumber)
                    id = currentId;
            }
            long sentenceLength = 0;
            long comparedToMinValue = Math.Abs(id - sbyte.MinValue);
            long comparedToMaxValue = Math.Abs(id - sbyte.MaxValue);
            if (comparedToMaxValue > comparedToMinValue)
                sentenceLength = (long)Math.Ceiling((double)id / -128);
            else
                sentenceLength = (long)Math.Ceiling((double)id / 127);
            string sentence = $"Prisoner with id {id} is sentenced to {sentenceLength} years";
            if (sentenceLength == 1)
                sentence = sentence.Remove(sentence.Length -1);
            Console.WriteLine(sentence);
        }
    }
}
