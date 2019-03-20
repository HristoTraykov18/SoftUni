using System;
using System.Linq;
using System.Collections.Generic;

namespace MaxEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string nums = Console.ReadLine();
            List<int> numList = nums.Split(' ').Select(Int32.Parse).ToList();

            int seqLen = 1;
            int seqStart = 0;
            int longestLen = 1;
            int longestStart = 0;

            for (int i = 1; i < numList.Count; i++)
            {
                if (numList.ElementAt(i) == numList.ElementAt(i - 1))
                {
                    seqLen++;
                    if (i == numList.Count - 1 && longestLen < seqLen)
                    {
                        longestLen = seqLen;
                        longestStart = seqStart;
                    }
                }
                else
                {
                    if (longestLen < seqLen)
                    {
                        longestLen = seqLen;
                        longestStart = seqStart;
                    }
                    seqLen = 1;
                    seqStart = i;
                }
            }
            
            for (int i = longestStart; i < longestStart + longestLen; i++)
            {
                Console.Write(numList.ElementAt(i));
                if (i < longestStart + longestLen)
                    Console.Write(" ");
            }
        }
    }
}
