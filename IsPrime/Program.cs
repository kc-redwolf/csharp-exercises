using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IsPrime
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("isPrime?");
            Console.WriteLine();

            Console.WriteLine("Enter the number to be checked");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine();

            bool isPrime = true;

            //Prime number checker
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                Console.WriteLine("It is a Prime Number");
            }
            else
            {
                Console.WriteLine("Not a Prime Number");
            }
            Console.WriteLine();

        }
    }
}
