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
            _kitchenRepository = new Domain.Repositories.KitchenRepository();
            KitchenModelComboBox.SelectedIndex = 0;
        }
        private readonly RestaurantRepository _restaurantRepository;
        private readonly KitchenRepository _kitchenRepository;

        public KitchenRepository KitchenRepository => _kitchenRepository;

        private void OkButtonNewRestaurant_Click(object sender, EventArgs e)
        {          
            if (string.IsNullOrEmpty(NewRestaurantTextBox.Text))
                MessageBox.Show("The restaurant must have a name!");
            else
            {
                var restaurantToAdd = new Restaurant()
                {
                    Name = NewRestaurantTextBox.Text,
                    KitchenModel = _kitchenRepository.GetKitchenModel(KitchenModelComboBox.SelectedIndex + 1)
                };
                _restaurantRepository.AddRestaurant(restaurantToAdd);
                Close();
            }

        }
    }
}
