using System;
using System.Windows.Forms;
using EFRestaurant.Data.Models.Entities;
using EFRestaurant.Domain.Repositories;

namespace EFRestaurant.Presentation
{
    public partial class EditEmployeeForm : Form
    {
        public EditEmployeeForm(string employeeToEditInfo)
        {
            InitializeComponent();
            _employeeRepository = new EmployeeRepository();
            var employeeInfoStrings = employeeToEditInfo.Split(null);
            OIBTextBoxEditEmployee.Text = employeeInfoStrings[0];
            OIBTextBoxEditEmployee.Enabled = false;
            FirstNameTextBoxEditEmployee.Text = employeeInfoStrings[1];
            LastNameTextBoxEditEmployee.Text = employeeInfoStrings[2];
            BirthYearUpDownEditEmployee.Value = int.Parse(employeeInfoStrings[3]);
            MasterChefRadioEditEmployee.Checked = true;
        }
        private readonly EmployeeRepository _employeeRepository;

        private void OkButtonEditEmployee_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(LastNameTextBoxEditEmployee.Text))
                MessageBox.Show("Last name is a required field!");
            else
            {
                var editedEmployee = new Employee()
                {
                    OIB=OIBTextBoxEditEmployee.Text,
                    FirstName = FirstNameTextBoxEditEmployee.Text,
                    LastName = LastNameTextBoxEditEmployee.Text,
                    BirthYear = (int)BirthYearUpDownEditEmployee.Value
                };         
                if (MasterChefRadioEditEmployee.Checked)
                    editedEmployee.EmployeeRole = Roles.MainChef;
                else if (AssistantChefRadioEditEmployee.Checked)
                    editedEmployee.EmployeeRole = Roles.AssistantChef;
                else
                    editedEmployee.EmployeeRole = Roles.Waiter;

                _employeeRepository.EditEmployee(editedEmployee);
                Close();
            }
        }
    }
}
