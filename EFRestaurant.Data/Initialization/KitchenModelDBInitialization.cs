using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFRestaurant.Data.Models;
using EFRestaurant.Data.Models.Entities;

namespace EFRestaurant.Data.Initialization
{
    public class KitchenModelDBInitialization : CreateDatabaseIfNotExists<RestaurantContext>
    {
        protected override void Seed(RestaurantContext context)
        {
            var kitchenModels = new List<KitchenModel>()
            {
                new KitchenModel() {Name = "Simple Sam", Price = 7800},
                new KitchenModel() {Name = "Barbecue Set", Price = 12600},
                new KitchenModel() {Name = "Advanced CookStation", Price = 20000},
                new KitchenModel() {Name = "Rostfrei cooking center", Price = 35000},
                new KitchenModel() {Name = "Restaurant master deluxe", Price = 100000}
            };
            context.KitchenModels.AddRange(kitchenModels);
            base.Seed(context);
        }
    }
}
