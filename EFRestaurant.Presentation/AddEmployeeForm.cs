using System;
using System.Linq;
using System.Windows.Forms;
using EFRestaurant.Data.Models;
using EFRestaurant.Data.Models.Entities;

namespace EFRestaurant.Presentation
{
    public partial class AddEmployeeForm : Form
    {
        public AddEmployeeForm(RestaurantContext context, string restaurantOfEmployee )
        {
            InitializeComponent();

            _context = context;
            _restaurantOfEmployeeName = restaurantOfEmployee;

            MasterChefRadioAddEmployee.Checked = true;
        }

        private readonly RestaurantContext _context;
        private readonly string _restaurantOfEmployeeName;

        private void OkButtonAddEmployee_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(OIBMaskedTextBoxAddEmployee.Text))
                MessageBox.Show("OIB is a required field!");
            else if (OIBMaskedTextBoxAddEmployee.Text.Length != 11)
                MessageBox.Show("An OIB must have 11 characters!");
            else if (string.IsNullOrEmpty(LastNameTextBoxAddEmployee.Text))
                MessageBox.Show("Last name is a required field!");
            else
            {
                var restaurantOfEmployee = _context.Restaurants.FirstOrDefault(restaurant => restaurant.Name == _restaurantOfEmployeeName);

                if (restaurantOfEmployee == null)
                {
                    Close();
                    return;
                }

                var employeeToAdd = new Employee
                {
                    OIB = OIBMaskedTextBoxAddEmployee.Text,
                    FirstName = FirstNameTextBoxAddEmployee.Text,
                    LastName = LastNameTextBoxAddEmployee.Text,
                    BirthYear = (int)BirthYearUpDownAddEmployee.Value   
                };

                if (MasterChefRadioAddEmployee.Checked)
                    employeeToAdd.EmployeeRole = Roles.MainChef;
                else if (AssistantChefRadioAddEmployee.Checked)
                    employeeToAdd.EmployeeRole = Roles.AssistantChef;
                else
                    employeeToAdd.EmployeeRole = Roles.Waiter;             

                restaurantOfEmployee.Employees.Add(employeeToAdd);
                _context.Employees.Add(employeeToAdd);

                _context.SaveChanges();

                Close();
            }
        }
    }
}
