using System;
using System.Windows.Forms;
using EFRestaurant.Data.Models.Entities;
using EFRestaurant.Domain.Repositories;

namespace EFRestaurant.Presentation
{
    public partial class AddEmployeeForm : Form
    {
        public AddEmployeeForm(string selectedRestaurantName)
        {
            InitializeComponent();
            _employeeRepository=new EmployeeRepository();
            _restaurantOfEmployeeName=selectedRestaurantName;
            MasterChefRadioAddEmployee.Checked = true;
            ActiveControl = OIBMaskedTextBoxAddEmployee;
        }
        private readonly EmployeeRepository _employeeRepository;
        private readonly string _restaurantOfEmployeeName;

        private void OkButtonAddEmployee_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(OIBMaskedTextBoxAddEmployee.Text))
                MessageBox.Show("OIB is a required field!");
            else if (OIBMaskedTextBoxAddEmployee.Text.Length != 11)
                MessageBox.Show("An OIB must have 11 numbers!");
            else if (string.IsNullOrEmpty(LastNameTextBoxAddEmployee.Text))
                MessageBox.Show("Last name is a required field!");
            else
            {
                var employeeToAdd = new Employee
                {
                    OIB = OIBMaskedTextBoxAddEmployee.Text,
                    FirstName = FirstNameTextBoxAddEmployee.Text,
                    LastName = LastNameTextBoxAddEmployee.Text,
                    BirthYear = (int)BirthYearUpDownAddEmployee.Value,
                    Restaurant = _employeeRepository.GetRestaurant(_restaurantOfEmployeeName)
                };
                if (MasterChefRadioAddEmployee.Checked)
                    employeeToAdd.EmployeeRole = Roles.MainChef;
                else if (AssistantChefRadioAddEmployee.Checked)
                    employeeToAdd.EmployeeRole = Roles.AssistantChef;
                else
                    employeeToAdd.EmployeeRole = Roles.Waiter;

                _employeeRepository.AddEmployee(employeeToAdd);          
                Close();
            }
        }
    }
}
