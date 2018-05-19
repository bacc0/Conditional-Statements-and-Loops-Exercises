using System;

namespace cup
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());

            var startNum = 0;
            var endNum = 0;

            if (a < b)
            {
                startNum = a;
                endNum = b;
            }
            else
            {
                startNum = b;
                endNum = a;
            }

            for (int i = startNum; i <= endNum; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}