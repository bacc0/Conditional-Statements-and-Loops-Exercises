using System;
using System.Collections.Generic;
using System.Linq;


namespace PhonebookUpgrade
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();

            string[] input = Console.ReadLine()
                                    .Split(' ')
                                    .ToArray();

            while (input[0] != "END")
            {
                if (input[0] == "A")
                {
                    if (!phonebook.ContainsKey(input[1]))
                    {
                        phonebook.Add(input[1], input[2]);
                    }
                    else
                    {
                        phonebook[input[1]] = input[2];
                    }
                }
                else if (input[0] == "S")
                {
                    if (!phonebook.ContainsKey(input[1]))
                    {
                        Console.WriteLine($"Contact {input[1]} does not exist.");
                    }
                    else
                    {
                        Console.WriteLine($"{input[1]} -> {phonebook[input[1]]}");
                    }
                }
                else if (input[0] == "ListAll")
                {
                    foreach (var contact in phonebook.OrderBy(c => c.Key))
                    {
                        Console.WriteLine($"{contact.Key} -> {contact.Value}");
                    }
                }

                input = Console.ReadLine()
                                   .Split(' ')
                                   .ToArray();
            }
        }
    }
}
