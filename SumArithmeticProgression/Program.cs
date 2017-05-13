using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SumArithmeticProgression
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Sum of Arithmetic Progression :");
            Console.WriteLine();

            double firstTerm = 24;
            double commonDifference = 7.5;
            int numberOfTerms = 15;

            Console.WriteLine("first term : " + firstTerm);
            Console.WriteLine("common difference : " + commonDifference);
            Console.WriteLine("number of terms : " + numberOfTerms);
            Console.WriteLine();

            //Sum of Arithmetic Progression
            double sum = (numberOfTerms / 2) * (2 * firstTerm + (numberOfTerms - 1) * commonDifference);
            Console.WriteLine("Sum of Arithmetic Progression : " + sum);
            Console.WriteLine();

        }
    }
}
