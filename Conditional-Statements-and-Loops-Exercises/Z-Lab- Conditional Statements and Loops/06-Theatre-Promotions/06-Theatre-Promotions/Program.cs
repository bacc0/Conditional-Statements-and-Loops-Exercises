using System;

namespace _06_Theatre_Promotions
{
    class Program
    {
        static void Main(string[] args)
        {
            var typeOfDay = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());

            var price = 0;
            bool ageValid = true;

            if (age < 0 || 122 < age)
            {
                Console.WriteLine("Error!");
                ageValid = false;
            }

            else if (age <= 64 && 18 < age)
            {
                switch (typeOfDay)
                {
                    case "Weekday":
                        price += 18; break;

                    case "Weekend":
                        price += 20; break;

                    case "Holiday":
                        price += 12; break;

                    default: break;
                }
            }
            else
            {
                switch (typeOfDay)
                {
                    case "Weekday":
                        price += 12; break;

                    case "Weekend":
                        price += 15; break;

                    default: break;
                }

                if (age <= 18 && typeOfDay == "Holiday")
                {
                    price += 5;
                }
                else if (age > 64 && typeOfDay == "Holiday")
                {
                    price += 10;
                }
            }
            if (ageValid == true)
            {
                Console.WriteLine(price + "$");
            }
        }
    }
}
