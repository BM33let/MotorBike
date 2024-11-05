using System.Collections.Generic;
using DIRTBIKESBM.Models;

namespace DIRTBIKESBM.Data
{
    public static class SeedMotors
    {
        public static List<Motor> GetMotors()
        {
            return new List<Motor>
            {
                new Motor { Id = 1, Model = "Yamaha YZ450F", Year = 2023, Price = 9899, Description = "High-performance motocross bike.", CategoryId = 1 },
                new Motor { Id = 2, Model = "KTM 450 EXC-F", Year = 2022, Price = 12499, Description = "Versatile and powerful enduro bike.", CategoryId = 2 },
                new Motor { Id = 3, Model = "Honda CRF450R", Year = 2023, Price = 8799, Description = "Lightweight and agile motocross bike.", CategoryId = 1 }
            };
        }
    }
}