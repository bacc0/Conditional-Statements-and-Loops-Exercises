using System;
using System.Collections.Generic;
using System.Linq;

namespace test
{
    class MainClass
    {
        public static void Main(string[] args)

        {
            var size = int.Parse(Console.ReadLine());

            var field = new int[size];

            var ladybugIndex = Console.ReadLine()
                                      .Split(new[]{ ' ' }
                                             ,StringSplitOptions
                                             .RemoveEmptyEntries)
                                      .Select(int.Parse)
                                      .Where(x => x >= 0 && x < size)
                                      .ToList();

            foreach (var index in ladybugIndex)
            {
                field[index] = 1;
            }

            while (true)
            {
                var line = Console.ReadLine();

                if (line == "end")
                {
                    break;
                }

                var commandParts = line.Split(' ');

                var currentLadybug = int.Parse(commandParts[0]); 
                var direction      = commandParts[1]; 
                var flyLenght      = int.Parse(commandParts[2]); 

                if (direction == "left")
                {
                    flyLenght *= -1;
                }

                if ( currentLadybug <  0  ||
                     currentLadybug >= size )
                {
                    continue;
                }

                if ( field[currentLadybug] == 0 )
                {
                    continue;
                }

                field[currentLadybug] = 0;


                var nextIndexToLand = currentLadybug;


                while (true)
                {
                    nextIndexToLand += flyLenght;

                    if ( nextIndexToLand <  0  ||
                         nextIndexToLand >= size )
                    {
                        break;
                    }

                    if (field[nextIndexToLand] == 1)
                    {
                        continue;
                    }

                    field[nextIndexToLand] = 1;
                    break;
                }



            }
            Console.WriteLine(string.Join(" ", field));
        }
    }
}
















//using System.Linq;

//namespace test
//{
//    class MainClass
//    {
//        public static void Main(string[] args)


//        {
//            var numbers = Console.ReadLine()
//                                 .Split()
//                                 .Select(int.Parse)
//                                 .ToList();

//            var comands = Console.ReadLine()
//                                 .Split()
//                                 .Select(int.Parse)
//                                 .ToList();

//            var bomb = comands[0];
//            var power = comands[1];


//            while (numbers.Contains(bomb))
//            {
//                var positoion = numbers.IndexOf(bomb);

//                if (positoion - power < 0 && positoion + power > numbers.Count)
//                {
//                    numbers.Clear();
//                }

//                else if (positoion - power < 0)
//                {
//                    numbers.RemoveRange(0, positoion + 1 + power);
//                }

//                else if (positoion + power >= numbers.Count)
//                {
//                    numbers.RemoveRange(positoion - power,
//                                        power + 1 + numbers.Count - 1 - positoion);
//                }

//                else
//                {
//                    numbers.RemoveRange(positoion - power,
//                                        power * 2 + 1);
//                }
//            }
//            Console.WriteLine(numbers.Sum());
//        }
//    }
//}
