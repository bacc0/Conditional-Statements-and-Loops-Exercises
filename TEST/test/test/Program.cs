using System;
using System.Collections.Generic;
using System.Linq;

namespace test
{
    class MainClass
    {
        public static void Main()
        {
<<<<<<< HEAD
            var input = Console.ReadLine();
=======
            var data = Console.ReadLine();
>>>>>>> 405b14fa987cfa27095e2a73b7d2da86d4c534ed

            var totalPopulation = new Dictionary<string, Dictionary<string, long>>();

            while (data != "report")
            {
<<<<<<< HEAD
                var handInfo = input.Split(new char[] { ':', ',', ' ' }
                                    ,StringSplitOptions
                                    .RemoveEmptyEntries);

                var name = handInfo[0];

                if ( !houseOfCards.ContainsKey(name))
                {
                    houseOfCards.Add(name, new Dictionary<int, HashSet<int>>());
=======
                var input = data.Split('|');

                var state = input[1];
                var town = input[0];
                var population = long.Parse(input[2]);

>>>>>>> 405b14fa987cfa27095e2a73b7d2da86d4c534ed

                if (!totalPopulation.ContainsKey(state))
                {
                    totalPopulation[state] = new Dictionary<string, long>();
                }
                if (!totalPopulation[state].ContainsKey(town))
                {
                    totalPopulation[state][town] = 0;
                }

                totalPopulation[state][town] += population;

                data = Console.ReadLine();
            }

            foreach (var country in totalPopulation.OrderByDescending(x => x.Value.Values.Sum()))
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value.Values.Sum()})");

                foreach (var townAndPopulation in country.Value.OrderByDescending(x => x.Value))
                {
<<<<<<< HEAD
                    var currentCard = handInfo[i]; //.Trim();

                    int face = 0;
                    int suite = 0;
=======
                    Console.WriteLine($"=>{townAndPopulation.Key}: {townAndPopulation.Value}");
                }
            }
        }
    }
}

//namespace test
//{
//    class MainClass
//    {
//        public static void Main()
//        {
>>>>>>> 405b14fa987cfa27095e2a73b7d2da86d4c534ed

//            var input = Console.ReadLine();
//            var dic = new SortedDictionary<string, Dictionary<string, int>>();

<<<<<<< HEAD
                    if (currentCard.Length > 2)
                    {
                        face = GetFace(currentCard.Substring(0, 2));

                        suite = GetSuite(currentCard.Substring(2));
                    }
                    else
                    {
                        face = GetFace(currentCard[0].ToString());

                        suite = GetSuite(currentCard[1].ToString());
                    }

                    if (!houseOfCards[name][suite].Contains(face))
                    {
                        houseOfCards[name][suite].Add(face);
                    }
                }


                input = Console.ReadLine();
            }

            foreach (var outerPair in houseOfCards)
            {
                Console.Write(outerPair.Key + ": ");

                var sum = 0;
                foreach (var innerPair in outerPair.Value)
                {
                   sum += innerPair.Key * innerPair.Value.Sum();
                }
                Console.WriteLine(sum);
            }


        }
        private static int GetFace(string face)
        {
            switch (face)
            {
                case "J":
                    return 11;
                case "Q":
                    return 12;
                case "K":
                    return 13;
                case "A":
                    return 14;
                default:
                    return int.Parse(face);
            }
        }

        private static int GetSuite(string suite)
        {
            switch (suite)
            {
                case "S":
                    return 4;
                case "H":
                    return 3;
                case "D":
                    return 2;
                case "C":
                    return 1;
                default :
                    return 0;
            }
        }


    }
}
=======
//            while (input != "end")
//            {
//                var data = input.Split();

//                var userInput = data[2].Split('=');
//                var users = userInput[1];

//                var IpInput = data[0].Split('=');
//                var IPs = IpInput[1];

//                if (!dic.ContainsKey(users))
//                {
//                    dic[users] = new Dictionary<string, int>();
//                }
//                if (!dic[users].ContainsKey(IPs))
//                {
//                    dic[users][IPs] = 0;
//                }

//                dic[users][IPs] += 1;

//                input = Console.ReadLine();
//            }

//            foreach (var user in dic)
//            {
//                Console.WriteLine(user.Key + ":");

//                var result = "";

//                foreach (var pair in user.Value)
//                {
//                    result += $"{pair.Key} => {pair.Value}, \n";
//                }
//                Console.WriteLine(result.TrimEnd(new Char[] { ' ', ',', '\n' }) + ".");
//            }
//        }
//    }
//}



