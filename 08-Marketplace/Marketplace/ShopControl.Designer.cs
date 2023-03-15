
namespace Marketplace
{
    partial class ShopControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.list_shop = new System.Windows.Forms.ListView();
            this.column_Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_product = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Home";
            // 
            // list_shop
            // 
            this.list_shop.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_Id,
            this.column_product,
            this.column_price});
            this.list_shop.FullRowSelect = true;
            this.list_shop.HideSelection = false;
            this.list_shop.Location = new System.Drawing.Point(27, 77);
            this.list_shop.Name = "list_shop";
            this.list_shop.Size = new System.Drawing.Size(413, 256);
            this.list_shop.TabIndex = 19;
            this.list_shop.UseCompatibleStateImageBehavior = false;
            this.list_shop.View = System.Windows.Forms.View.Details;
            // 
            // column_Id
            // 
            this.column_Id.Text = "Id";
            this.column_Id.Width = 25;
            // 
            // column_product
            // 
            this.column_product.Text = "Product";
            this.column_product.Width = 256;
            // 
            // column_price
            // 
            this.column_price.Text = "Price";
            this.column_price.Width = 240;
            // 
            // ShopControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.list_shop);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ShopControl";
            this.Size = new System.Drawing.Size(467, 357);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView list_shop;
        private System.Windows.Forms.ColumnHeader column_Id;
        private System.Windows.Forms.ColumnHeader column_product;
        private System.Windows.Forms.ColumnHeader column_price;
    }
}
