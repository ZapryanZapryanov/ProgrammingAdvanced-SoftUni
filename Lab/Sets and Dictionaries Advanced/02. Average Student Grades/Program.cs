using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < n; i++)
            {
                string[] student = Console.ReadLine().Split();
                string nameOfStudent = student[0];
                decimal grade = decimal.Parse(student[1]);
                if (students.ContainsKey(nameOfStudent))
                {
                    students[nameOfStudent].Add(grade);
                }
                else
                {
                    students.Add(nameOfStudent, new List<decimal> { grade });
                }
            }
            foreach (var item in students)
            {
               
                Console.WriteLine($"{item.Key} -> {string.Join(" ", item.Value.Select(x => x.ToString("f2")))} (avg: {item.Value.Average():f2})");
            }
        }
    }
}
