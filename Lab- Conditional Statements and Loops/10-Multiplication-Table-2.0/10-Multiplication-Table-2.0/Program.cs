using System;

namespace _10_Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var theInteger = int.Parse(Console.ReadLine());
            var times = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{theInteger} X {times} = {theInteger * times}");

                times++;

                if (times > 10)
                    return;
            }
        }
    }
}
