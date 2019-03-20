using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoGallery
{
    class Program
    {
        static void Main(string[] args)
        {
            int photoNumber = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int hour = int.Parse(Console.ReadLine());
            int minute = int.Parse(Console.ReadLine());
            int size = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: DSC_{photoNumber:d4}.jpg");
            Console.WriteLine($"Date Taken: {day:d2}/{month:d2}/{year} {hour:d2}:{minute:d2}");
            if (size <= 999)
                Console.WriteLine($"Size: {size}B");
            else if (size > 999 && size <= 999999)
                Console.WriteLine($"Size: {(double)Math.Round((size / 1000.0), 1)}KB");
            else
                Console.WriteLine($"Size: {(double)Math.Round((size / 1000000.0), 1)}MB");
            Console.Write($"Resolution: {width}x{height}");
            if (width > height)
                Console.WriteLine(" (landscape)");
            else if (width == height)
                Console.WriteLine(" (square)");
            else
                Console.WriteLine(" (portrait)");
        }
    }
}
