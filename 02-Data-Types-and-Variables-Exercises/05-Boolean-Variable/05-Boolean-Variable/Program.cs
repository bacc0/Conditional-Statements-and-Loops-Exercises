using System;

namespace BooleanVariable
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();

            bool output = Convert.ToBoolean(input);

            if (output == true)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
