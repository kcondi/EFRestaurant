using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFRestaurant.Data.Models.Entities
{
    public class Restaurant
    {
        public Restaurant()
        {
            Employees = new HashSet<Employee>();
            Recipes=new HashSet<Recipe>();
        }
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public  ICollection<Employee> Employees { get; set; }

        public  ICollection<Recipe> Recipes { get; set; }

        public int KitchenModelId { get; set; }
        public virtual KitchenModel KitchenModel { get; set; }
    }
}
