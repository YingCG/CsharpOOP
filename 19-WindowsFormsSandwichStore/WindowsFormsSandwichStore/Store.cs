using System;
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
        public void HandleProductSelected(object source, ProductEventArgs e)
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
                    ProductImage = Properties.Resources.sandwich,
                    Price = 10m
                },
                new Product
                {
                    Title = "Fries",
                    Subtitle = "Fries with herb or spice",
                    ProductImage = Properties.Resources.fries,
                    Price = 3m

                },
                new Product
                {
                    Title = "Drink",
                    Subtitle = "Fresh fruit juice",
                    ProductImage = Properties.Resources.drinks,
                    Price = 2m
                },
            };

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
