using System;
using System.Numerics;

namespace TheaThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            double picturesTaken = double.Parse(Console.ReadLine());
            double filterTime = double.Parse(Console.ReadLine());
            double filterFactor = double.Parse(Console.ReadLine());
            double uploadTime = double.Parse(Console.ReadLine());

            double filteredPictures = Math.Ceiling(picturesTaken * filterFactor / 100);
            double seconds = (filterTime * picturesTaken) + (filteredPictures * uploadTime);
            TimeSpan time = TimeSpan.FromSeconds(seconds);
            Console.WriteLine($"{time.Days:D1}:{time.Hours:D2}:{time.Minutes:D2}:{time.Seconds:D2}");
        }
    }
}
