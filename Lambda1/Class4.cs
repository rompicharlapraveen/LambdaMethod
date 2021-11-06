using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda1
{
    /*
    class Class4
    {
        public static void Main()
        {
            IList<string> strList1 = new List<string>(){"One", "Two", "Three", "Four", "Five" };
		IList<string> strList2 = new List<string>(){"Four", "Five", "Six", "Seven", "Eight"};
		
		var result = strList1.Except(strList2);
		
		foreach(string str in result)
				Console.WriteLine(str);
        }
    }
    */
        internal class Resident
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string City { get; set; }
        }

        internal class ResidentNameComparer : IEqualityComparer<Resident>
        {
            public bool Equals(Resident x, Resident y)
            {
                if (string.Equals(x.Name, y.Name, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
                return false;
            }

            public int GetHashCode(Resident obj)
            {
                return obj.Name.GetHashCode();
            }
        }

        public class Class4
        {
            public static void Main(string[] args)
            {
                List<Resident> delhiResidents = new List<Resident>();
                delhiResidents.Add(new Resident { Id = 1, Name = "Praveen", City = "Delhi" });
                delhiResidents.Add(new Resident { Id = 2, Name = "Sasi", City = "Delhi" });
                List<Resident> kolkataResidents = new List<Resident>();
                kolkataResidents.Add(new Resident { Id = 3, Name = "Sai", City = "Kolkata" });
                kolkataResidents.Add(new Resident { Id = 4, Name = "Madhu", City = "Kolkata" });

                var onlyDelhiResidents = delhiResidents.Except(kolkataResidents, new ResidentNameComparer());

                Console.WriteLine("Only Delhi Residents:");
                foreach (var item in onlyDelhiResidents)
                {
                    Console.WriteLine(item.Name);
                }
            }
        }
    }
