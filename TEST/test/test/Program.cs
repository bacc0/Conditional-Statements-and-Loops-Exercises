using System;
using System.Collections.Generic;
using System.Linq;



namespace test
{
    class MainClass
    {
        public static void Main()
        {
            var arr = Console.ReadLine()
                             .Split()
                             .ToArray();
            var temp = arr[arr.Length - 1];

            for (int i = arr.Length - 1; i >= 1; i--)
            {
                arr[i] = arr[ i - 1];
            }
            arr[0] = temp;

            Console.WriteLine(string.Join(" ", arr));

        }
    }
}

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






