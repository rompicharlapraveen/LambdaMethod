using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda1
{
    class Package2
    {
        public string Company { get; set; }
        public double Weight { get; set; }
        public long TrackingNumber { get; set; }
    }
    class Class37
    {
        public static void Main()
        {
            List<Package2> packages =
                new List<Package2>
                    { new Package2 { Company = "Coho Vineyard", Weight = 25.2, TrackingNumber = 89453312L },
              new Package2 { Company = "Lucerne Publishing", Weight = 18.7, TrackingNumber = 89112755L },
              new Package2 { Company = "Wingtip Toys", Weight = 6.0, TrackingNumber = 299456122L },
              new Package2 { Company = "Adventure Works", Weight = 33.8, TrackingNumber = 4665518773L } };

            // Create a Dictionary of Package objects,
            // using TrackingNumber as the key.
            Dictionary<long, Package2> dictionary =
                packages.ToDictionary(p => p.TrackingNumber);

            foreach (KeyValuePair<long, Package2> kvp in dictionary)
            {
                Console.WriteLine(
                    "Key {0}: {1}, {2} pounds",
                    kvp.Key,
                    kvp.Value.Company,
                    kvp.Value.Weight);
            }
        }
    }
}
