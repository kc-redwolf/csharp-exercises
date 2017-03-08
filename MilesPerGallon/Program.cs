using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilesPerGallon
{
    class Program
    {
        static void Main(string[] args)
        {
            double mpg;
            double miles;
            double gallons;
            string result;

            Console.WriteLine("Enter the total miles driven:");
            miles = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the total gallons consumed:");
            gallons = double.Parse(Console.ReadLine());

            mpg = miles / gallons;
            result = "{0:#.##} MPG";

            Console.WriteLine(string.Format(result, mpg));
            Console.Read();

        }
    }
}
