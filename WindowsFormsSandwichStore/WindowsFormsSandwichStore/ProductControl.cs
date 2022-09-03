using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsSandwichStore
{
    public partial class ProductControl : UserControl
    {
        private Product _product;

        public ProductControl()
        {
            InitializeComponent();
            foreach (Control control in Controls)
            {
                control.Click += ProductControl_Click;
            }
        }

        internal Product Product
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
            }
        }

        // We say to the consumers that this is the shape of their mailbox
        public event ProductEventHandler OnProductSelected;

        private void ProductControl_Click(object sender, EventArgs e)
        {
            // We post a message to the mail box
            OnProductSelected?.Invoke(sender, new ProductEventArgs(_product));
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
