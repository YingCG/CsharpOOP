using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsSandwichStore
{
    public partial class ProductControl : UserControl
    {
        private Product _product;

        public Product Product
        {
            private get
            {
                return _product;
            }
            set
            {
                _product = value;
                txtTitle.Text = value.Title;
                txtSubTitle.Text = value.Subtitle;
                imgIcon.Image = value.ProductImage;
                lblPrice.Text = value.Price.ToString("C");
            }
        }

        public ProductControl()
        {
            InitializeComponent();
            foreach (Control control in Controls)
            {
                control.Click += ProductControl_Click;
            }
        }


        // We say to the consumers that this is the shape of their mailbox
        public event ProductEventHandler OnProductSelected;

        private void ProductControl_Click(object sender, EventArgs e)
        {
            // We post a message to the mail box
            OnProductSelected?.Invoke(sender, new ProductEventArgs(_product));

            //if (OnProductSelected != null)
            //{
            //    OnProductSelected(sender, new ProductEventArgs(_product));
            //}
        }

        public void HandleApplyDiscount(object source, DiscountEventArgs e)
        {
            var discount = _product.Price * e.DiscountPercentage / 100;
            lblPrice.Text = (_product.Price - discount).ToString("C");
        }


        // Hover Effect
        private void item_MousteEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(251,223,7);
        }

        private void item_MousteLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.PeachPuff;
        }
    }
}
