using System;
using System.Collections.Generic;
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

        private void PopulateProductList()
        {
            List<Product> products = new List<Product>();

            //Product[] products = new[]
            //{
            //    new Product
            //    {
            //        Title = "Sandwich",
            //        Subtitle = "With your choice of protein from kumara pattie or fried chicken",
            //        ProductImage = Properties.Resources.sandwich,
            //        Price = 10m
            //    },
            //    new Product
            //    {
            //        Title = "Fries",
            //        Subtitle = "Fries with herb or spice",
            //        ProductImage = Properties.Resources.fries,
            //        Price = 3m

            //    },
            //    new Product
            //    {
            //        Title = "Drink",
            //        Subtitle = "Fresh fruit juice",
            //        ProductImage = Properties.Resources.drinks,
            //        Price = 2m
            //    },
            //};
            products.Add(new Product() {
                Title = "Sandwich",
                Subtitle = "With your choice of protein from kumara pattie or fried chicken",
                ProductImage = Properties.Resources.sandwich,
                Price = 10m
            });

            products.Add(new Product()
            {
                Title = "Fries",
                Subtitle = "Fries with herb or spice",
                ProductImage = Properties.Resources.fries,
                Price = 3m

            });

            products.Add(new Product()
            {
                Title = "Drink",
                Subtitle = "Fresh fruit juice",
                ProductImage = Properties.Resources.drinks,
                Price = 2m

            });

            foreach (Product product in products)
            {
                ProductControl productControl = new ProductControl()
                {
                    Product = product
                };
                OnDiscountApplied += productControl.HandleApplyDiscount;
                // We tell the product control that we are interested in the messages it is sending
                productControl.OnProductSelected += HandleProductSelected;
                flowLayout.Controls.Add(productControl);
            }
        }

                // We define the action we want to do when a message is received
        public void HandleProductSelected(object source, ProductEventArgs e)
        {
            pictureBox.Image = e.Product.ProductImage;
            txtTitle.Text = e.Product.Title;
            txtSubtitle.Text = e.Product.Subtitle;
        }

        public event DiscountEventHandler OnDiscountApplied;

        private void txbDiscount_TextChanged(object sender, EventArgs e)
        {
            if (txbDiscount.Text == "15PCT")
            {
                OnDiscountApplied?.Invoke(this, new DiscountEventArgs(15));
            }
            else
            {
                OnDiscountApplied?.Invoke(this, new DiscountEventArgs(0));
            }
        }
    }
}
