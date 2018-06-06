using System;
using System.Collections.Generic;
using System.Linq;


namespace BombNumbers
{
    class MainClass

    {
        public static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                       .Split(' ')
                                       .Select(int.Parse)
                                       .ToList();

            List<int> comands = Console.ReadLine()
                                       .Split(' ')
                                       .Select(int.Parse)
                                       .ToList();
            int sum   = 0;
            int bomb  = comands[0];
            int power = comands[1];

            while (numbers.Contains(bomb))
            {
                int position = numbers.IndexOf(bomb);

                if( position - power < 0  && 
                    position + power > numbers.Count )
                {
                    numbers.Clear();
                }
                else if(position - power < 0 )
                {
                    numbers.RemoveRange(0, 1  + power + position - 0);
                }
                else if (position + power > numbers.Count)
                {
                    numbers.RemoveRange(position - power, power + 1 + numbers.Count - 1 - position);
                }
                else
                {
                    numbers.RemoveRange(position - power, 2 * power + 1);
                }
            }
            Console.WriteLine(sum = numbers.Sum());
        }
    }
}
