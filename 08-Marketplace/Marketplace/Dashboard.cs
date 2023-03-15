using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marketplace
{
    public partial class Dashboard : Form
    {
        private readonly Store myStore = new Store();
        BindingSource cartBindingSource = new BindingSource();

        public Dashboard()
        {
            InitializeComponent();

            inventoryControl.InventoryCreated += InventoryControl_InventoryCreated;
        }

        private void InventoryControl_InventoryCreated(object sender, ProductEventArgs e)
        {
            myStore.ProductList.Add(e.Product);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Hide other user controls
            orderControl.Hide();
            inventoryControl.Hide();

            // Show current user controls
            shopControl.Show();
            shopControl.BringToFront();
        }

        private void Account_Load(object sender, EventArgs e)
        {
            shopControl.Hide();
            orderControl.Hide();
            inventoryControl.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Hide other user controls
            shopControl.Hide();
            inventoryControl.Hide();

            // Show current user controls
            orderControl.Show();
            orderControl.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Hide other user controls
            shopControl.Hide();
            orderControl.Hide();

            // Show current user controls
            inventoryControl.Show();
            inventoryControl.BringToFront();
        }

        private void btn_checkout_Click(object sender, EventArgs e)
        {
            decimal total = myStore.Checkout();
            lbl_total.Text = "$" + total.ToString();
            cartBindingSource.ResetBindings(false);
        }
    }
}
