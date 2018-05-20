using System;

namespace cup
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char last = char.Parse(Console.ReadLine());
            char magic = char.Parse(Console.ReadLine());

            for (var a = first; a <= last; a++)
            {
                for (var b = first; b <= last; b++)
                {
                    for (var c = first; c <= last; c++)
                    {
                        if (a != magic &&
                            b != magic &&
                            c != magic)
                        {
                            Console.Write($"{a}{b}{c} ");
                        }
                    }
                }
            }
        }
    }
}
