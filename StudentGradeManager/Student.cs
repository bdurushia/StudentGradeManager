using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradeManager
{
    public class Student
    {
        // Student Properties
        public string Name {  get; set; }
        public int ID { get; set; }
        public List<double> Grades { get; set; } = new List<double>();

        // Methods for adding grades and calculating average grade
        public void AddGrade(double grade)
        {
            Grades.Add(grade);
        }

        public void AddGrade(params double[] grades)
        {
            Grades.AddRange(grades);
        }

        public double CalculateAverageGrade()
        {
            double gradeAverage = 0;

            foreach (var grade in Grades)
            {
                gradeAverage += grade;
            }

            return gradeAverage = gradeAverage / Grades.Count;
        }

        public static void ShowStudentInfo(Student student)
        {
            Console.Write($"{student.Name}\t\t{student.ID}\t");
            
            // Iterate through the students grades list and print each grade with punctuation
            for (int i = 0; i < student.Grades.Count; i++)
            {
                if (i >= 0 && i < student.Grades.Count -1)
                {
                    Console.Write($"{student.Grades[i]}, ");
                }
                else
                {
                    Console.Write($"{student.Grades[i]}\t");
                }
            }

            // Print final grade
            Console.Write($"{Math.Round(student.CalculateAverageGrade(), 2)}\n");

        }
    }
}
