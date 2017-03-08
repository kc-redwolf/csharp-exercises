using System;

namespace AreaOfRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double area;
            double width;
            double height;
            string message;

            Console.WriteLine("Enter the width:");
            width = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the height");
            height = double.Parse(Console.ReadLine());

            area = width * height;

            message = "The area of a rectangle with a width of {0} and height {1} is {2}.";
            Console.WriteLine(string.Format(message, width, height, area));
                           
            Console.Read();
        }
    }
}
