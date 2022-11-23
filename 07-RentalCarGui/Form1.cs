using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalCarGui
{
    public partial class Form1 : Form
    {
        int carId = 1;

        Store myStore = new Store();
        //BindingSource carInventoryBindingSource = new BindingSource();
        BindingSource cartBindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_createCar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Create car")
            Car car1 = new Car(carId, txt_make.Text, txt_model.Text, decimal.Parse(txt_price.Text));
            ListViewItem item = new ListViewItem(car1.Id.ToString());
            item.SubItems.Add(txt_make.Text);
            item.SubItems.Add(txt_model.Text);
            item.SubItems.Add(txt_price.Text);
            list_Inventory.Items.Add(item);
            carId += 1;
            //carInventoryBindingSource.ResetBindings(false);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cartBindingSource.DataSource = myStore.ShoppingList;
            list_Cart.DataSource = cartBindingSource;
            list_Cart.DisplayMember = ToString();
        }

        private void btn_addToCart_Click(object sender, EventArgs e)
        {
            // get the selected item from inventory
            ListViewItem selected = list_Inventory.SelectedItems[0];
            Car car = new Car(int.Parse(selected.SubItems[0].Text),
                    selected.SubItems[1].Text,
                    selected.SubItems[2].Text,
                    decimal.Parse(selected.SubItems[3].Text)
                );
            // add that item to the cart
            myStore.ShoppingList.Add(car);

            //upate the list box control
            cartBindingSource.ResetBindings(false);
        }

        private void btn_checkout_Click(object sender, EventArgs e)
        {
            decimal total = myStore.Checkout();
            lbl_total.Text = "$" + total.ToString();
            cartBindingSource.ResetBindings(false);

        }
    }
}
