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
                else
                {
                    students[student].Add(marks);
                }
            }

            Console.WriteLine("jj");

        }
    }
}
