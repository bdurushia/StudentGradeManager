using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradeManager
{
    public class Course
    {
        public string CourseName { get; set; }
        public string CourseCode { get; set; }
        public List<Student> EnrolledStudents { get; set; }
        public Course()
        {
           EnrolledStudents = new List<Student>();
        }

        public void EnrollStudent(Student student)
        {
            if (EnrolledStudents.Count == 0) 
            {
                EnrolledStudents.Add(student);
            }
            else if (!EnrolledStudents.Contains(student)) // Checking to make sure logic doesn't allow adding a student twice
            {
                EnrolledStudents.Add(student);
            }
        }

        public void PrintCourseWithStudents()
        {
            Console.Write($"{CourseName}\t\t{CourseCode}\t\t");
            for (int i = 0; i < EnrolledStudents.Count; i++)
            {
                if (i < EnrolledStudents.Count - 1)
                {
                    Console.Write($"{EnrolledStudents[i].Name}, ");
                }
                else
                {
                    Console.Write($"{EnrolledStudents[i].Name}\n");
                }
            }
        }
    }
}