using System;
using System.Linq;

namespace ladybugs
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
