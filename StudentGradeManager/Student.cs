using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradeManager
{
    public class Student
    {

        public string Name {  get; set; }
        public int ID { get; set; }
        public List<double> Grades { get; set; } = new List<double>();

        public void AddGrade(double grade)
        {
            Grades.Add(grade);
        }

        public void AddGrade(double[] grades)
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
    }
}
