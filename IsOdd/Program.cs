using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IsOdd
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("isOdd?");
            Console.WriteLine();

            Console.WriteLine("Enter the number to be checked");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine();

            bool isOdd = true;

            //Odd number checker
            if (number % 2 == 0)
            {
                isOdd = false;
            }

            if (isOdd)
            {
                Console.WriteLine("It is an Odd Number");
            }
            else
            {
                Console.WriteLine("Not an Odd Number");
            }
            Console.WriteLine();

        }
    }
}
