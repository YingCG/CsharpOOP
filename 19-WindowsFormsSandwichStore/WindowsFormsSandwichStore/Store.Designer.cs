
namespace WindowsFormsSandwichStore
{
    partial class Store
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.txtTitle = new System.Windows.Forms.Label();
            this.txtSubtitle = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.txbDiscount = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayout
            // 
            this.flowLayout.BackColor = System.Drawing.Color.DarkOrange;
            this.flowLayout.Location = new System.Drawing.Point(0, -1);
            this.flowLayout.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayout.Name = "flowLayout";
            this.flowLayout.Size = new System.Drawing.Size(321, 349);
            this.flowLayout.TabIndex = 0;
            // 
            // txtTitle
            // 
            this.txtTitle.AutoSize = true;
            this.txtTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(388, 184);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(46, 22);
            this.txtTitle.TabIndex = 2;
            this.txtTitle.Text = "Title";
            // 
            // txtSubtitle
            // 
            this.txtSubtitle.AutoSize = true;
            this.txtSubtitle.Location = new System.Drawing.Point(389, 207);
            this.txtSubtitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtSubtitle.MaximumSize = new System.Drawing.Size(200, 40);
            this.txtSubtitle.Name = "txtSubtitle";
            this.txtSubtitle.Size = new System.Drawing.Size(49, 13);
            this.txtSubtitle.TabIndex = 3;
            this.txtSubtitle.Text = "Sub Title";
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox.Image = global::WindowsFormsSandwichStore.Properties.Resources.sandwich;
            this.pictureBox.Location = new System.Drawing.Point(402, 54);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(117, 121);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // txbDiscount
            // 
            this.txbDiscount.Location = new System.Drawing.Point(402, 13);
            this.txbDiscount.Name = "txbDiscount";
            this.txbDiscount.Size = new System.Drawing.Size(117, 20);
            this.txbDiscount.TabIndex = 6;
            this.txbDiscount.Text = "Enter your discount";
            this.txbDiscount.TextChanged += new System.EventHandler(this.txbDiscount_TextChanged);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(389, 263);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 7;
            this.lblPrice.Text = "Price";
            // 
            // Store
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(622, 348);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txbDiscount);
            this.Controls.Add(this.txtSubtitle);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.flowLayout);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Store";
            this.Text = "SanwichStore";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayout;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label txtTitle;
        private System.Windows.Forms.Label txtSubtitle;
        private System.Windows.Forms.TextBox txbDiscount;
        private System.Windows.Forms.Label lblPrice;
    }
}