//namespace test
//{
//    class MainClass
//    {
//        public static void Main()
//        {
           
//            string input = Console.ReadLine();

//            var houseOfCards = new Dictionary<string, Dictionary<int, HashSet<int>>>();

//            while (input != "JOKER")
//            {
//                string[] handInfo = input.Split(new char[] { ':', ',', ' ' }
//                                                ,StringSplitOptions
//                                                .RemoveEmptyEntries);

//                string name = handInfo[0];

//                if(!houseOfCards.ContainsKey(name))
//                {
//                    houseOfCards.Add(name, new Dictionary<int, HashSet<int>>());

//                    for (int i = 1; i <= 4; i++)
//                    {
//                        houseOfCards[name].Add(i, new HashSet<int>());
//                    }
//                }

//                for (int i = 1; i < handInfo.Length; i++)
//                {
//                    string currentCard = handInfo[i].Trim();
//                    int face = 0;
//                    int suite = 0;


//                    if (currentCard.Length > 2)
//                    {
//                         face = getFace(currentCard.Substring(0, 2));

//                         suite = getSuite(currentCard.Substring(2));
//                    }
//                    else
//                    {
//                         face = getFace(currentCard[0].ToString());

//                         suite = getSuite(currentCard[1].ToString());
//                    }

                 

//                    if (!houseOfCards[name][suite].Contains(face))
//                    {

//                        houseOfCards[name][suite].Add(face);
//                    }
//                }

//                input = Console.ReadLine();
//            }

//            foreach (var outerPair in houseOfCards)
//            {
//                int sum = 0;

//                foreach (var innerPair in outerPair.Value)
//                {
//                    sum += innerPair.Key * innerPair.Value.Sum();
//                }
//                Console.WriteLine($"{outerPair.Key}: {sum}");
//            }




//        }
//        private static int getFace(string face)
//        {
//            switch (face)
//            {
//                case "J":
//                    return 11;
//                case "Q":
//                    return 12;
//                case "K":
//                    return 13;
//                case "A":
//                    return 14;
//                default:
//                    return int.Parse(face);
//            }
//        }
//        private static int getSuite(string suite)
//        {
//            switch (suite)
//            {
//                case "S":
//                    return 4;
//                case "H":
//                    return 3;
//                case "D":
//                    return 2;
//                case "C":
//                    return 1;
//                default:
//                    return 0;
//            }
                                
//        }

       
//    }
//}
>>>>>>> 405b14fa987cfa27095e2a73b7d2da86d4c534ed

// 1 2 3 4 5
// + 1 2 3 4


//   01.
//      List<int> numbers = Console.ReadLine()
//                                             .Split()
//                                             .Select(int.Parse)
//                                             .ToList();
//      var count = 1;
//      var maxCount = 0;
//      var maxNum = 0;
//      for (int i = 0; i<numbers.Count - 1; i++)
//      {
//          if (numbers[i] == numbers[i + 1])
//          {
//              count++;
//              if (maxCount<count)
//              {
//                  maxCount = count;
//                  maxNum = numbers[i];
//              }
//          }
//          else
//          {
//              count = 1;
//          }
//      }
//      for (int i = 0; i<maxCount; i++)
//      {
//          Console.Write($"{maxNum} ");
//      }

// 02.


//{
//    class MainClass
//    {
//        static void Main()
//        {
//            List<int> numbers = Console.ReadLine()
//                                       .Split()
//                                       .Select(int.Parse)
//                                       .ToList();

//            List<int> commands = Console.ReadLine()
//                                        .Split()
//                                        .Select(int.Parse)
//                                        .ToList();

//            var bomNum = commands[0];
//            var power = commands[1];

//            while (numbers.Contains(bomNum))
//            {
//                var position = numbers.IndexOf(bomNum);

//                if (position - power < 0 && position + power > numbers.Count)
//                {
//                    numbers.Clear();
//                }
//                else if (position - power < 0)
//                {
//                    numbers.RemoveRange(0, 1 + power + position);
//                }

//                else if (position + power >= numbers.Count)
//                {
//                    numbers.RemoveRange(position - power, 1 + power + (numbers.Count - 1 - position));
//                }
//                else
//                {
//                    numbers.RemoveRange(position - power, power * 2 + 1);
//                }
//            }
//            Console.WriteLine(numbers.Sum());
//        }
//    }
//}


//03.

//  using System;
//using System.Collections.Generic;
//using System.Linq;


