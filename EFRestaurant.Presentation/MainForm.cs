using System;
using System.ComponentModel;
using System.Windows.Forms;
using EFRestaurant.Data.Models.Entities;
using EFRestaurant.Domain.Repositories;

namespace EFRestaurant.Presentation
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            _restaurantRepository=new RestaurantRepository();
            _employeeRepository=new EmployeeRepository();
            _recipeRepository=new RecipeRepository();
            RestaurantListBox.DataSource = _restaurantRepository.GetAllRestaurants();
            RestaurantListBox.DisplayMember = "Name";
        }
        private readonly RestaurantRepository _restaurantRepository;
        private readonly EmployeeRepository _employeeRepository;
        private readonly RecipeRepository _recipeRepository;

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void AddRestaurantButton_Click(object sender, EventArgs e)
        {
            var newRestaurantDialog= new AddRestaurantForm();
            newRestaurantDialog.ShowDialog();
            RestaurantListBox.DataSource = _restaurantRepository.GetAllRestaurants();
        }

        private void RestaurantListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IngredientsList.Clear();
            var selectedRestaurant = _restaurantRepository.LoadRestaurantData(RestaurantListBox.Text);
            if (selectedRestaurant == null)
                return;

            KitchenModelLabel.Text = $@"{selectedRestaurant.KitchenModel.Name}, price: {selectedRestaurant.KitchenModel.Price}";

            var employees = new BindingList<string>();
            foreach (var employee in selectedRestaurant.Employees)
                {
                    employees.Add($"{employee.OIB} {employee.FirstName} {employee.LastName} {employee.BirthYear}");
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
            var selectedRecipe = _recipeRepository.GetRecipe(RecipeListBox.Text);
            if (selectedRecipe == null)
                return;
            foreach (var ingredient in selectedRecipe.Ingredients)
            {
                IngredientsList.Items.Add(ingredient.Name);
            }
        }

        private void DeleteRestaurantButton_Click(object sender, EventArgs e)
        {
            _restaurantRepository.DeleteRestaurant(RestaurantListBox.Text);
            RestaurantListBox.DataSource = _restaurantRepository.GetAllRestaurants();
        }

        private void EditRestaurantButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(RestaurantListBox.Text))
                return;
            var editRestaurantDialog = new EditRestaurantForm(RestaurantListBox.Text);
            editRestaurantDialog.ShowDialog();
            RestaurantListBox.DataSource = null;
            RestaurantListBox.DataSource = _restaurantRepository.GetAllRestaurants();
            RestaurantListBox.DisplayMember = "Name";
        }

        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(RestaurantListBox.Text))
                return;
            var newEmployeeDialog=new AddEmployeeForm(RestaurantListBox.Text);
            newEmployeeDialog.ShowDialog();
            RestaurantListBox_SelectedIndexChanged(sender, e);
        }

        private void DeleteEmployeeButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(EmployeeListBox.Text))
                return;        
            _employeeRepository.DeleteEmployee(EmployeeListBox.Text.Substring(0, EmployeeListBox.Text.IndexOf(' ')));
            RestaurantListBox_SelectedIndexChanged(sender,e);
        }

        private void EditEmployeeButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(EmployeeListBox.Text))
                return;
            var editEmployeeDialog=new EditEmployeeForm(EmployeeListBox.Text);
            editEmployeeDialog.ShowDialog();
            RestaurantListBox_SelectedIndexChanged(sender,e);
        }

        private void ManageRecipeButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(RestaurantListBox.Text))
                return;
            var addRecipeDialog=new AddRecipeForm(RestaurantListBox.Text);
            addRecipeDialog.ShowDialog();
            RestaurantListBox_SelectedIndexChanged(sender, e);
        }

        private void DeleteRecipeButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(RecipeListBox.Text))
                return;           
            _restaurantRepository.RemoveRecipe(RestaurantListBox.Text,RecipeListBox.Text);
            RestaurantListBox_SelectedIndexChanged(sender, e);
        }
    }
}
