using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfEvens
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare the variables we will need
            Random rnd = new Random();
            List<int> numbersList = new List<int>();
            int randomNum;
            int sum = 0;

            // Begin creating number list
            Console.Write("Creating Number List:");
            for (int i = 0; i < 10; i++)
            {
                randomNum = rnd.Next(1, 50);
                numbersList.Add(randomNum);
                Console.Write(string.Format("{0} ", randomNum));
            }

            //sum even numbers
            foreach (int num in numbersList)
            {
                if (num % 2 != 0)
                {
                    continue;
                }
                else
                {
                    sum += num;
                }
            }
            Console.WriteLine("The sum of the even numbers is {0}", sum);
            Console.Read();
        }
    }
}
