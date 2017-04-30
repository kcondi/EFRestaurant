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
        [Required]
        [MaxLength(11),MinLength(11)]
        public string OIB { get; set; }

        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public int BirthYear { get; set; }

        [Required]
        public Roles EmployeeRole { get; set; }

        public int RestaurantId { get; set; }
        public virtual Restaurant Restaurant { get; set; }
    }
}
