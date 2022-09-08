using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsSandwichStore
{
    public partial class Store : Form
    {
        private StoreDb _db;

        public Store()
        {
            _db = new StoreDb();
            InitializeComponent();
            PopulateProductList();
        }

        // We define the action we want to do when a message is received
        public void DisplaySelectedProduct(object source, ProductEventArgs e)
        {
            pictureBox.Image = e.Product.ProductImage;
            txtTitle.Text = e.Product.Title;
            txtSubtitle.Text = e.Product.Subtitle;
        }

        private void PopulateProductList()
        {
            foreach (Product product in _db.GetProducts())
            {
                ProductControl productControl = new ProductControl
                {
                    Product = product
                };
                // We tell the product control that we are interested in the messages it is sending
                productControl.OnProductSelected += DisplaySelectedProduct;
                flowLayout.Controls.Add(productControl);
            }
        }
    }
}
