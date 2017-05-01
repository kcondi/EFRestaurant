using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EFRestaurant.Data.Models;
using EFRestaurant.Data.Models.Entities;

namespace EFRestaurant.Presentation
{
    public partial class AddRestaurantForm : Form
    {
        public AddRestaurantForm(RestaurantContext context)
        {
            _context = context;
            InitializeComponent();
            KitchenModelComboBox.SelectedIndex = 0;
        }

        private readonly RestaurantContext _context;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void OkButtonNewRestaurant_Click(object sender, EventArgs e)
        {
            var newRestaurantName = NewRestaurantTextBox.Text;

            if (string.IsNullOrEmpty(newRestaurantName))
            {
                Close();
                return;
            }

            var newRestaurant = new Restaurant
            {
                Name = newRestaurantName,
            };

            var kitchenModel = _context.KitchenModels.Find(KitchenModelComboBox.SelectedIndex+1);

            if (kitchenModel == null)
            {
                Close();
                return;
            }

            kitchenModel.Restaurants.Add(newRestaurant);

            _context.Restaurants.Add(newRestaurant);
            _context.SaveChanges();
        
            Close();

        }
    }
}
