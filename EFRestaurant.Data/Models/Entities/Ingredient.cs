using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFRestaurant.Data.Models.Entities
{
    public class Ingredient
    {
        public int Id { get; set; }
        
        public string Name { get; set; }

        public ICollection<Recipe> Recipes { get; set; }


    }
}
