using LabT2Dependency.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabT2Dependency.Data
{
    public static class DbInitializer
    {
        public static void Initialize(TravelContext context)
        {
            context.Database.EnsureCreated();

            if (context.Journeys.Any())
            {
                return;   // DB has been seeded
            }

            List<Journey> journeys = new List<Journey>
            {
                new Journey(){StartPosition="Gothenburg", EndPosition="Stockholm", Distance=470.3}
            };
     

            foreach (var j in journeys)
            {
                context.Journeys.Add(j);
            }

            List<Journey> journeysCustomer1 = new List<Journey>
            {
                journeys[0]
            };

            var customers = new Models.Costumer[]
            {
                new Models.Costumer{ Name="Molyn", Age=26, Occupation="Programmer", Journeys = journeysCustomer1}
            };

            foreach (var c in customers)
            {
                context.Costumers.Add(c);
            }

            context.SaveChanges();
            
        }
    }
}
