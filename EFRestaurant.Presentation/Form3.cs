using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EFRestaurant.Data.Models;
using EFRestaurant.Data.Models.Entities;

namespace EFRestaurant.Presentation
{
    public partial class Form3 : Form
    {
        public Form3(RestaurantContext context, string restaurantToEdit)
        {
            _context = context;
            _restaurantToEditName = restaurantToEdit;
            InitializeComponent();
            EditRestaurantTextBox.Text = restaurantToEdit;
            KitchenModelComboBox.SelectedIndex = 0;
        }
        private readonly RestaurantContext _context;
        private readonly string _restaurantToEditName;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void OkButtonEditRestaurant_Click(object sender, EventArgs e)
        {
           var temporaryRestaurant = _context.Restaurants.FirstOrDefault(x => x.Name == _restaurantToEditName);
       
            if (temporaryRestaurant == null)
            {
                Close();
                return;
            }

            temporaryRestaurant.Name = EditRestaurantTextBox.Text;

            var kitchenModel = _context.KitchenModels.Find(KitchenModelComboBox.SelectedIndex + 1);

            if (kitchenModel == null)
            {
                Close();
                return;
            }

            kitchenModel.Restaurants.Add(temporaryRestaurant);

            _context.SaveChanges();

            Close();

        }
    }
}
