using System.Linq;
using EFRestaurant.Data.Models;
using EFRestaurant.Data.Models.Entities;

namespace EFRestaurant.Domain.Repositories
{
    public class EmployeeRepository
    {
        public EmployeeRepository()
        {
            _context=new RestaurantContext();
        }
        private readonly RestaurantContext _context;

        public Restaurant GetRestaurant(string restaurantName)
        {
            return _context.Restaurants.FirstOrDefault(restaurant => restaurant.Name == restaurantName);
        }

        public void AddEmployee(Employee employeeToAdd)
        {
            _context.Employees.Add(employeeToAdd);
            _context.SaveChanges();
        }

        public void EditEmployee(Employee editedEmployee)
        {
            var employeeToEdit = _context.Employees.Find(editedEmployee.OIB);
            if (employeeToEdit == null)
                return;
            employeeToEdit.FirstName = editedEmployee.FirstName;
            employeeToEdit.LastName = editedEmployee.LastName;
            employeeToEdit.BirthYear = editedEmployee.BirthYear;
            employeeToEdit.EmployeeRole = editedEmployee.EmployeeRole;
            _context.SaveChanges();
        }

        public void DeleteEmployee(string employeeOib)
        {
            var employeeToDelete = _context.Employees.Find(employeeOib);
            if (employeeToDelete == null)
                return;
            _context.Employees.Remove(employeeToDelete);
            _context.SaveChanges();
        }
    }
}
