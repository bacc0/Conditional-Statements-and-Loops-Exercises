using System;
using System.Collections.Generic;
using System.Linq;

namespace B01_AveraageMarks
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var numberOfStudents = int.Parse(Console.ReadLine());

            var students = new Dictionary<string, List<double>>();

            for (int i = 0; i < numberOfStudents; i++)
            {
                var entry = Console.ReadLine()
                                   .Split(new char[] { ' ' }
                                   , StringSplitOptions.RemoveEmptyEntries);

                var student = entry[0];
                var marks = double.Parse(entry[1]);


                if (!students.ContainsKey(student))
                {
                    students[student] = new List<double>();
                }
                    students[student].Add(marks);
            }

            foreach (var item in students)
            {
                Console.WriteLine($"{item.Key} -> {string.Join(" ", item.Value)} (avg: {item.Value.Average():f2})");
            }

        }
    }
}
