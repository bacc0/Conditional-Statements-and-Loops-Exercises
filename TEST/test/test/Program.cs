using System;
using System.Collections.Generic;
using System.Linq;

namespace test
{
    class MainClass
    {
        public static void Main()
        {
            var input = "012345678 hh bhhu";
            var split = input.Split(new []{  ' ', }, StringSplitOptions.RemoveEmptyEntries);


            Console.WriteLine(split[0]);

        }
    }
}
