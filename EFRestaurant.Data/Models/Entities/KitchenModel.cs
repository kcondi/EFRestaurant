using System.Collections.Generic;

namespace EFRestaurant.Data.Models.Entities
{
    public class KitchenModel
    {
        public KitchenModel()
        {
            Restaurants=new HashSet<Restaurant>();
        }
        public int Id { get; set; }

        public string Name { get; set; }

        public int Price { get; set; }

        public ICollection<Restaurant> Restaurants { get; set; }


    }
}
