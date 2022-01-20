using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());
            Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < numberOfStudents; i++)
            {
                string[] command = Console.ReadLine().Split();
                if (students.ContainsKey(command[0]))
                {
                    students[command[0]].Add(decimal.Parse(command[1]));
                }
                else
                {
                    students[command[0]] = new List<decimal>();
                    students[command[0]].Add(decimal.Parse(command[1]));
                }
            }
            foreach (var student in students)
            {
                Console.Write($"{student.Key} -> ");
                foreach (var item in student.Value)
                {
                    Console.Write($"{item:F2} ");
                }
                Console.WriteLine($"(avg: {student.Value.Average():f2})");
            }
        }
    }
}
