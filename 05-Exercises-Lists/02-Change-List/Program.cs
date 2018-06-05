using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeList
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                                    .Split(' ')
                                    .Select(int.Parse)
                                    .ToList();

            string[] input = Console.ReadLine()
                                    .Split(' ')
                                    .ToArray();

            while (input[0] != "Odd" && input[0] != "Even")
            {
                if (input[0] == "Delete")
                {
                    nums.RemoveAll(n => n == int.Parse(input[1]));
                }
                else if (input[0] == "Insert")
                {
                    int element = int.Parse(input[1]);
                    int position = int.Parse(input[2]);
                    nums.Insert(position, element);
                }

                input = Console.ReadLine()
                               .Split(' ')
                               .ToArray();
            }

            if (input[0] == "Odd")
            {
                nums.RemoveAll(x => x % 2 == 0);

            }
            else if (input[0] == "Even")
            {
                nums.RemoveAll(x => x % 2 != 0);
            }

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
