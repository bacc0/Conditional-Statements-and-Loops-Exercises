using System;

namespace cup
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());

            int first = 0;
            int second = 0;

            bool notNumber = false;
            var count = 0;

            for (int i = n; i <= m; i++)
            {
                for (int j = n; j <= m; j++)
                {
                    count++;

                    if (i + j == magicNum)
                    {
                        notNumber = true;

                        first = i;
                        second = j;
                    }
                }
            }
            if (notNumber == false)
            {
                Console.WriteLine($"{count} combinations - neither equals {magicNum}");
            }
            else
            {
                Console.WriteLine($"Number found! {first} + {second} = {magicNum}");
            }
        }
    }
}
