using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius;
            double area;
            string input;

            Console.Write("Enter a radius:");
            input = Console.ReadLine();
            radius = double.Parse(input);
            area = (3.14 * radius * radius);

            Console.WriteLine("The area of a circle of radius " + radius + "is " + area);
            Console.Read();          
            
        }
    }
}
