using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using EFRestaurant.Data.Models;
using EFRestaurant.Data.Models.Entities;

namespace EFRestaurant.Domain.Repositories
{
    public class RestaurantRepository
    {
        public RestaurantRepository()
        {
            _context=new RestaurantContext();
        }
        private readonly RestaurantContext _context;

        public BindingList<Restaurant> GetAllRestaurants()
        {
            var refreshedContext=new RestaurantContext();
            var restaurants = new BindingList<Restaurant>();
            foreach (var restaurant in refreshedContext.Restaurants)
            {
                restaurants.Add(restaurant);
            }
            return restaurants;
        }

        public Restaurant GetRestaurant(string restaurantName)
        {
            return _context.Restaurants.FirstOrDefault(restaurant => restaurant.Name == restaurantName);
        }

        public KitchenModel GetKitchenModel(int id)
        {
            return _context.KitchenModels.Find(id);
        }

        public void AddRestaurant(Restaurant restaurantToAdd)
        {
            _context.Restaurants.Add(restaurantToAdd);
            _context.SaveChanges();
        }

        public void EditRestaurant(Restaurant editedRestaurant)
        {
            var restaurantToEdit = _context.Restaurants.Find(editedRestaurant.Id);
            if (restaurantToEdit == null)
                return;
            restaurantToEdit.Name = editedRestaurant.Name;
            restaurantToEdit.KitchenModel = editedRestaurant.KitchenModel;
            _context.SaveChanges();
        }

        public void DeleteRestaurant(string restaurantToDeleteName)
        {
            var restaurantToDelete = _context.Restaurants.FirstOrDefault(restaurant=>restaurant.Name==restaurantToDeleteName);
            if (restaurantToDelete == null)
                return;
            _context.Restaurants.Remove(restaurantToDelete);
            _context.SaveChanges();
        }

        public void RemoveRecipe(string restaurantToRemoveFromName,string recipeToRemoveName)
        {
            var restaurantToRemoveFrom = _context.Restaurants.Include(x => x.Recipes).FirstOrDefault(restaurant => restaurant.Name == restaurantToRemoveFromName);
            var recipeToRemove = _context.Recipes.FirstOrDefault(recipe => recipe.Name == recipeToRemoveName);
            restaurantToRemoveFrom.Recipes.Remove(recipeToRemove);
            _context.SaveChanges();
        }

        public Restaurant LoadRestaurants(string selectedRestaurantName)
        {
            var refreshedContext=new RestaurantContext();
            return refreshedContext.Restaurants.Include(restaurant => restaurant.Employees).Include(restaurant => restaurant.Recipes).Include(restaurant => restaurant.KitchenModel).FirstOrDefault(restaurant => restaurant.Name == selectedRestaurantName);
        }
    }
}
