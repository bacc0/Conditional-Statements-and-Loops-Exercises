using System;
using System.Collections.Generic;
using System.Linq;

namespace charityMarathon
{
    class MainClass
    {
        public static void Main(string[] args)

        {
            var marathonDays   = long.Parse(Console.ReadLine());
            var runners        = long.Parse(Console.ReadLine());
            var avarLapsRunner = long.Parse(Console.ReadLine());
            var trackLentght   = long.Parse(Console.ReadLine());
            var capacity       = long.Parse(Console.ReadLine());
            var moneyPerKm     = double.Parse(Console.ReadLine());

            var maxRunners = capacity * marathonDays;
            runners  = Math.Min(maxRunners, runners);

            var totalMeters = trackLentght * avarLapsRunner * runners;
            var totalKm = totalMeters / 1000.0; 

            var money = totalKm * moneyPerKm;

            Console.WriteLine($"Money raised: {money:f2}");
        }
    }
}
