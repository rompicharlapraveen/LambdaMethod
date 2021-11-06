using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda1
{
    class Class33
    {
        public static void Main()
        {
            /*
            int[] grades = { 59, 82, 70, 56, 92, 98, 85 };

            IEnumerable<int> topThreeGrades = grades.OrderByDescending(grade => grade).Take(3);

            Console.WriteLine("The top three grades are:");
            foreach (int grade in topThreeGrades)
            {
                Console.WriteLine(grade);
            }
            */

            IList<string> strList = new List<string>() {"One", "Two","Three","Four" };

            var resultList = strList.TakeWhile((s, i) => s.Length > i);

            foreach (string str in resultList)
                Console.WriteLine(str);
        }
    }
}
