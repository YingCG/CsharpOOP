using System;
using System.Windows.Forms;

namespace Marketplace
{
    public partial class InventoryControl : UserControl
    {
        int productId = 1;

        public InventoryControl()
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

            if (InventoryCreated != null)
            {
                InventoryCreated(this, new ProductEventArgs(product1));
            }

            MessageBox.Show("New stock added");
        }

        public event CreateInventoryEventHandler InventoryCreated;
    }
}
