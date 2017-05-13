using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SumInfiniteGeometricProgression
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Sum of Infinite Geometric Progression :");
            Console.WriteLine();

            double firstTerm = 16;
            double commonRatio = 0.75;
            /*
           |common Ratio| < 1
           Then only the sum will converge
           */

            Console.WriteLine("first term : " + firstTerm);
            Console.WriteLine("common ratio : " + commonRatio);
            Console.WriteLine();

            //Sum of Infinite Geometric Progression
            double sum;
            if (Math.Abs(commonRatio) < 1)
            {
                sum = firstTerm / (1 - commonRatio);
                Console.WriteLine("Sum of Geometric Progression : " + sum);
            }
            else
            {
                Console.WriteLine("|Common Ratio| > 1");
                Console.WriteLine("Thus, Sum of this Geometric Progression will never converge");
            }
            Console.WriteLine();

        }
    }
}
