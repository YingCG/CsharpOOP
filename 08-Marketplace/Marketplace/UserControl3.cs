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
    public partial class UserControl3 : UserControl
    {
        int productId = 1;

        public UserControl3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product product1 = new Product(productId, txt_Product.Text, int.Parse(txt_Quantity.Text), decimal.Parse(txt_Price.Text));
            ListViewItem item = new ListViewItem(product1.Id.ToString());
            item.SubItems.Add(txt_Product.Text);
            item.SubItems.Add(txt_Quantity.Text);
            item.SubItems.Add(txt_Price.Text);
            list_Inventory.Items.Add(item);
            MessageBox.Show("New stock added");
        }
    }
}
