using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFRestaurant.Data.Models.Entities
{
    public class Recipe
    {
        public Recipe()
        {
            Restaurants=new HashSet<Restaurant>();
            Ingredients=new HashSet<Ingredient>();
        }
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int PreparationTime { get; set; }
        public ICollection<Restaurant> Restaurants { get; set; }
        public ICollection<Ingredient> Ingredients { get; set; }
    }
}
