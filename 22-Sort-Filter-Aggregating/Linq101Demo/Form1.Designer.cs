
namespace Linq101Demo
{
    partial class Dashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.filteredPeopleList = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.allPeopleDropdown = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "All People";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // filteredPeopleList
            // 
            this.filteredPeopleList.HideSelection = false;
            this.filteredPeopleList.Location = new System.Drawing.Point(234, 68);
            this.filteredPeopleList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.filteredPeopleList.Name = "filteredPeopleList";
            this.filteredPeopleList.Size = new System.Drawing.Size(311, 186);
            this.filteredPeopleList.TabIndex = 1;
            this.filteredPeopleList.UseCompatibleStateImageBehavior = false;
            this.filteredPeopleList.View = System.Windows.Forms.View.List;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Filter List";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // allPeopleDropdown
            // 
            this.allPeopleDropdown.FormattingEnabled = true;
            this.allPeopleDropdown.Location = new System.Drawing.Point(35, 68);
            this.allPeopleDropdown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.allPeopleDropdown.Name = "allPeopleDropdown";
            this.allPeopleDropdown.Size = new System.Drawing.Size(180, 23);
            this.allPeopleDropdown.TabIndex = 3;
            this.allPeopleDropdown.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Years Experience";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(35, 134);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(46, 23);
            this.numericUpDown1.TabIndex = 6;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(35, 229);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(178, 23);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Show Selected";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 270);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.allPeopleDropdown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.filteredPeopleList);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView filteredPeopleList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox allPeopleDropdown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnUpdate;
    }
}

