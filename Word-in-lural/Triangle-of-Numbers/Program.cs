using System;

namespace cup
{
    class Program
    {
        static void Main(string[] args)
        {
            int integer = int.Parse(Console.ReadLine());

            for (int i = 1; i <= integer; i++)
            {
                for (int s = 1; s <= i; s++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

//  5    1
//       2 2 
//       3 3 3
//       4 4 4 4
//       5 5 5 5 5
