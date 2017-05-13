using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeapYear
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Leap Year");
            Console.WriteLine();

            Console.WriteLine("Enter the year to be checked");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine();

            bool isLeapYear = true;

            //Leap year checker
            if (year % 4 != 0)
            {
                isLeapYear = false;
            }
            else if (year % 100 != 0)
            {
                isLeapYear = true;
            }
            else if (year % 400 != 0)
            {
                isLeapYear = false;
            }
            else
            {
                isLeapYear = true;
            }

            if (isLeapYear)
            {
                Console.WriteLine("It is a Leap Year");
            }
            else
            {
                Console.WriteLine("Not a Leap Year");
            }
            Console.WriteLine();

        }
    }
}
