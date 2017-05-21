using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using EFRestaurant.Data.Models;
using EFRestaurant.Data.Models.Entities;
using System.Data.Entity;

namespace EFRestaurant.Domain.Repositories
{
    public class RecipeRepository
    {
        public RecipeRepository()
        {
            _context=new RestaurantContext();
        }
        private readonly RestaurantContext _context;

        public List<string> GetAllExistingRecipes()
        {
            return _context.Recipes.Select(recipe => recipe.Name).ToList();
        }

        public Recipe GetRecipe(string recipeName)
        {
            return _context.Recipes.AsNoTracking().Include(x => x.Ingredients).FirstOrDefault(recipe => recipe.Name == recipeName);
        }

        public Ingredient GetIngredient(string ingredientName)
        {
            return _context.Ingredients.FirstOrDefault(ingredient => ingredient.Name == ingredientName);
        }

        public void AddRecipe(Recipe recipeToAdd)
        {
            _context.Recipes.Add(recipeToAdd);
            _context.SaveChanges();
        }

        public void DeleteRecipe(string recipeToDeleteName)
        {
            var recipeToDelete = _context.Recipes.FirstOrDefault(recipe => recipe.Name == recipeToDeleteName);
            if (recipeToDelete == null)
                return;
            _context.Recipes.Remove(recipeToDelete);
            _context.SaveChanges();
        }

        public void AddIngredient(Ingredient ingredientToAdd)
        {
            _context.Ingredients.Add(ingredientToAdd);
            _context.SaveChanges();
        }

        public void DeleteIngredient(string ingredientToDeleteName)
        {
            var ingredientToDelete = _context.Ingredients.FirstOrDefault(ingredient => ingredient.Name == ingredientToDeleteName);
            if (ingredientToDelete == null)
                return;
            _context.Ingredients.Remove(ingredientToDelete);
            _context.SaveChanges();
        }

        public List<string> GetAllIngredients()
        {
            return _context.Ingredients.Select(ingredient => ingredient.Name).ToList();
        }

        public Restaurant GetRestaurant(string restaurantName)
        {
            return _context.Restaurants.Include(x => x.Recipes).FirstOrDefault(restaurant => restaurant.Name == restaurantName);
        }

        public void AddExistingRecipe(string existingRecipeName, Restaurant restaurantOfRecipe)
        {
            var existingRecipe = _context.Recipes.FirstOrDefault(recipe => recipe.Name == existingRecipeName);
            if (restaurantOfRecipe.Recipes.Any(recipe => recipe.Name == existingRecipe.Name))
                return;
            existingRecipe.Restaurants.Add(restaurantOfRecipe);
            _context.SaveChanges();
        }
    }
}
