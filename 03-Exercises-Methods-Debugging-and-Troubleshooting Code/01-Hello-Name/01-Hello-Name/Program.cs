using System;

namespace HelloName
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string name = Console.ReadLine();

            HelloByName(name);
        }

        static void HelloByName(string helloName)
        {
            Console.WriteLine($"Hello, {helloName}!");
        }
    }
}
