﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFRestaurant.Data.Initialization;
using EFRestaurant.Data.Models.Entities;

namespace EFRestaurant.Data.Models
{
    public class RestaurantContext : DbContext
    {
        public RestaurantContext() : base("RestaurantDatabase")
        {
            Database.SetInitializer(new KitchenModelDBInitialization());
        }

        public DbSet <Restaurant> Restaurants { get; set; }
        public DbSet <Employee> Employees { get; set; }
        public DbSet <KitchenModel> KitchenModels { get; set; }
        public DbSet <Recipe> Recipes { get; set; }
        public DbSet <Ingredient> Ingredients { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasRequired(x=>x.Restaurant)
                .WithMany(x=>x.Employees).HasForeignKey(x=>x.RestaurantId)
                .WillCascadeOnDelete(true);
            modelBuilder.Entity<Restaurant>().HasRequired(x => x.KitchenModel)
                .WithMany(x => x.Restaurants).HasForeignKey(x => x.KitchenModelId)
                .WillCascadeOnDelete(true);
            base.OnModelCreating(modelBuilder);
        }
    }
}
