using System;

namespace cup
{
    class Program
    {
        static void Main(string[] args)
        {
            var SingleWord = Console.ReadLine();

            char last = SingleWord[SingleWord.Length - 1];
            char first = SingleWord[SingleWord.Length - 2];

            if (last == 'y')
            {
                SingleWord = SingleWord.Remove(SingleWord.Length - 1);
                Console.WriteLine(SingleWord + "ies");
            }

            else if (last == 'o' ||
                     last == 's' ||
                     last == 'x' ||
                     last == 'z' ||
                            (first == 'c' && last == 'h' ||
                             first == 's' && last == 'h'))
            {
                Console.WriteLine(SingleWord + "es");
            }

            else
            {
                Console.WriteLine(SingleWord + "s");
            }
        }
    }
}