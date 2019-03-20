using System;
using System.Linq;
using System.Collections.Generic;

namespace LIS
{
    class Program
    {
        static void Main(string[] args)
        {
            string nums = Console.ReadLine();
            List<int> numList = nums.Split(' ').Select(Int32.Parse).ToList();
            int[] lengths = new int[numList.Count];
            int[] prev = new int[numList.Count];

            for (int i = 0; i < numList.Count; i++)
            {
                lengths[i] = 1;
                prev[i] = -1;
            }

            for (int i = 0; i < numList.Count; i++)
            {
                for (int k = 0; k < i; k++) 
                {
                    if (prev[i] == -1 && numList.ElementAt(i) > numList.ElementAt(k) ||
                        prev[i] > -1 && numList.ElementAt(i) > numList.ElementAt(k) && numList.ElementAt(prev[i]) < numList.ElementAt(k) ||
                        lengths[i] == lengths[k] && numList.ElementAt(i) > numList.ElementAt(k))
                    {
                        lengths[i]++;
                        prev[i] = k;
                    }
                }
            }

            int biggestLength = int.MinValue;
            int currIndex = 0;
            for (int i = 0; i < lengths.Length; i++)
            {
                if (lengths[i] > biggestLength)
                {
                    biggestLength = lengths[i];
                    currIndex = i;
                }
            }
            
            List<int> LIS = new List<int> {};
            for (int i = 0; i < biggestLength; i++)
            {
                if (currIndex > -1)
                {
                    LIS.Insert(0, numList.ElementAt(currIndex));
                    currIndex = prev[currIndex];
                }
            }
            
            string output = "";
            if (numList.Count != 1)
            {
                foreach (int n in LIS)
                    output += n.ToString() + " ";
                output = output.Remove(output.Length - 1);
            }
            else
                output = numList.ElementAt(0).ToString();
            Console.WriteLine(output);
        }
    }
}