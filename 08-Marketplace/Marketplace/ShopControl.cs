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
    public partial class ShopControl : UserControl
    {
        public ShopControl()
        {
            InitializeComponent();
        }

        internal void UpdateProductList(List<Product> productList)
        {
            list_shop.Items.Clear();

            foreach (Product product in productList)
            {
                ListViewItem item = new ListViewItem(product.Id.ToString());
                item.SubItems.Add(product.ProductName);
                item.SubItems.Add(product.Price.ToString("C"));
                list_shop.Items.Add(item);
            }
        }
    }
}
