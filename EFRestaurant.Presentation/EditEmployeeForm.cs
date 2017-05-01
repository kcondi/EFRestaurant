using System;
using System.Linq;
using System.Windows.Forms;
using EFRestaurant.Data.Models;
using EFRestaurant.Data.Models.Entities;

namespace EFRestaurant.Presentation
{
    public partial class EditEmployeeForm : Form
    {
        public EditEmployeeForm(RestaurantContext context, string employeeToEditInfo, string restaurantOfEmployee)
        {
            InitializeComponent();

            _context = context;            
            _restaurantOfEmployeeName = restaurantOfEmployee;

            _employeeInfoStrings = employeeToEditInfo.Split(null);

            OIBTextBoxEditEmployee.Text = _employeeInfoStrings[0];
            OIBTextBoxEditEmployee.Enabled = false;

            FirstNameTextBoxEditEmployee.Text = _employeeInfoStrings[1];
            LastNameTextBoxEditEmployee.Text = _employeeInfoStrings[2];
            BirthYearUpDownEditEmployee.Value = int.Parse(_employeeInfoStrings[3]);

            MasterChefRadioEditEmployee.Checked = true;
        }

        private readonly RestaurantContext _context;
        private readonly string _restaurantOfEmployeeName;
        private readonly string[] _employeeInfoStrings;

        private void OkButtonEditEmployee_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(LastNameTextBoxEditEmployee.Text))
                MessageBox.Show("Last name is a required field!");
            else
            {
                var restaurantOfEmployeeToEdit = _context.Restaurants.FirstOrDefault(restaurant => restaurant.Name == _restaurantOfEmployeeName);

                if (restaurantOfEmployeeToEdit == null)
                {
                    Close();
                    return;
                }

                var employeeToEdit = _context.Employees.Find(_employeeInfoStrings[0]);

                if (employeeToEdit == null)
                {
                    Close();
                    return;
                }

                employeeToEdit.FirstName = FirstNameTextBoxEditEmployee.Text;
                employeeToEdit.LastName = LastNameTextBoxEditEmployee.Text;
                employeeToEdit.BirthYear = (int)BirthYearUpDownEditEmployee.Value;

                if (MasterChefRadioEditEmployee.Checked)
                    employeeToEdit.EmployeeRole = Roles.MainChef;
                else if (AssistantChefRadioEditEmployee.Checked)
                    employeeToEdit.EmployeeRole = Roles.AssistantChef;
                else
                    employeeToEdit.EmployeeRole = Roles.Waiter;

                _context.SaveChanges();

                Close();
            }
        }
    }
}
