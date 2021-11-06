using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda1
{
    class Package3
    {
        public string Company { get; set; }
        public double Weight { get; set; }
        public long TrackingNumber { get; set; }
    }
    class Class40
    {
        public static void ToLookupEx1()
        {
            // Create a list of Packages.
            List<Package3> packages =
                new List<Package3>
                    { new Package3 { Company = "Coho Vineyard",
                  Weight = 25.2, TrackingNumber = 89453312L },
              new Package3 { Company = "Lucerne Publishing",
                  Weight = 18.7, TrackingNumber = 89112755L },
              new Package3 { Company = "Wingtip Toys",
                  Weight = 6.0, TrackingNumber = 299456122L },
              new Package3 { Company = "Contoso Pharmaceuticals",
                  Weight = 9.3, TrackingNumber = 670053128L },
              new Package3 { Company = "Wide World Importers",
                  Weight = 33.8, TrackingNumber = 4665518773L } };

            // Create a Lookup to organize the packages.
            // Use the first character of Company as the key value.
            // Select Company appended to TrackingNumber
            // as the element values of the Lookup.
            ILookup<char, string> lookup =packages.ToLookup(p => p.Company[0],
                          p => p.Company + " " + p.TrackingNumber);

            // Iterate through each IGrouping in the Lookup.
            foreach (IGrouping<char, string> packageGroup in lookup)
            {
                // Print the key value of the IGrouping.
                Console.WriteLine(packageGroup.Key);
                // Iterate through each value in the
                // IGrouping and print its value.
                foreach (string str in packageGroup)
                    Console.WriteLine("    {0}", str);
            }
        }
    }
}
