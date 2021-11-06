using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda1
{
    class Class30
    {
        public static void Main()
        {
            int[] amounts = { 5000, 2500, 9000, 8000,
                    6500, 4000, 1500, 5500 };

            IEnumerable<int> query = amounts.SkipWhile((amount, index) => amount > index * 1000);

            foreach (int amount in query)
            {
                Console.WriteLine(amount);
            }
        }
    }
}
