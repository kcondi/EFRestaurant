using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EFRestaurant.Data.Models.Entities;
using EFRestaurant.Domain.Repositories;

namespace EFRestaurant.Presentation
{
    public partial class AddRecipeForm : Form
    {
        public AddRecipeForm(string selectedRestaurantName)
        {
            InitializeComponent();
            _recipeRepository=new RecipeRepository();
            _restaurantOfRecipeName = selectedRestaurantName;
            _ingredientsToAdd = new List<Ingredient>();

            var ingredients = _recipeRepository.GetAllIngredients();
            ExistingIngredientsListBox.DataSource = ingredients;
            ExistingIngredientsListBox.DisplayMember = "Name";

            var existingRecipes = _recipeRepository.GetAllExistingRecipes();
            ExistingRecipesListBox.DataSource = existingRecipes;
            ExistingRecipesListBox.DisplayMember = "Name";
        }
        private readonly RecipeRepository _recipeRepository;
        private readonly string _restaurantOfRecipeName;
        private readonly List<Ingredient> _ingredientsToAdd;

        private void AddNewRecipeButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(RecipeNameTextBoxAddRecipe.Text))
                MessageBox.Show("Recipe name is a required field!");
            else
            {
                var recipeToAdd = new Recipe
                {
                    Name = RecipeNameTextBoxAddRecipe.Text,
                    PreparationTime = (int)HoursNumericUpDown.Value * 60 + (int)MinutesNumericUpDown.Value,
                    Ingredients = _ingredientsToAdd
                };
                recipeToAdd.Restaurants.Add(_recipeRepository.GetRestaurant(_restaurantOfRecipeName));
                _recipeRepository.AddRecipe(recipeToAdd);
                Close();
            }
        }

        private void AddExistingIngredientButtonAddRecipe_Click(object sender, EventArgs e)
        {
            var existingIngredientToAdd = _recipeRepository.GetIngredient(ExistingIngredientsListBox.Text);
            _ingredientsToAdd.Add(existingIngredientToAdd);
        }

        private void AddNewIngredientButtonAddRecipe_Click(object sender, EventArgs e)
        {
            var newIngredientToAdd = new Ingredient
            {
                Name = AddNewIngredientTextBoxAddRecipe.Text
            };
            _ingredientsToAdd.Add(newIngredientToAdd);
            _recipeRepository.AddIngredient(newIngredientToAdd);
            AddNewIngredientTextBoxAddRecipe.Clear();
            ExistingIngredientsListBox.DataSource = _recipeRepository.GetAllIngredients();
        }

        private void AddExistingRecipeButton_Click(object sender, EventArgs e)
        {
            var restaurantOfRecipe = _recipeRepository.GetRestaurant(_restaurantOfRecipeName);
            _recipeRepository.AddExistingRecipe(ExistingRecipesListBox.Text,restaurantOfRecipe);
            Close();
        }

        private void DeleteIngredientButton_Click(object sender, EventArgs e)
        {
            _recipeRepository.DeleteIngredient(ExistingIngredientsListBox.Text);
            ExistingIngredientsListBox.DataSource=_recipeRepository.GetAllIngredients();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void DeleteExistingRecipeButton_Click(object sender, EventArgs e)
        {
            _recipeRepository.DeleteRecipe(ExistingRecipesListBox.Text);
            Close();
        }
    }
}
