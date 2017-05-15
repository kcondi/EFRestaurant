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

        public BindingList<string> GetAllExistingRecipes()
        {
            var recipes = new BindingList<string>();
            foreach (var recipe in _context.Recipes)
            {
                recipes.Add(recipe.Name);
            }
            return recipes;
        }

        public Recipe GetRecipe(string recipeName)
        {
            var refreshedContext=new RestaurantContext();
            return refreshedContext.Recipes.Include(x => x.Ingredients).FirstOrDefault(recipe => recipe.Name == recipeName);
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

        public BindingList<string> GetAllIngredients()
        {
            var ingredients = new BindingList<string>();
            foreach (var ingredient in _context.Ingredients)
            {
                ingredients.Add(ingredient.Name);
            }
            return ingredients;
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
