﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFRestaurant.Data.Models.Entities
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public KitchenModel KitchenModel { get; set; }
        public KitchenModel KitchenModelId { get; set; }
        public ICollection<Employee> Employees { get; set; }

        public ICollection<Recipe> Recipes { get; set; }
    }
}
