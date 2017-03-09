using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumRandomNumList
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare the variables we will need
            Random rnd = new Random();
            List<int> numbersToSum = new List<int>();
            int randomNum;
            int sum = 0;

            // Begin creating number list
            Console.Write("Creating Number List:");
            for (int i = 0; i < 10; i++)
            {
                randomNum = rnd.Next(1, 50);
                numbersToSum.Add(randomNum);
                Console.Write(string.Format("{0} ", randomNum));
            }
            // Add up the numbers
            foreach (int num in numbersToSum)
            {
                sum += num;
            }

            // Print results
            Console.WriteLine(string.Format("\nOur resulting sum is: {0}", sum));
            Console.Read();
        }
    }
}
