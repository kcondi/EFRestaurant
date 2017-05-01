using System;
using System.Windows.Forms;
using EFRestaurant.Data.Models;
using EFRestaurant.Data.Models.Entities;

namespace EFRestaurant.Presentation
{
    public partial class AddRestaurantForm : Form
    {
        public AddRestaurantForm(RestaurantContext context)
        {
            InitializeComponent();

            _context = context;

            KitchenModelComboBox.SelectedIndex = 0;
        }

        private readonly RestaurantContext _context;
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
