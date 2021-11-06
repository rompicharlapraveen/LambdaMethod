using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda1
{
    class Class29
    {
        public static void Main()
        {
            int[] grades = { 59, 82, 70, 56, 92, 98, 85 };

            IEnumerable<int> lowerGrades =
                grades.OrderByDescending(g => g).Skip(3);

            Console.WriteLine("All grades except the top three are:");
            foreach (int grade in lowerGrades)
            {
                Console.WriteLine(grade);
            }
        }
    }
}
