using System;

namespace VowelorDigit
{
    class MainClass
    {
        public static void Main(string[] args)
        {
                char simbol = char.Parse(Console.ReadLine());
            
            if (simbol == 'a' ||
                simbol == 'e' ||
                simbol == 'i' ||
                simbol == 'o' ||
                simbol == 'u' ||
                simbol == 'y')
            {
                Console.WriteLine("vowel");
            }
            else if (simbol >= '0' && '9' >= simbol)
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
