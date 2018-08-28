using System;
using System.Collections.Generic;
using System.Linq;





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


//using System;
//using System.Collections.Generic;
//using System.Linq;

<<<<<<< HEAD
            for (int i = 0; i < sum.Length; i++) 
            {
                sum[i] = arrUp[i] + arrDown[i];
            }
            Console.WriteLine(string.Join(" ", arrUp));
            Console.WriteLine(string.Join(" ", arrDown));
            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
=======

//namespace test
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

>>>>>>> 12f12073cc64fe0a259322c3669c5ef43f106741


