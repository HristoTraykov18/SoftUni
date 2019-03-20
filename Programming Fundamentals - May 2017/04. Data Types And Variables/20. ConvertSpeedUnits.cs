using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            int distInMeters = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());
            int minutesInitial = minutes;
            int secondsInitial = seconds;
            for (int i = 0; i < hours; i++)
                minutes += 60;
            for (int i = 0; i < minutes; i++)
                seconds += 60;
            float hoursInFloat = hours;
            hoursInFloat += (float)minutesInitial / 60 + (float)secondsInitial / 3600;
            Console.WriteLine((float)distInMeters / seconds);
            Console.WriteLine(((float)distInMeters / 1000) / hoursInFloat);
            Console.WriteLine(((float)distInMeters / 1609) / hoursInFloat);
        }
    }
}
