using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda1
{
    /*
    class Class5
    {
        public static void Main()
        {
            int[] numbers = { 9, 34, 65, 92, 87, 435, 3, 54,
                    83, 23, 87, 435, 67, 12, 19 };

            int first = numbers.First();

            Console.WriteLine(first);
        }
    }
    */

    class Class5
    {
        public static void Main()
        {
            int[] numbers = { 9, 34, 65, 92, 87, 435, 3, 54,
                    83, 23, 87, 435, 67, 12, 19 };

            int first = numbers.First(number => number > 80);

            Console.WriteLine(first);
        }
    }
}
