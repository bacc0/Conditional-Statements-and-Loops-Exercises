using System;
using System.Linq;


namespace ndexofLetters
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var alphabet = new char[26];

            for (char i = 'a'; i <='z'; i++)
            {
                alphabet[i - 'a'] = i;
            }
            string input = Console.ReadLine();

            var arr = input.ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (input[i] == alphabet[j])
                    {
                        Console.WriteLine(input[i] + " -> " + j);
                    }
                }
            }
        }
    }
}
