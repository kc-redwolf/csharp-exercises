using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IsEven
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("isEven?");
            Console.WriteLine();

            Console.WriteLine("Enter the number to be checked");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine();

            bool isEven = true;

            //Even number checker
            if (number % 2 != 0)
            {
                isEven = false;
            }

            if (isEven)
            {
                Console.WriteLine("It is an Even Number");
            }
            else
            {
                Console.WriteLine("Not an Even Number");
            }
            Console.WriteLine();

        }
    }
}
