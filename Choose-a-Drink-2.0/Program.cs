using System;
using System.Threading;
using System.Xml.Schema;

namespace cup
{
    class Program
    {
        static void Main(string[] args)
        {
            var profession = Console.ReadLine();
            var quantity = int.Parse(Console.ReadLine());

            var water = 0.70;
            var coffee = 1.00;
            var beer = 1.70;
            var tea = 1.20;

            if (profession == "Athlete")
            {
                var result = quantity * water;
                Console.WriteLine($"The {profession} has to pay {result:f2}.");
            }
            else if (profession == "Businessman" ||
                     profession == "Businesswoman")
            {
                var result = quantity * coffee;
                Console.WriteLine($"The {profession} has to pay {result:f2}.");
            }
            else if (profession == "SoftUni Student")
            {
                var result = quantity * beer;
                Console.WriteLine($"The {profession} has to pay {result:f2}.");
            }
            else if (profession != "SoftUni Student" ||
                     profession != "Businesswoman" ||
                     profession != "Businessman" ||
                     profession != "Athlete")
            {
                var result = quantity * tea;
                Console.WriteLine($"The {profession} has to pay {result:f2}.");
            }
        }
    }
}



