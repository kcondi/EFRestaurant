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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var context = new RestaurantContext();
            context.Restaurants.Add(new Restaurant() { Name = "Vuka", KitchenModelId = 2 });
            context.SaveChanges();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             
        }
    }
}
