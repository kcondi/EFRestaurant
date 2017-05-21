using System.ComponentModel.DataAnnotations;

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
        [StringLength(11)]
        public string OIB { get; set; }
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public int BirthYear { get; set; }
        [Required]
        public Roles EmployeeRole { get; set; }
        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }
    }
}
