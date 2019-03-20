using System;

namespace DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            if (day - 1 > -1 && day - 1 < 7)
                Console.WriteLine(daysOfWeek[day - 1]);
            else
                Console.WriteLine("Invalid day!");
        }
    }
}
