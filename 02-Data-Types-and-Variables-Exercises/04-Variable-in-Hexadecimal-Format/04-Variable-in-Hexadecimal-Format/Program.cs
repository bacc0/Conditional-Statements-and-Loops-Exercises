using System;

namespace VariableinHexadecimalFormat
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var output = Convert.ToInt32(input, 16);
            Console.WriteLine(output);
        }
    }
}
