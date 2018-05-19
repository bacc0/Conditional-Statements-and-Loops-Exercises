using System;

namespace _03_Back_in_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());

            minutes += 30;

            if (minutes > 59)
            {
                minutes -= 60;
                hours += 1;
            }
            if (hours > 23)
            {
                hours = 0;
            }
            Console.WriteLine($"{hours}:{minutes:D2}");
        }
    }
}
