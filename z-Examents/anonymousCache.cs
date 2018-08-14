using System;
using System.Collections.Generic;
using System.Linq;

namespace anonymousCache
{
    class MainClass
    {
        public static void Main(string[] args)

        {

            var input = Console.ReadLine();

            var data = new Dictionary<string, Dictionary<string, long>>();

            while (! input.Equals("thetinggoesskrra") )
            {
                var inputSplit = input.Split(" ->|".ToCharArray()
                                                   ,StringSplitOptions
                                                   .RemoveEmptyEntries);

                if ( inputSplit.Length > 1 )
                {
                    var dataKey = inputSplit[0];
                    var dataSize = long.Parse(inputSplit[1]);
                    var dataSet = inputSplit[2];

                    if ( ! data.ContainsKey(dataSet))
                    {
                        data[dataSet] = new Dictionary<string, long>();
                    }
                    if ( ! data[dataSet].ContainsKey(dataKey))
                    {
                        data[dataSet][dataKey] = 0;
                    }
                    data[dataSet][dataKey] = dataSize;

                }

                input = Console.ReadLine();
            }

            if(data.Count > 1)
            {
                var maxSize =  data.OrderByDescending( x => x
                                   .Value
                                   .Values
                                   .Sum() )
                                   .First();
                        

                Console.WriteLine($"Data Set: {maxSize.Key}, Total Size: {maxSize.Value.Values.Sum()}");

                foreach (var pair in maxSize.Value)
                {
                    Console.WriteLine($"$.{pair.Key}");
                }
            }
        }
    }
}

