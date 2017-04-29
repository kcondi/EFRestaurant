using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFRestaurant.Data.Models.Entities
{
    public enum Roles
    {
        MainChef,
        AssistantChef,
        Waiter
    }
    public class Employee
    {
        [Key]
        public int OIB { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int BirthYear { get; set; }

        public Roles EmployeeRole { get; set; }

        public Restaurant Restaurant { get; set; }

        public Restaurant RestaurantId { get; set; }
    }
}
