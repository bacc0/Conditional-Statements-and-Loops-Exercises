﻿using System;
using System.Collections.Generic;
using System.Linq;


namespace SearchforaNumber
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                       .Split(' ')
                                       .Select(int.Parse)
                                       .ToList();

            int[] commands = Console.ReadLine()
                                    .Split(' ')
                                    .Select(int.Parse)
                                    .ToArray();

            if( numbers.Take(commands[0])
                       .Skip(commands[1])
                       .Contains(commands[2]) )
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }                            
    }
}
