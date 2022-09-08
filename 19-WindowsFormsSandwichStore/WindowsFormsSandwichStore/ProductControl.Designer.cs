
namespace WindowsFormsSandwichStore
{
    partial class ProductControl
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTitle = new System.Windows.Forms.Label();
            this.txtSubTitle = new System.Windows.Forms.Label();
            this.imgIcon = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.imgIcon);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(159, 177);
            this.panel1.TabIndex = 1;
            // 
            // txtTitle
            // 
            this.txtTitle.AutoSize = true;
            this.txtTitle.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.ForeColor = System.Drawing.Color.Black;
            this.txtTitle.Location = new System.Drawing.Point(163, 33);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(62, 32);
            this.txtTitle.TabIndex = 2;
            this.txtTitle.Text = "Title";
            // 
            // txtSubTitle
            // 
            this.txtSubTitle.AutoSize = true;
            this.txtSubTitle.ForeColor = System.Drawing.Color.Black;
            this.txtSubTitle.Location = new System.Drawing.Point(165, 82);
            this.txtSubTitle.Name = "txtSubTitle";
            this.txtSubTitle.Size = new System.Drawing.Size(71, 20);
            this.txtSubTitle.TabIndex = 3;
            this.txtSubTitle.Text = "Sub Title";
            // 
            // imgIcon
            // 
            this.imgIcon.Image = global::WindowsFormsSandwichStore.Properties.Resources.fries;
            this.imgIcon.Location = new System.Drawing.Point(8, 15);
            this.imgIcon.Name = "imgIcon";
            this.imgIcon.Size = new System.Drawing.Size(144, 143);
            this.imgIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgIcon.TabIndex = 0;
            this.imgIcon.TabStop = false;
            // 
            // ProductControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.Controls.Add(this.txtSubTitle);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.panel1);
            this.Name = "ProductControl";
            this.Size = new System.Drawing.Size(470, 175);
            this.Click += new System.EventHandler(this.ProductControl_Click);
            this.MouseEnter += new System.EventHandler(this.item_MousteEnter);
            this.MouseLeave += new System.EventHandler(this.item_MousteLeave);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgIcon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtSubTitle;
        private System.Windows.Forms.Label txtTitle;
    }
}
