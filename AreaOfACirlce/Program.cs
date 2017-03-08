using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfACirlce
{
    public class Area
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a radius:");
            double radius; 
                
            radius = double.Parse(Console.ReadLine());

            double area;

            area = Math.PI * radius * radius;



            string message = "The area of a circle with radius {0} is: {1:0.###}";
            Console.WriteLine(string.Format(message, radius, area));
            Console.ReadLine();
        }
    }
}
