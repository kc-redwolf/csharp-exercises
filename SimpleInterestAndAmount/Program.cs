using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleInterestAndAmount
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Simple Interest & Amount");
            Console.WriteLine();

            double principal = 10000;
            double rate = 8.5;
            double time = 4;

            Console.WriteLine("Principal : " + principal);
            Console.WriteLine("Rate : " + rate);
            Console.WriteLine("Time : " + time);
            Console.WriteLine();

            double SimpleInterest = principal * rate * time / 100;
            Console.WriteLine("Simple Interest = " + SimpleInterest);
            double amount = principal + SimpleInterest;
            Console.WriteLine("Amount = " + amount);
            Console.WriteLine();

        }
    }
}
