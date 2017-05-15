using System;
using System.Windows.Forms;
using EFRestaurant.Data.Models.Entities;
using EFRestaurant.Domain.Repositories;

namespace EFRestaurant.Presentation
{
    public partial class EditRestaurantForm : Form
    {
        public EditRestaurantForm(string selectedRestaurantName)
        {
            InitializeComponent();
            _restaurantRepository = new RestaurantRepository();
            _restaurantToEditName = selectedRestaurantName;
            EditRestaurantTextBox.Text = selectedRestaurantName;
            KitchenModelComboBox.SelectedIndex = 0;
        }
        private readonly RestaurantRepository _restaurantRepository;
        private readonly string _restaurantToEditName;

        private void OkButtonEditRestaurant_Click(object sender, EventArgs e)
        {
            var restaurantToEdit = _restaurantRepository.GetRestaurant(_restaurantToEditName);
            var editedRestaurant = new Restaurant()
            {
                Id=restaurantToEdit.Id,
                Name = EditRestaurantTextBox.Text,
                KitchenModel = _restaurantRepository.GetKitchenModel(KitchenModelComboBox.SelectedIndex + 1)
            };
            _restaurantRepository.EditRestaurant(editedRestaurant);
            Close();
        }
    }
}
