using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 1, 2, 3, 5, 8};
            foreach (int i in numbers)
            {
                System.Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
