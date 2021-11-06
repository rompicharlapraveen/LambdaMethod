using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda1
{
    public class SpecialComparer : IComparer<decimal>
    {
        public int Compare(decimal d1, decimal d2)
        {
            decimal fractional1, fractional2;

            // Get the fractional part of the first number.
            try
            {
                fractional1 = decimal.Remainder(d1, decimal.Floor(d1));
            }
            catch (DivideByZeroException)
            {
                fractional1 = d1;
            }
            // Get the fractional part of the second number.
            try
            {
                fractional2 = decimal.Remainder(d2, decimal.Floor(d2));
            }
            catch (DivideByZeroException)
            {
                fractional2 = d2;
            }

            if (fractional1 == fractional2)
                return Decimal.Compare(d1, d2);
            else if (fractional1 > fractional2)
                return 1;
            else
                return -1;
        }
    }
    class Class19
    {
        public static void Main()
        {
            List<decimal> decimals =
                new List<decimal> { 6.2m, 8.3m, 0.5m, 1.3m, 6.3m, 9.7m };

            IEnumerable<decimal> query =decimals.OrderByDescending(num =>num, new SpecialComparer());

            foreach (decimal num in query)
            {
                Console.WriteLine(num);
            }
        }
    }
}
