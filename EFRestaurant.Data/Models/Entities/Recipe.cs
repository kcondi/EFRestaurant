using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFRestaurant.Data.Models.Entities
{
    public class Recipe
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int PreparationTime { get; set; }

        public ICollection<Restaurant> Restaurants { get; set; }
        public ICollection<Ingredient> Ingredients { get; set; }

    }
}
