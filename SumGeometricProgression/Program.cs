using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SumGeometricProgression
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Sum of Geometric Progression :");
            Console.WriteLine();

            double firstTerm = 32;
            double commonRatio = 2;
            int numberOfTerms = 9;

            Console.WriteLine("first term : " + firstTerm);
            Console.WriteLine("common ratio : " + commonRatio);
            Console.WriteLine("number of terms : " + numberOfTerms);
            Console.WriteLine();

            //Sum of Geometric Progression
            double sum;
            if (commonRatio != 1)
            {
                sum = firstTerm * (1 - Math.Pow(commonRatio, numberOfTerms)) / (1 - commonRatio);
            }
            else
            {
                sum = firstTerm * numberOfTerms;
            }
            Console.WriteLine("Sum of Geometric Progression : " + sum);
            Console.WriteLine();

        }
    }
}
