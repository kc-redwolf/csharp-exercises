using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeometricProgression
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Geometric Progression :");
            Console.WriteLine();

            double firstTerm = 7;
            double commonRatio = 4;
            int numberOfTerms = 11;

            Console.WriteLine("first term : " + firstTerm);
            Console.WriteLine("common ratio : " + commonRatio);
            Console.WriteLine("number of terms : " + numberOfTerms);
            Console.WriteLine();

            //Geometric Progression
            Console.WriteLine("Geometric Progression :");
            for (int i = 0; i < numberOfTerms; i++)
            {
                double ithTerm = firstTerm * Math.Pow(commonRatio, i);
                Console.WriteLine(ithTerm);
            }
            Console.WriteLine();

        }
    }
}
