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
    public partial class EditEmployeeForm : Form
    {
        public EditEmployeeForm(RestaurantContext context, string employeeToEditInfo, string restaurantOfEmployee)
        {
            _context = context;
            InitializeComponent();
            _restaurantOfEmployeeName = restaurantOfEmployee;
            employeeInfoStrings = employeeToEditInfo.Split(null);
            OIBTextBoxEditEmployee.Text = employeeInfoStrings[0];
            OIBTextBoxEditEmployee.Enabled = false;
            FirstNameTextBoxEditEmployee.Text = employeeInfoStrings[1];
            LastNameTextBoxEditEmployee.Text = employeeInfoStrings[2];
            BirthYearUpDownEditEmployee.Value = int.Parse(employeeInfoStrings[3]);
            MasterChefRadioEditEmployee.Checked = true;
        }
        private readonly RestaurantContext _context;
        private readonly string _restaurantOfEmployeeName;
        private readonly string[] employeeInfoStrings;

        private void OkButtonEditEmployee_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(LastNameTextBoxEditEmployee.Text))
                MessageBox.Show("Last name is a required field!");
            else
            {
                var temporaryRestaurant = _context.Restaurants.FirstOrDefault(x => x.Name == _restaurantOfEmployeeName);

                var employeeToEdit = _context.Employees.Find(employeeInfoStrings[0]);

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

                if (temporaryRestaurant == null)
                {
                    Close();
                    return;
                }
                _context.SaveChanges();

                Close();
            }
        }

        private bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }
    }
}
