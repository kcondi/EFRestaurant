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

           /* var restaurants = new List<Restaurant>()
            {
                new Restaurant {Name = "Vuka",KitchenModelId = 1},
                new Restaurant {Name = "Konoba",KitchenModelId =2 },
                new Restaurant {Name = "Pod Lipom 25",KitchenModelId = 3}
            };
            _context.Restaurants.AddRange(restaurants);
            _context.SaveChanges();*/
             /* var employees = new List<Employee>()
              {
                  new Employee
                  {
                      OIB = "11856628057",
                      FirstName = "Kreso",
                      LastName = "Condic",
                      BirthYear = 1996,
                      EmployeeRole = Roles.MainChef,
                      Restaurant = _context.Restaurants.Find(1),
                      RestaurantId = 1
                  },
                  new Employee
                  {
                      OIB = "23298021222",
                      FirstName = "Stipe",
                      LastName = "Stipko",
                      BirthYear = 1998,
                      EmployeeRole = Roles.Waiter,
                      Restaurant = _context.Restaurants.Find(1),
                      RestaurantId = 1
                  },
                  new Employee
                  {
                      OIB = "09827162784",
                      FirstName = "Ivan",
                      LastName = "Ivandic",
                      BirthYear = 1982,
                      EmployeeRole = Roles.AssistantChef,
                      Restaurant = _context.Restaurants.Find(1),
                      RestaurantId = 1
                  },
                  new Employee
                  {
                      OIB = "40405678391",
                      FirstName = "Jerko",
                      LastName = "Jerkic",
                      BirthYear = 1984,
                      EmployeeRole = Roles.AssistantChef,
                      Restaurant = _context.Restaurants.Find(2),
                      RestaurantId = 2
                  }
              };
              _context.Employees.AddRange(employees);
              _context.SaveChanges();*/
            _context.SaveChanges();
        }

        private readonly RestaurantContext _context;
        private void Form1_Load(object sender, EventArgs e)
        {
            var restaurants = new BindingList<Restaurant>();
            foreach (var restaurant in _context.Restaurants)
            {
                restaurants.Add(restaurant);
            }

            RestaurantListBox.DataSource = restaurants;
            RestaurantListBox.DisplayMember = "Name";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 newRestaurantDialog= new Form2(_context);
            newRestaurantDialog.ShowDialog();
            RestaurantListBox.Update();
        }

        private void RestaurantListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedRestaurantName = RestaurantListBox.Text;
            var selectedRestaurant = _context.Restaurants.FirstOrDefault(x => x.Name == selectedRestaurantName);

            if (selectedRestaurant == null) return;

            KitchenModelLabel.Text = selectedRestaurant.KitchenModel.Name+", price: "+selectedRestaurant.KitchenModel.Price;
            foreach (var employee in selectedRestaurant.Employees)
            {
                EmployeeListBox.Items.Add(employee.OIB+" "+employee.FirstName + " " + employee.LastName + " " + employee.EmployeeRole);
                EmployeeListBox.Refresh();
            }
            foreach (var recipe in selectedRestaurant.Recipes)
            {
                RecipeListBox.Items.Add(recipe.Name + " " + recipe.PreparationTime);
                EmployeeListBox.Refresh();
            }
        }

        private void RecipeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedRecipeName = RecipeListBox.Text;
            var selectedRecipe = _context.Recipes.FirstOrDefault(x => x.Name == selectedRecipeName);

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
    }
}
