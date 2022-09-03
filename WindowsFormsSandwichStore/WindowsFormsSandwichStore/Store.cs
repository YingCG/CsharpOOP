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
        public Store()
        {
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
            Product[] products = new[]
            {
                new Product
                {
                    Title = "Sandwich",
                    Subtitle = "With your choice of protein",
                    ProductImage = Properties.Resources.sandwich
                },
                new Product
                {
                    Title = "Fries",
                    Subtitle = "Fries with herb or spice",
                    ProductImage = Properties.Resources.fries

                },
                new Product
                {
                    Title = "Drink",
                    Subtitle = "Fresh fruit juice",
                    ProductImage = Properties.Resources.drinks

                },
            };

            foreach (Product product in products)
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
