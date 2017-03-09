using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, int> students = new Dictionary<string, int>();
            string newStudent;

            Console.WriteLine("Enter your students (or press ENTER to finish):");
            do
            {
                Console.Write("name: ");
                newStudent = Console.ReadLine();
                if (newStudent != "")
                {
                    // Get the student's id
                    Console.Write("id: ");
                    int newId = int.Parse(Console.ReadLine());

                    students.Add(newStudent, newId);
                }
            }
            while (newStudent != "");

            // Print class roster
            Console.WriteLine("\nClass Roster:");
            foreach (KeyValuePair<string, int> student in students)
            {
                Console.WriteLine(string.Format("{0} ({1})", student.Key, student.Value));
            }

            Console.ReadLine();
        }
    }
}
