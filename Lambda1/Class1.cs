using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda1
{
    /*
     class Class1
     {
         public static void Main(string[] args)
         {
             List<int> ages = new List<int> { 21, 46, 46, 55, 17, 21, 55, 55 };

             IEnumerable<int> distinctAges = ages.Distinct();

             Console.WriteLine("Distinct ages:");

             foreach (int age in distinctAges)
             {
                 Console.WriteLine(age);
             }
         }
     }
    */

    public class Class1
    {
        public static void Main()
        {
            IList<Student> studentList = new List<Student>() {
            new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
            new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
            new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 }
        };


            var distinctStudents = studentList.Distinct(new StudentComparer());

            foreach (var std in distinctStudents)
                Console.WriteLine(std.StudentName);

        }
    }

    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
    }

    public class StudentComparer : IEqualityComparer<Student>
    {
        public bool Equals(Student x, Student y)
        {
            if (x.StudentID == y.StudentID
                    && x.StudentName.ToLower() == y.StudentName.ToLower())
                return true;

            return false;
        }

        public int GetHashCode(Student obj)
        {
            return obj.StudentID.GetHashCode();
        }
    }
}
