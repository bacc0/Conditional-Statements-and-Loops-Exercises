using System;
using System.Collections.Generic;
using System.Linq;



namespace test
{
    class MainClass
    {
        static void Main()
        {
            var inp =   Console.ReadLine();
            

            var dic = new Dictionary<string, Dictionary<string, int>>();


            while (!inp.Equals("end"))
            {

                var input = inp.Split()
                               .ToArray();

                var ipFull = input[0];
                var userFull = input[2];

                var ipHelper = ipFull.Split('=').ToArray();
                var userHelper = userFull.Split('=').ToArray();

                var ip = ipHelper[1];
                var user = userHelper[1];

                if (!dic.ContainsKey(user))
                {
                    dic[user] = new Dictionary<string, int>();
                }
                if (!dic[user].ContainsKey(ip))
                {
                    dic[user][ip] = 0;
                }

                dic[user][ip] += 1;



                input = inp.Split()
                           .ToArray();
            }

        }
    }
}



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




