using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Temperature
{
    public class Program
    {
        public static void Main(string[] args)
        {

        }
    public class Temperature
        {
            private double fahrenheit;

            public double Fahrenheit
            {
                get
                {
                    return fahrenheit;
                }
                set
                {
                    double absoluteZeroFahrenheit = -459.67;

                    if (value < absoluteZeroFahrenheit)
                    {
                        throw new ArgumentException("Value is below absolut zero");
                    }
                }

            }
            public double Celcius
            {
                get { return (Fahrenheit - 32) * 5.0 / 9.0; }
                set { Fahrenheit = value * 9.0 / 5.0 + 32; }
            }

        }
    }
}
