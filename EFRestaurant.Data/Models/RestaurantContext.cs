using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFRestaurant.Data.Models.Entities;

namespace EFRestaurant.Data.Models
{
    public class RestaurantContext : DbContext
    {
        public RestaurantContext() : base("RestaurantDatabase")
        {}

        public DbSet <Restaurant> Restaurants { get; set; }
        public DbSet <Employee> Employees { get; set; }
        public DbSet <KitchenModel> KitchenModels { get; set; }
        public DbSet <Recipe> Recipes { get; set; }
        public DbSet <Ingredient> Ingredients { get; set; }

    }
}
