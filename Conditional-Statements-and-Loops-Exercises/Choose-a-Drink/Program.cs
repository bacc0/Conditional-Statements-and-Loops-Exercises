using System;
using System.Threading;
using System.Xml.Schema;

namespace cup
{
    class Program
    {
        static void Main(string[] args)
        {
            var profession = Console.ReadLine().ToLower();

            if (profession == "athlete")
            {
                Console.WriteLine("Water");
            }
            else if (profession == "businessman" || profession == "businesswoman")
            {
                Console.WriteLine("Coffee");
            }
            else if (profession == "softuni student")
            {
                Console.WriteLine("Beer");
            }
            else if (profession != "softuni student" ||
                     profession != "businesswoman" ||
                     profession != "businessman" ||
                     profession != "athlete")
            {
                Console.WriteLine("Tea");
            }
        }
    }
}

