using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NumberReversal
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Number Reversal :");
            Console.WriteLine();

            int number = 975;
            int remainder;
            int reverse = 0;

            Console.WriteLine("Number : " + number);
            Console.WriteLine();

            //Number Reversal
            while (number > 0)
            {
                remainder = number % 10;
                reverse = reverse * 10 + remainder;
                number /= 10;
            }

            Console.WriteLine("Reverse : " + reverse);
            Console.WriteLine();

        }
    }
}
