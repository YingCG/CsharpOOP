
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
            this.list_Inventory = new System.Windows.Forms.ListView();
            this.column_Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_made = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_model = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            // list_Inventory
            // 
            this.list_Inventory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_Id,
            this.column_made,
            this.column_model,
            this.column_price});
            this.list_Inventory.FullRowSelect = true;
            this.list_Inventory.HideSelection = false;
            this.list_Inventory.Location = new System.Drawing.Point(27, 77);
            this.list_Inventory.Name = "list_Inventory";
            this.list_Inventory.Size = new System.Drawing.Size(413, 256);
            this.list_Inventory.TabIndex = 19;
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
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.list_Inventory);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(467, 357);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView list_Inventory;
        private System.Windows.Forms.ColumnHeader column_Id;
        private System.Windows.Forms.ColumnHeader column_made;
        private System.Windows.Forms.ColumnHeader column_model;
        private System.Windows.Forms.ColumnHeader column_price;
    }
}
