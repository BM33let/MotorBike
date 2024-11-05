using System.Collections.Generic;
using DIRTBIKESBM.Models;

namespace DIRTBIKESBM.Data
{
    public static class SeedCategories
    {
        public static List<Category> GetCategories()
        {
            return new List<Category>
            {
                new Category { Id = 1, Name = "Dirt Bikes" },
                new Category { Id = 2, Name = "Enduro Bikes" },
                new Category { Id = 3, Name = "Motocross Bikes" }
            };
        }
    }
}
