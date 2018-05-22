using System;

namespace ConvertSpeedUnits
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int distanceInMeters = int.Parse(Console.ReadLine());

            float hours   = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());

            float totalSeconds = ( hours * 3600 ) +
                                 ( minutes * 60 ) +
                                   seconds;
            
            float mtPerSecs =   distanceInMeters / totalSeconds;
            var kmPerHous   =  (distanceInMeters / totalSeconds) * 3.6;
            var miPerHour   = ((distanceInMeters / totalSeconds) * 3.6) / 1.609;

            Console.WriteLine($"{mtPerSecs:0.######}");
            Console.WriteLine($"{kmPerHous:0.######}");
            Console.WriteLine($"{miPerHour:0.######}");
        }
    }
}
