using EFRestaurant.Data.Models;
using EFRestaurant.Data.Models.Entities;
using System.Linq;

namespace EFRestaurant.Domain.Repositories
{
    public class KitchenRepository
    {
        public KitchenRepository()
        {
            _context = new RestaurantContext();
        }
        private readonly RestaurantContext _context;

        public KitchenModel GetKitchenModel(int id)
        {
            return _context.KitchenModels.Find(id);
        }
    }
}
