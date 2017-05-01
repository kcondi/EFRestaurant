using System;
using System.Linq;
using System.Windows.Forms;
using EFRestaurant.Data.Models;

namespace EFRestaurant.Presentation
{
    public partial class EditRestaurantForm : Form
    {
        public EditRestaurantForm(RestaurantContext context, string restaurantToEdit)
        {
            InitializeComponent();

            _context = context;
            _restaurantToEditName = restaurantToEdit;  
                     
            EditRestaurantTextBox.Text = restaurantToEdit;
            KitchenModelComboBox.SelectedIndex = 0;
        }

        private readonly RestaurantContext _context;
        private readonly string _restaurantToEditName;
        private void OkButtonEditRestaurant_Click(object sender, EventArgs e)
        {
           var restaurantToEdit = _context.Restaurants.FirstOrDefault(restaurant => restaurant.Name == _restaurantToEditName);
       
            if (restaurantToEdit == null)
            {
                Close();
                return;
            }

            restaurantToEdit.Name = EditRestaurantTextBox.Text;

            var kitchenModelOfRestaurant = _context.KitchenModels.Find(KitchenModelComboBox.SelectedIndex + 1);

            if (kitchenModelOfRestaurant == null)
            {
                Close();
                return;
            }

            kitchenModelOfRestaurant.Restaurants.Add(restaurantToEdit);

            _context.SaveChanges();

            Close();
        }
    }
}
