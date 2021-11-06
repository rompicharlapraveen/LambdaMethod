using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda1
{
    /*
    class Class9
    {
        public static void Main()
        {
            int[] id1 = { 44, 26, 92, 30, 71, 38 };
            int[] id2 = { 39, 59, 83, 47, 26, 4, 30 };

            IEnumerable<int> both = id1.Intersect(id2);

            foreach (int id in both)
                Console.WriteLine(id);
        }
    }
    */

    public class Class9
    {
        internal class Employee
        {
            public string ID { get; set; }
            public string Name { get; set; }
        }

        internal class EmployeeNameComparer : IEqualityComparer<Employee>
        {
            public bool Equals(Employee x, Employee y)
            {
                if (string.Equals(x.Name, y.Name, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
                return false;
            }

            public int GetHashCode(Employee obj)
            {
                return obj.Name.GetHashCode();
            }
        }

        public static void Main(string[] args)
        {
            List<Employee> employeesInDeptA = new List<Employee>();
            List<Employee> employeesInDeptB = new List<Employee>();

            employeesInDeptA.Add(new Employee
            {
                ID = "A1",
                Name = "Asutosh"
            });
            employeesInDeptA.Add(new Employee
            {
                ID = "A2",
                Name = "Kapil"
            });
            employeesInDeptA.Add(new Employee
            {
                ID = "A3",
                Name = "Sumit"
            });
            employeesInDeptA.Add(new Employee
            {
                ID = "A4",
                Name = "Rajat"
            });

            employeesInDeptB.Add(new Employee
            {
                ID = "B1",
                Name = "Preeti"
            });
            employeesInDeptB.Add(new Employee
            {
                ID = "B2",
                Name = "Sumit"
            });
            employeesInDeptB.Add(new Employee
            {
                ID = "B3",
                Name = "Kanupriya"
            });
            employeesInDeptB.Add(new Employee
            {
                ID = "B4",
                Name = "Kapil"
            });

            var result = employeesInDeptA.Intersect(employeesInDeptB, new EmployeeNameComparer());

            Console.WriteLine("Common Employees in Department A and B:");
            foreach (var item in result)
            {
                Console.WriteLine(item.ID + " " + item.Name);
            }
        }
    }
}
