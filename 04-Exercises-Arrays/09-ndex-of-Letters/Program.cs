using System;
using System.Linq;
 
 
namespace ndexofLetters
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            char[] alphabet = new char[26];
 
            for (char i = 'a'; i <= 'z' ; i++)
            {
                alphabet[i - 'a'] = i;
            }
 
            string input = Console.ReadLine();
            var inputArr = input.ToArray();
 
            for (int i = 0; i < inputArr.Length ; i++)
            {
                for (int j = 0; j < alphabet.Length ; j++)
                {
                    if (inputArr[i] == alphabet[j])
                    {
                        Console.WriteLine($"{alphabet[j]} -> {j}");
                    }
                }
            }
        }
    }
}
