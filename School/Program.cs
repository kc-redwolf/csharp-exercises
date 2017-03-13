using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School
{
    public class Program
    {
        public static void Main(string[] args)
    }
    public class Student
    {
        string name;
        int studentId;
        int numberOfCredits = 0;
        double gpa = 0;
    }
     
    private string name;

    public string Name
        {
            get { return name; }
            set { name = value; }
        }

    string Name { get; set; }

    Student josh = new Student();

        // set the Name
    josh.Name ="Josh";

        // get the Name
    Console.WriteLine(josh.Name);

    
}