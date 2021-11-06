using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda1
{
    class Class31
    {
        public static void Main()
        {
            /* float?[] points = { null, 0, 92.83F, null, 100.0F, 37.46F, 81.1F };

             float? sum = points.Sum();

             Console.WriteLine("Total points earned: {0}", sum);
            */

            List<float> numbers = new List<float> { 43.68F, 1.25F, 583.7F, 6.5F };

            float sum = numbers.Sum();

            Console.WriteLine("The sum of the numbers is {0}.", sum);
        }
    }
}
