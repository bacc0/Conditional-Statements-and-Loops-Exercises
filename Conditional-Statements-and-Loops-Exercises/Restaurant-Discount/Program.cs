using System;
using System.Threading;
using System.Xml.Schema;

namespace tESt
{
    class Program
    {
        static void Main(string[] args)
        {
            var sizeGroup = int.Parse(Console.ReadLine());
            var package = Console.ReadLine();

            double totalPrice = 0;

            if (sizeGroup > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
            else
            {
                if (sizeGroup <= 50)
                {
                    Console.WriteLine($"We can offer you the Small Hall");

                    if (package == "Normal")
                    {
                        totalPrice = (2500 + 500) * 0.95; // 5%
                    }
                    if (package == "Gold")
                    {
                        totalPrice = (2500 + 750) * 0.90; // 10%
                    }
                    if (package == "Platinum")
                    {
                        totalPrice = (2500 + 1000) * 0.85; // 15%
                    }
                }
                else if (sizeGroup <= 100)
                {
                    Console.WriteLine($"We can offer you the Terrace");

                    if (package == "Normal")
                    {
                        totalPrice = (5000 + 500) * 0.95; // 5%
                    }
                    if (package == "Gold")
                    {
                        totalPrice = (5000 + 750) * 0.90; // 10%
                    }
                    if (package == "Platinum")
                    {
                        totalPrice = (5000 + 1000) * 0.85; // 15%
                    }
                }
                else if (sizeGroup <= 120)
                {
                    Console.WriteLine($"We can offer you the Great Hall");

                    if (package == "Normal")
                    {
                        totalPrice = (7500 + 500) * 0.95; // 5%
                    }
                    if (package == "Gold")
                    {
                        totalPrice = (7500 + 750) * 0.90; // 10%
                    }
                    if (package == "Platinum")
                    {
                        totalPrice = (7500 + 1000) * 0.85; // 15%
                    }
                }
                var pricePerPerson = totalPrice / sizeGroup;

                Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
            }
        }
    }
}

