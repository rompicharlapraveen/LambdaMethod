using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda1
{
    class Class11
    {
        public static void Main()
        {
            int[] numbers = { 9, 34, 65, 92, 87, 435, 3, 54,
                    83, 23, 87, 67, 12, 19 };

            int last = numbers.Last(num => num > 80);


             last = numbers.Last();

            Console.WriteLine(last);
        }
    }
}
