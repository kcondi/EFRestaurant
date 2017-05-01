using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EFRestaurant.Data.Models;
using EFRestaurant.Data.Models.Entities;

namespace EFRestaurant.Presentation
{
    public partial class Form6 : Form
    {
        public Form6(RestaurantContext context, string restaurantOfRecipe)
        {
            _restaurantOfRecipeName = restaurantOfRecipe;
            _context = context;
                        InitializeComponent();
            var ingredients = new BindingList<Ingredient>();
            foreach (var ingredient in _context.Ingredients)
                ingredients.Add(ingredient);
            ExistingIngredientsListBox.DataSource = ingredients;
            ExistingIngredientsListBox.DisplayMember = "Name";

            var recipes = new BindingList<Recipe>();
            foreach (var recipe in _context.Recipes)
                recipes.Add(recipe);
            ExistingRecipesListBox.DataSource = recipes;
            ExistingRecipesListBox.DisplayMember = "Name";

            _ingredientsToAdd=new List<Ingredient>();
        }

        private readonly string _restaurantOfRecipeName;
        private readonly RestaurantContext _context;
        private readonly List<Ingredient> _ingredientsToAdd;

        private void AddNewRecipeButton_Click(object sender, EventArgs e)
        {
            var recipeRestaurant = _context.Restaurants.FirstOrDefault(x => x.Name == _restaurantOfRecipeName);

            if (recipeRestaurant == null)
            {
                Close();
                return;
            }

            var recipeToAdd = new Recipe
            {
                Name = RecipeNameTextBoxAddRecipe.Text,
                PreparationTime = (int.Parse(HoursMaskedTextBoxAddRecipe.Text))*60+int.Parse(MinutesMaskedTextBoxAddRecipe.Text)
            };

            foreach(var ingredient in _ingredientsToAdd)
                recipeToAdd.Ingredients.Add(ingredient);

            recipeRestaurant.Recipes.Add(recipeToAdd);
            _context.Recipes.Add(recipeToAdd);

            _context.SaveChanges();

            Close();
        }

        private void AddExistingIngredientButtonAddRecipe_Click(object sender, EventArgs e)
        {
            var ingredientToAdd = _context.Ingredients.FirstOrDefault(x=>x.Name==ExistingIngredientsListBox.Text);

            if (ingredientToAdd == null)
                return;

            _ingredientsToAdd.Add(ingredientToAdd);
        }

        private void AddNewIngredientButtonAddRecipe_Click(object sender, EventArgs e)
        {
            var ingredientToAdd = new Ingredient
            {
                Name = AddNewIngredientTextBoxAddRecipe.Text
            };

            _ingredientsToAdd.Add(ingredientToAdd);

            _context.Ingredients.Add(ingredientToAdd);

            _context.SaveChanges();
        }

        private void AddExistingRecipeButton_Click(object sender, EventArgs e)
        {
            var recipeRestaurant = _context.Restaurants.FirstOrDefault(x => x.Name == _restaurantOfRecipeName);

            if (recipeRestaurant == null)
            {
                Close();
                return;
            }

            var existingRecipeToAdd = _context.Recipes.FirstOrDefault(x => x.Name == ExistingRecipesListBox.Text);

            recipeRestaurant.Recipes.Add(existingRecipeToAdd);

            _context.SaveChanges();

            Close();
        }

        private void DeleteIngredientButton_Click(object sender, EventArgs e)
        {
            var ingredientToDelete = _context.Ingredients.FirstOrDefault(x => x.Name == ExistingIngredientsListBox.Text);

            if (ingredientToDelete == null)
                return;

            _context.Ingredients.Remove(ingredientToDelete);

            _context.SaveChanges();
        }
    }
}
