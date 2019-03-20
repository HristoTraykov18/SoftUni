using System;
using System.Linq;

namespace JumpAround
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int sum = numArray[0];
            int pos = 0;
            int index = numArray[0];
            while (true)
            {
                try 
                {
                    sum += numArray[pos + index];
                    int temp = index;
                    index = numArray[pos + index];
                    pos += temp;
                }
                catch (IndexOutOfRangeException)
                {
                    try 
                    {
                        sum += numArray[pos - index];
                        int temp = index;
                        index = numArray[pos - index];
                        pos -= temp;
                    }
                    catch (IndexOutOfRangeException)
                    {
                        Console.WriteLine(sum);
                        break;
                    }
                }
            }
        }
    }
}