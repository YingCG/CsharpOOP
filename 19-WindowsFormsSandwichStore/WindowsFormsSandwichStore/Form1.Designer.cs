
namespace WindowsFormsSandwichStore
{
    partial class Form1
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
            this.btn_AddToCart = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayout
            // 
            this.flowLayout.BackColor = System.Drawing.Color.DarkOrange;
            this.flowLayout.Location = new System.Drawing.Point(0, -1);
            this.flowLayout.Name = "flowLayout";
            this.flowLayout.Size = new System.Drawing.Size(464, 537);
            this.flowLayout.TabIndex = 0;
            // 
            // txtTitle
            // 
            this.txtTitle.AutoSize = true;
            this.txtTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(519, 282);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(67, 31);
            this.txtTitle.TabIndex = 2;
            this.txtTitle.Text = "Title";
            // 
            // txtSubtitle
            // 
            this.txtSubtitle.AutoSize = true;
            this.txtSubtitle.Location = new System.Drawing.Point(521, 317);
            this.txtSubtitle.Name = "txtSubtitle";
            this.txtSubtitle.Size = new System.Drawing.Size(71, 20);
            this.txtSubtitle.TabIndex = 3;
            this.txtSubtitle.Text = "Sub Title";
            // 
            // btn_AddToCart
            // 
            this.btn_AddToCart.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_AddToCart.ForeColor = System.Drawing.Color.White;
            this.btn_AddToCart.Location = new System.Drawing.Point(525, 370);
            this.btn_AddToCart.Name = "btn_AddToCart";
            this.btn_AddToCart.Size = new System.Drawing.Size(214, 45);
            this.btn_AddToCart.TabIndex = 5;
            this.btn_AddToCart.Text = "Add to Cart";
            this.btn_AddToCart.UseVisualStyleBackColor = false;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox.Image = global::WindowsFormsSandwichStore.Properties.Resources.sandwich;
            this.pictureBox.Location = new System.Drawing.Point(540, 82);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(176, 186);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(800, 535);
            this.Controls.Add(this.btn_AddToCart);
            this.Controls.Add(this.txtSubtitle);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.flowLayout);
            this.Name = "Form1";
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
        private System.Windows.Forms.Button btn_AddToCart;
    }
}

