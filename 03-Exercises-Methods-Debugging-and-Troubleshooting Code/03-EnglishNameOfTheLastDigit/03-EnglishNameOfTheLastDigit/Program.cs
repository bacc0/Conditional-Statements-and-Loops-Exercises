using System;

namespace r
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string num = Console.ReadLine();

            PrintLaastDigit(num);
        }

        static void PrintLaastDigit(string number)
        {
            char laastDigit = number[number.Length - 1];

            switch (laastDigit)
            {
                case '0':
                    Console.WriteLine("zero");
                    break;
                case '1':
                    Console.WriteLine("one");
                    break;
                case '2':
                    Console.WriteLine("two");
                    break;
                case '3':
                    Console.WriteLine("three");
                    break;
                case '4':
                    Console.WriteLine("four");
                    break;
                case '5':
                    Console.WriteLine("five");
                    break;
                case '6':
                    Console.WriteLine("six");
                    break;
                case '7':
                    Console.WriteLine("seven");
                    break;
                case '8':
                    Console.WriteLine("eight");
                    break;
                default:
                    Console.WriteLine("nine");
                    break;
            }
        }
    }
}

