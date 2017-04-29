using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFRestaurant.Data.Models.Entities;

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

        public int RestaurantId { get; set; }
        public virtual Restaurant Restaurant { get; set; }
    }
}