//namespace test
//{
//    class MainClass
//    {
//        static void Main()
//        {
//            List<int> nums = Console.ReadLine()
//                                       .Split()
//                                       .Select(int.Parse)
//                                       .ToList();

//            var counter = 1;
//            var maxCount = 0;
//            var numberEnd = 0;

//            for (int i = 0; i < nums.Count - 1; i++)
//            {
//                if (nums[i] < nums[i + 1])
//                {
//                    counter++;
//                }
//                else
//                {
//                    if (maxCount < counter)
//                    {
//                        maxCount = counter;
//                        numberEnd = i;
//                        counter = 1;
//                    }
//                    counter = 1;
//                }

//                if (i == nums.Count - 2)
//                {
//                    if (maxCount < counter)
//                    {
//                        maxCount = counter;
//                        numberEnd = i + 1;
//                    }
//                }
//            }
//            for (int i = 0; i < maxCount; i++)
//            {
//                Console.Write(nums[numberEnd - maxCount + 1 + i] + " ");
//            }
//        }
//    }
//}


//04.
//using System;
//using System.Collections.Generic;
//using System.Linq;



//namespace test
//{
//    class MainClass
//    {
//        public static void Main()
//        {


//            var circle1data = Console.ReadLine()
//                                     .Split()
//                                     .Select(double.Parse)
//                                     .ToArray();

//            var circle1X = circle1data[0];
//            var circle1Y = circle1data[1];
//            var circle1Radius = circle1data[2];





//            var circle2data = Console.ReadLine()
//                                     .Split()
//                                     .Select(double.Parse)
//                                     .ToArray();


//        }

//        class Point
//        {
//            public Point(double x, double y)
//            {
//                X = x;
//                Y = y;
//            }

//            public double X { get; set; }
//            public double Y { get; set; }
//        }

//        class Cyrcle
//        {
//            public Cyrcle(Point point, double radius)
//            {
//                Point = point;
//                Radius = radius;
//            }

//            public Point Point { get; set; }

//            public double Radius { get; set; }
//        }
//    }
//}


//05. 

//  using System;
//using System.Collections.Generic;
//using System.Linq;



//namespace test
//{
//    class MainClass
//    {
//        public static void Main()
//        {
//            int n = int.Parse(Console.ReadLine());

//            Dictionary<string, Dictionary<string, List<long>>>
//            army =
//                new Dictionary<string, Dictionary<string, List<long>>>();

//            while (n-- > 0)
//            {
//                string[] data = Console.ReadLine().Split();

//                string type = data[0];
//                string name = data[1];

//                long damage = data[2].Equals("null") ? 45 : long.Parse(data[2]);
//                long health = data[3].Equals("null") ? 250 : long.Parse(data[3]);
//                long armor = data[4].Equals("null") ? 10 : long.Parse(data[4]);

//                List<long> stats = new List<long>();

//                stats.Add(damage);
//                stats.Add(health);
//                stats.Add(armor);

//                if (!army.ContainsKey(type))
//                {
//                    army.Add(type, new Dictionary<string, List<long>>());
//                }

//                army[type].Add(name, stats);

//            }
//            foreach (var type in army)
//            {
//                long sumDmg = 0;
//                long sumHealt = 0;
//                long sumArmor = 0;

//                Dictionary<string, List<long>> nameWithStats =
//                    army[type.Key];

//                foreach (var inner in nameWithStats)
//                {
//                    sumDmg += nameWithStats[inner.Key][0];
//                    sumHealt += nameWithStats[inner.Key][1];
//                    sumArmor += nameWithStats[inner.Key][2];
//                }
//                Console.WriteLine($"{type.Key:f2}::({(sumDmg / nameWithStats.Count):f2}" +
//                                  $"/{(sumHealt / nameWithStats.Count):f2}" +
//                                  $"/{(sumArmor / nameWithStats.Count):f2}");
//            }

//        }
//    }
//}


//06.

//using System;
//using System.Collections.Generic;
//using System.Linq;



//namespace test
//{
//    class MainClass
//    {
//        public static void Main()
//        {
//            var arr = Console.ReadLine()
//                             .Split()
//                             .ToArray();
//            var temp = arr[arr.Length - 1];

//            for (int i = arr.Length - 1; i >= 1; i--)
//            {
//                arr[i] = arr[i - 1];
//            }
//            arr[0] = temp;

//            Console.WriteLine(string.Join(" ", arr));

//        }
//    }
//}

//// 1 2 3 4 5
//// + 1 2 3 4





