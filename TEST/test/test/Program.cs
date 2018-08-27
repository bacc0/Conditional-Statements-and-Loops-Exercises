using System;
using System.Collections.Generic;
using System.Linq;


namespace test
{
    class MainClass
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                                       .Split()
                                       .Select(int.Parse)
                                       .ToList();
            var count = 1;
            var maxCount = 0;
            var maxNum = 0;

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    count++;

                    if (maxCount < count)
                    {
                        maxCount = count;
                        maxNum = numbers[i];
                    }
                }
                else
                {
                    count = 1;
                }
                if (maxCount < count)
                {
                    maxCount = count;
                    maxNum = numbers[i];
                }
            }
            for (int i = 0; i < maxCount; i++)
            {
                Console.Write($"{maxNum} ");
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



