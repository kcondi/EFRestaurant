using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFRestaurant.Data.Models.Entities
{
    public class Ingredient
    {
        public Ingredient()
        {
            Recipes=new HashSet<Recipe>();
        }
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }

        public ICollection<Recipe> Recipes { get; set; }


    }
}
