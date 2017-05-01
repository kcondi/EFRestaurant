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
    public partial class Form4 : Form
    {
        public Form4(RestaurantContext context, string restaurantOfEmployee )
        {
            _context = context;
            _restaurantOfEmployeeName = restaurantOfEmployee;
            InitializeComponent();
            MasterChefRadioAddEmployee.Checked = true;
        }

        private readonly RestaurantContext _context;
        private readonly string _restaurantOfEmployeeName;

        private void OkButtonAddEmployee_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(OIBTextBoxAddEmployee.Text))
                MessageBox.Show("OIB is a required field!");
            else if (!IsDigitsOnly(OIBTextBoxAddEmployee.Text) || OIBTextBoxAddEmployee.Text.Length != 11)
                MessageBox.Show("The entered OIB is not valid. \n It must comprise of exactly 11 strictly numerical characters.");
            else if (string.IsNullOrEmpty(LastNameTextBoxAddEmployee.Text))
                MessageBox.Show("Last name is a required field!");
            else
            {
                var temporaryRestaurant = _context.Restaurants.FirstOrDefault(x => x.Name == _restaurantOfEmployeeName);
                var employeeToAdd = new Employee
                {
                    OIB = OIBTextBoxAddEmployee.Text,
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

                if (temporaryRestaurant == null)
                {
                    Close();
                    return;
                }

                temporaryRestaurant.Employees.Add(employeeToAdd);
                _context.Employees.Add(employeeToAdd);
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
