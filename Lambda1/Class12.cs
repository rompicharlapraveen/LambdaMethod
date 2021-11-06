using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda1
{
    class Class12
    {
        public static void Main()
        {
            double[] numbers = { 49.6, 52.3, 51.0, 49.4, 50.2, 48.3 };

            double last50 = numbers.LastOrDefault(n => Math.Round(n) == 50.0);

            Console.WriteLine("The last number that rounds to 50 is {0}.", last50);

            double last40 = numbers.LastOrDefault(n => Math.Round(n) == 40.0);

            Console.WriteLine(
                "The last number that rounds to 40 is {0}.",
                last40 == 0.0 ? "<DOES NOT EXIST>" : last40.ToString());
        }
    }
}
