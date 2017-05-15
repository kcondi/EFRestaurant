using System;
using System.Windows.Forms;
using EFRestaurant.Data.Models.Entities;
using EFRestaurant.Domain.Repositories;

namespace EFRestaurant.Presentation
{
    public partial class AddRestaurantForm : Form
    {
        public AddRestaurantForm()
        {
            InitializeComponent();
            _restaurantRepository = new RestaurantRepository();
            KitchenModelComboBox.SelectedIndex = 0;
        }
        private readonly RestaurantRepository _restaurantRepository;

        private void OkButtonNewRestaurant_Click(object sender, EventArgs e)
        {
            var restaurantToAdd = new Restaurant()
            {
                Name = NewRestaurantTextBox.Text,
                KitchenModel = _restaurantRepository.GetKitchenModel(KitchenModelComboBox.SelectedIndex+1)
            };
            if (string.IsNullOrEmpty(restaurantToAdd.Name))
            {
                Close();
                return;
            }
            _restaurantRepository.AddRestaurant(restaurantToAdd);     
            Close();
        }
    }
}
