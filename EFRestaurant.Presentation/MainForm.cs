using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Drawing.Text;
using System.Linq;
using System.Windows.Forms;
using EFRestaurant.Data.Models;
using EFRestaurant.Data.Models.Entities;

namespace EFRestaurant.Presentation
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            _context = new RestaurantContext();

            var restaurants = RetrieveRestaurants();

            RestaurantListBox.DataSource = restaurants;
            RestaurantListBox.DisplayMember = "Name";
        }

        private readonly RestaurantContext _context;

        private BindingList<Restaurant> RetrieveRestaurants()
        {
            var restaurants = new BindingList<Restaurant>();

        foreach (var restaurant in _context.Restaurants)
        {
            restaurants.Add(restaurant);
        }

        return restaurants;
        }

        private BindingList<string> RetrieveEmployees(IEnumerable<Employee> employeeList)
        {
            var employees = new BindingList<string>();

            foreach (var employee in employeeList)
            {
                employees.Add(employee.OIB + " " + employee.FirstName + " " + employee.LastName + " " + employee.BirthYear);
            }

            return employees;
        }

        private BindingList<Recipe> RetrieveRecipes(IEnumerable<Recipe> recipeList)
        {
            var recipes = new BindingList<Recipe>();

            foreach (var recipe in recipeList)
            {
                recipes.Add(recipe);
            }

            return recipes;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }



        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void AddRestaurantButton_Click(object sender, EventArgs e)
        {
            var newRestaurantDialog= new AddRestaurantForm(_context);
            newRestaurantDialog.ShowDialog();

            var restaurants = RetrieveRestaurants();

            RestaurantListBox.DataSource = restaurants;
        }


        private void RestaurantListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IngredientsList.Clear();

            var selectedRestaurantName = RestaurantListBox.Text;
            var selectedRestaurant = _context.Restaurants.Include(restaurant => restaurant.Employees).Include(restaurant => restaurant.Recipes).FirstOrDefault(restaurant => restaurant.Name == selectedRestaurantName);

            if (selectedRestaurant == null)
                return;

            KitchenModelLabel.Text = selectedRestaurant.KitchenModel.Name + ", price: " + selectedRestaurant.KitchenModel.Price;

            var employees = RetrieveEmployees(selectedRestaurant.Employees);
            EmployeeListBox.DataSource = employees;


            var recipes = RetrieveRecipes(selectedRestaurant.Recipes);
            RecipeListBox.DataSource = recipes;
            RecipeListBox.DisplayMember = "Name";
        }

        private void RecipeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IngredientsList.Clear();

            var selectedRecipeName = RecipeListBox.Text;
            var selectedRecipe = _context.Recipes.Include(recipe=>recipe.Ingredients).FirstOrDefault(recipe => recipe.Name == selectedRecipeName);

            if (selectedRecipe == null)
                return;

            foreach (var ingredient in selectedRecipe.Ingredients)
            {
                IngredientsList.Items.Add(ingredient.Name);
            }
        }

        private void DeleteRestaurantButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(RestaurantListBox.Text))
                return;

            var selectedRestaurantName = RestaurantListBox.Text;
            var restaurantToDelete = _context.Restaurants.FirstOrDefault(restaurant=>restaurant.Name==selectedRestaurantName);

            if (restaurantToDelete == null)
                return;

            _context.Restaurants.Remove(restaurantToDelete);
            _context.SaveChanges();

            var restaurants = RetrieveRestaurants();

            RestaurantListBox.DataSource = restaurants;
            RestaurantListBox.DisplayMember = "Name";
        }

        private void EditRestaurantButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(RestaurantListBox.Text))
                return;

            var editRestaurantDialog = new EditRestaurantForm(_context,RestaurantListBox.Text);
            editRestaurantDialog.ShowDialog();

            var restaurants = RetrieveRestaurants();

            RestaurantListBox.DataSource = restaurants;
            RestaurantListBox.DisplayMember = "Name";
        }

        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(RestaurantListBox.Text))
                return;

            var newEmployeeDialog=new AddEmployeeForm(_context,RestaurantListBox.Text);
            newEmployeeDialog.ShowDialog();
        }

        private void DeleteEmployeeButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(EmployeeListBox.Text))
                return;

            var selectedEmployeeOIB = EmployeeListBox.Text.Substring(0,EmployeeListBox.Text.IndexOf(' '));
            var employeeToDelete = _context.Employees.Find(selectedEmployeeOIB);

            if (employeeToDelete == null)
                return;

            _context.Employees.Remove(employeeToDelete);
            _context.SaveChanges();
        }

        private void EditEmployeeButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(EmployeeListBox.Text))
                return;

            var editEmployeeDialog=new EditEmployeeForm(_context,EmployeeListBox.Text,RestaurantListBox.Text);
            editEmployeeDialog.ShowDialog();
        }

        private void AddRecipeButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(RestaurantListBox.Text))
                return;

            var addRecipeDialog = new AddRecipeForm(_context,RestaurantListBox.Text);
            addRecipeDialog.ShowDialog();
        }

        private void DeleteRecipeButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(RecipeListBox.Text))
                return;

            var selectedRecipeName = RecipeListBox.Text;
            var recipeToDelete = _context.Recipes.FirstOrDefault(recipe => recipe.Name == selectedRecipeName);

            if (recipeToDelete == null)
                return;

            _context.Recipes.Remove(recipeToDelete);
            _context.SaveChanges();
        }
    }
}
