using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPMCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            int BPM = int.Parse(Console.ReadLine());
            int numOfBeats = int.Parse(Console.ReadLine());
            double bars = Math.Round((numOfBeats / 4.0), 1);
            double seconds = (numOfBeats * 1.0 / BPM) * 60;
            int minutes = 0;
            while (seconds > 59)
            {
                minutes++;
                seconds -= 60;
            }
            Console.WriteLine($"{bars} bars - {minutes}m {(int)seconds}s");
        }
    }
}
