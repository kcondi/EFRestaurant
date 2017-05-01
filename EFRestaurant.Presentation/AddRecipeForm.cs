using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using EFRestaurant.Data.Models;
using EFRestaurant.Data.Models.Entities;

namespace EFRestaurant.Presentation
{
    public partial class AddRecipeForm : Form
    {
        public AddRecipeForm(RestaurantContext context, string restaurantOfRecipe)
        {
            InitializeComponent();

            _context = context;
            _restaurantOfRecipeName = restaurantOfRecipe;
            _ingredientsToAdd = new List<Ingredient>();

            var ingredients = RetrieveIngredients();

            ExistingIngredientsListBox.DataSource = ingredients;
            ExistingIngredientsListBox.DisplayMember = "Name";

            var recipes = new BindingList<Recipe>();
            foreach (var recipe in _context.Recipes)
                recipes.Add(recipe);

            ExistingRecipesListBox.DataSource = recipes;
            ExistingRecipesListBox.DisplayMember = "Name";
        }

        private readonly RestaurantContext _context;
        private readonly string _restaurantOfRecipeName;
        private readonly List<Ingredient> _ingredientsToAdd;

        private BindingList<Ingredient> RetrieveIngredients()
        {
            var ingredients = new BindingList<Ingredient>();
            foreach (var ingredient in _context.Ingredients)
                ingredients.Add(ingredient);

            return ingredients;
        }
        private void AddNewRecipeButton_Click(object sender, EventArgs e)
        {
            var restaurantOfRecipe = _context.Restaurants.FirstOrDefault(restaurant => restaurant.Name == _restaurantOfRecipeName);

            if (restaurantOfRecipe == null)
            {
                Close();
                return;
            }

            var recipeToAdd = new Recipe
            {
                Name = RecipeNameTextBoxAddRecipe.Text,
                PreparationTime = int.Parse(HoursMaskedTextBoxAddRecipe.Text)*60+int.Parse(MinutesMaskedTextBoxAddRecipe.Text)
            };

            foreach(var ingredient in _ingredientsToAdd)
                recipeToAdd.Ingredients.Add(ingredient);

            restaurantOfRecipe.Recipes.Add(recipeToAdd);
            _context.Recipes.Add(recipeToAdd);

            _context.SaveChanges();

            Close();
        }

        private void AddExistingIngredientButtonAddRecipe_Click(object sender, EventArgs e)
        {
            var existingIngredientToAdd = _context.Ingredients.FirstOrDefault(ingredient => ingredient.Name == ExistingIngredientsListBox.Text);

            if (existingIngredientToAdd == null)
                return;

            _ingredientsToAdd.Add(existingIngredientToAdd);
        }

        private void AddNewIngredientButtonAddRecipe_Click(object sender, EventArgs e)
        {
            var newIngredientToAdd = new Ingredient
            {
                Name = AddNewIngredientTextBoxAddRecipe.Text
            };

            _ingredientsToAdd.Add(newIngredientToAdd);

            _context.Ingredients.Add(newIngredientToAdd);

            _context.SaveChanges();

            AddNewIngredientTextBoxAddRecipe.Clear();

            var ingredients = RetrieveIngredients();
            ExistingIngredientsListBox.DataSource = ingredients;
        }

        private void AddExistingRecipeButton_Click(object sender, EventArgs e)
        {
            var restaurantOfRecipe = _context.Restaurants.FirstOrDefault(restaurant => restaurant.Name == _restaurantOfRecipeName);

            if (restaurantOfRecipe == null)
            {
                Close();
                return;
            }

            var existingRecipeToAdd = _context.Recipes.FirstOrDefault(recipe => recipe.Name == ExistingRecipesListBox.Text);

            restaurantOfRecipe.Recipes.Add(existingRecipeToAdd);

            _context.SaveChanges();

            Close();
        }

        private void DeleteIngredientButton_Click(object sender, EventArgs e)
        {
            var ingredientToDelete = _context.Ingredients.FirstOrDefault(ingredient => ingredient.Name == ExistingIngredientsListBox.Text);

            if (ingredientToDelete == null)
                return;

            _context.Ingredients.Remove(ingredientToDelete);

            _context.SaveChanges();

            var ingredients = RetrieveIngredients();
            ExistingIngredientsListBox.DataSource = ingredients;
        }
    }
}
