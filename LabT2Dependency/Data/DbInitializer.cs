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
        }
    }
}
