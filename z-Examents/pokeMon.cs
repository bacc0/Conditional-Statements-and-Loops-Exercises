using System;

namespace pokeMon
{
    class MainClass
    {
        public static void Main(string[] args)

        {
            var power           = int.Parse(Console.ReadLine());
            var distance        = int.Parse(Console.ReadLine());
            var exhaustingIndex = int.Parse(Console.ReadLine());

            var counter = 0;
            var currentPower = power;

            while (currentPower >= distance)
            {
                currentPower -= distance;
                counter++;

                if (currentPower == power / 2  &&
                                    power % 2 == 0)
                {
                    currentPower /= exhaustingIndex;
                }
            }

            Console.WriteLine(currentPower);
            Console.WriteLine(counter);
        }
    }
}
