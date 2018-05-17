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

            for (char one = first; one <= last; one++)
            {
                for (char two = first; two <= last; two++)
                {
                    for (char three = first; three <= last; three++)
                    {
                        if (one == magic ||
                             two == magic ||
                             three == magic)
                        {

                        }
                        else
                        {
                            Console.Write($"{one}{two}{three} ");
                        }
                    }
                }
            }
        }
    }
}
