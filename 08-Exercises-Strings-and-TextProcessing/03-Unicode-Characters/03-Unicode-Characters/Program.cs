using System;

namespace UnicodeCharacters
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();

            foreach (var item in input)
            {
               string result = GetEscape(item);
               Console.Write(result);
            }
        }


        public static string GetEscape(char c)
        {
            return "\\u" + ((int)c)
                                .ToString("X4")
                                .ToLower();
        }
    }
}
