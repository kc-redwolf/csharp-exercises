using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var students = new List<Student>();
            var course = new Course();

            foreach (string name in GetNames())
            {
                double gpa = Student.GenerateGpa();

                var newStudent = new Student();
                newStudent.Name = name;
                newStudent.Gpa = gpa;
                newStudent.NumberOfCredits = 15;

                students.Add(NewStudent);
            }

            foreach (Student student in students)
            {
                Console.WriteLine("Hello to {0}", student);
                course.AddStudent(student);

            }

        }
    }  
}