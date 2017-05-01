using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EFRestaurant.Data.Models;
using EFRestaurant.Data.Models.Entities;

namespace EFRestaurant.Presentation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _context = new RestaurantContext();

        }

        private readonly RestaurantContext _context;
    
        private void Form1_Load(object sender, EventArgs e)
        {
            var restaurants=new BindingList<Restaurant>();
           
            foreach (var restaurant in _context.Restaurants)
            {
                restaurants.Add(restaurant);
            }

                 RestaurantListBox.DataSource = restaurants;
                 RestaurantListBox.DisplayMember = "Name";
        }



        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void AddRestaurantButton_Click(object sender, EventArgs e)
        {
            Form2 newRestaurantDialog= new Form2(_context);
            newRestaurantDialog.ShowDialog();
        }

        private void RestaurantListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IngredientsList.Clear();
            var selectedRestaurantName = RestaurantListBox.Text;
            var selectedRestaurant = _context.Restaurants.Include(restaurant => restaurant.Employees).Include(restaurant => restaurant.Recipes).FirstOrDefault(x => x.Name == selectedRestaurantName);

            if (selectedRestaurant == null) return;

            KitchenModelLabel.Text = selectedRestaurant.KitchenModel.Name + ", price: " + selectedRestaurant.KitchenModel.Price;

            var employees = new BindingList<string>();

            foreach (var employee in selectedRestaurant.Employees)
            {
                employees.Add(employee.OIB + " " + employee.FirstName + " " + employee.LastName+" "+employee.BirthYear);
            }

            EmployeeListBox.DataSource = employees;

            var recipes = new BindingList<Recipe>();

            foreach (var recipe in selectedRestaurant.Recipes)
            {
                recipes.Add(recipe);
            }

            RecipeListBox.DataSource = recipes;
            RecipeListBox.DisplayMember = "Name";
        }

        private void RecipeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IngredientsList.Clear();
            var selectedRecipeName = RecipeListBox.Text;
            var selectedRecipe = _context.Recipes.Include(recipe=>recipe.Ingredients).FirstOrDefault(x => x.Name == selectedRecipeName);

            if (selectedRecipe == null) return;

            foreach (var ingredient in selectedRecipe.Ingredients)
            {
                IngredientsList.Items.Add(ingredient.Name);
            }
        }

        private void DeleteRestaurantButton_Click(object sender, EventArgs e)
        {
            var selectedRestaurantName = RestaurantListBox.Text;
            var restaurantToDelete = _context.Restaurants.FirstOrDefault(x=>x.Name==selectedRestaurantName);
            if (restaurantToDelete == null)
                return;
            _context.Restaurants.Remove(restaurantToDelete);
            _context.SaveChanges();
        }

        private void EditRestaurantButton_Click(object sender, EventArgs e)
        {
            Form3 editRestaurantDialog = new Form3(_context,RestaurantListBox.Text);
            editRestaurantDialog.ShowDialog();
        }

        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            Form4 newEmployeeDialog=new Form4(_context,RestaurantListBox.Text);
            newEmployeeDialog.ShowDialog();
        }

        private void DeleteEmployeeButton_Click(object sender, EventArgs e)
        {
            var selectedEmployeeOIB = EmployeeListBox.Text.Substring(0,EmployeeListBox.Text.IndexOf(' '));
            var employeeToDelete = _context.Employees.Find(selectedEmployeeOIB);
            if (employeeToDelete == null)
                return;
            _context.Employees.Remove(employeeToDelete);
            _context.SaveChanges();
        }

        private void EditEmployeeButton_Click(object sender, EventArgs e)
        {
            Form5 editEmployeeDialog=new Form5(_context,EmployeeListBox.Text,RestaurantListBox.Text);
            editEmployeeDialog.ShowDialog();
        }

        private void AddRecipeButton_Click(object sender, EventArgs e)
        {
            Form6 addRecipeDialog = new Form6(_context,RestaurantListBox.Text);
            addRecipeDialog.ShowDialog();
        }

        private void DeleteRecipeButton_Click(object sender, EventArgs e)
        {
            var selectedRecipeName = RecipeListBox.Text;
            var recipeToDelete = _context.Recipes.FirstOrDefault(x => x.Name == selectedRecipeName);
            if (recipeToDelete == null)
                return;
            _context.Recipes.Remove(recipeToDelete);
            _context.SaveChanges();
        }
    }
}
