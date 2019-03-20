using System;
using System.Numerics;

namespace DifferentIntSize
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger m = BigInteger.Parse(Console.ReadLine());
            try
            {
                long n = (long)m;
                if (n > 0)
                {
                    if (n >= sbyte.MinValue && n <= sbyte.MaxValue)
                        Console.WriteLine($"{n} can fit in:\n* sbyte\n* byte\n* short\n* ushort\n* int\n* uint\n* long");
                    else if (n >= byte.MinValue && n <= byte.MaxValue)
                        Console.WriteLine($"{n} can fit in:\n* byte\n* short\n* ushort\n* int\n* uint\n* long");
                    else if (n >= short.MinValue && n <= short.MaxValue)
                        Console.WriteLine($"{n} can fit in:\n* short\n* ushort\n* int\n* uint\n* long");
                    else if (n >= ushort.MinValue && n <= ushort.MaxValue)
                        Console.WriteLine($"{n} can fit in:\n* ushort\n* int\n* uint\n* long");
                    else if (n >= int.MinValue && n <= int.MaxValue)
                        Console.WriteLine($"{n} can fit in:\n* int\n* uint\n* long");
                    else if (n >= uint.MinValue && n <= uint.MaxValue)
                        Console.WriteLine($"{n} can fit in:\n* uint\n* long");
                    else if (n >= long.MinValue && n <= long.MaxValue)
                        Console.WriteLine($"{n} can fit in:\n* long");
                }
                else
                {
                    if (n >= sbyte.MinValue && n <= sbyte.MaxValue)
                        Console.WriteLine($"{n} can fit in:\n* sbyte\n* short\n* int\n* long");
                    else if (n >= short.MinValue && n <= short.MaxValue)
                        Console.WriteLine($"{n} can fit in:\n* short\n* int\n* long");
                    else if (n >= int.MinValue && n <= int.MaxValue)
                        Console.WriteLine($"{n} can fit in:\n* int\n* long");
                    else if (n >= long.MinValue && n <= long.MaxValue)
                        Console.WriteLine($"{n} can fit in:\n* long");
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine($"{m} can't fit in any type");
            }
        }
    }
}
