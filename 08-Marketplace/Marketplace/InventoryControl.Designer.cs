
namespace Marketplace
{
    partial class InventoryControl
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
            this.txt_Product = new System.Windows.Forms.TextBox();
            this.Product = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.list_Inventory = new System.Windows.Forms.ListView();
            this.column_Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_made = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_model = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txt_Quantity = new System.Windows.Forms.TextBox();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.Quantity = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Stock";
            // 
            // txt_Product
            // 
            this.txt_Product.Location = new System.Drawing.Point(109, 53);
            this.txt_Product.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Product.Name = "txt_Product";
            this.txt_Product.Size = new System.Drawing.Size(178, 20);
            this.txt_Product.TabIndex = 14;
            // 
            // Product
            // 
            this.Product.AutoSize = true;
            this.Product.Location = new System.Drawing.Point(30, 56);
            this.Product.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Product.Name = "Product";
            this.Product.Size = new System.Drawing.Size(75, 13);
            this.Product.TabIndex = 13;
            this.Product.Text = "Product Name";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(374, 53);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 28);
            this.button2.TabIndex = 12;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(306, 53);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 28);
            this.button1.TabIndex = 11;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // list_Inventory
            // 
            this.list_Inventory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_Id,
            this.column_made,
            this.column_model,
            this.column_price});
            this.list_Inventory.FullRowSelect = true;
            this.list_Inventory.HideSelection = false;
            this.list_Inventory.Location = new System.Drawing.Point(25, 137);
            this.list_Inventory.Name = "list_Inventory";
            this.list_Inventory.Size = new System.Drawing.Size(413, 203);
            this.list_Inventory.TabIndex = 18;
            this.list_Inventory.UseCompatibleStateImageBehavior = false;
            this.list_Inventory.View = System.Windows.Forms.View.Details;
            // 
            // column_Id
            // 
            this.column_Id.Text = "Id";
            this.column_Id.Width = 25;
            // 
            // column_made
            // 
            this.column_made.Text = "Product";
            this.column_made.Width = 256;
            // 
            // column_model
            // 
            this.column_model.Text = "Quantity";
            this.column_model.Width = 53;
            // 
            // column_price
            // 
            this.column_price.Text = "Price";
            this.column_price.Width = 240;
            // 
            // txt_Quantity
            // 
            this.txt_Quantity.Location = new System.Drawing.Point(109, 77);
            this.txt_Quantity.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.Size = new System.Drawing.Size(178, 20);
            this.txt_Quantity.TabIndex = 19;
            // 
            // txt_Price
            // 
            this.txt_Price.Location = new System.Drawing.Point(109, 101);
            this.txt_Price.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(178, 20);
            this.txt_Price.TabIndex = 20;
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Location = new System.Drawing.Point(30, 80);
            this.Quantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(46, 13);
            this.Quantity.TabIndex = 21;
            this.Quantity.Text = "Quantity";
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Location = new System.Drawing.Point(30, 104);
            this.Price.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(31, 13);
            this.Price.TabIndex = 22;
            this.Price.Text = "Price";
            // 
            // UserControl3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.txt_Price);
            this.Controls.Add(this.txt_Quantity);
            this.Controls.Add(this.list_Inventory);
            this.Controls.Add(this.txt_Product);
            this.Controls.Add(this.Product);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UserControl3";
            this.Size = new System.Drawing.Size(467, 357);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Product;
        private System.Windows.Forms.Label Product;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView list_Inventory;
        private System.Windows.Forms.ColumnHeader column_Id;
        private System.Windows.Forms.ColumnHeader column_made;
        private System.Windows.Forms.ColumnHeader column_model;
        private System.Windows.Forms.ColumnHeader column_price;
        private System.Windows.Forms.TextBox txt_Quantity;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.Label Quantity;
        private System.Windows.Forms.Label Price;
    }
}
