
namespace IDmaker
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
            this.lbl_firstname = new System.Windows.Forms.Label();
            this.textBox_firstname = new System.Windows.Forms.TextBox();
            this.textBox_lastname = new System.Windows.Forms.TextBox();
            this.lbl_lastname = new System.Windows.Forms.Label();
            this.textBox_address = new System.Windows.Forms.TextBox();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.lbl_address = new System.Windows.Forms.Label();
            this.comboBox_gender = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btn_createUser = new System.Windows.Forms.Button();
            this.pictureBox_camera = new System.Windows.Forms.PictureBox();
            this.button_startCamera = new System.Windows.Forms.Button();
            this.comboBox_Camara = new System.Windows.Forms.ComboBox();
            this.button_Camera = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_userInfo = new System.Windows.Forms.Button();
            this.btn_readfile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_camera)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_firstname
            // 
            this.lbl_firstname.AutoSize = true;
            this.lbl_firstname.BackColor = System.Drawing.Color.Transparent;
            this.lbl_firstname.Location = new System.Drawing.Point(23, 34);
            this.lbl_firstname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_firstname.Name = "lbl_firstname";
            this.lbl_firstname.Size = new System.Drawing.Size(57, 13);
            this.lbl_firstname.TabIndex = 0;
            this.lbl_firstname.Text = "First Name";
            // 
            // textBox_firstname
            // 
            this.textBox_firstname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_firstname.Location = new System.Drawing.Point(89, 34);
            this.textBox_firstname.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_firstname.Name = "textBox_firstname";
            this.textBox_firstname.Size = new System.Drawing.Size(175, 13);
            this.textBox_firstname.TabIndex = 1;
            // 
            // textBox_lastname
            // 
            this.textBox_lastname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_lastname.Location = new System.Drawing.Point(89, 66);
            this.textBox_lastname.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_lastname.Name = "textBox_lastname";
            this.textBox_lastname.Size = new System.Drawing.Size(175, 13);
            this.textBox_lastname.TabIndex = 3;
            // 
            // lbl_lastname
            // 
            this.lbl_lastname.AutoSize = true;
            this.lbl_lastname.BackColor = System.Drawing.Color.Transparent;
            this.lbl_lastname.Location = new System.Drawing.Point(23, 66);
            this.lbl_lastname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_lastname.Name = "lbl_lastname";
            this.lbl_lastname.Size = new System.Drawing.Size(58, 13);
            this.lbl_lastname.TabIndex = 2;
            this.lbl_lastname.Text = "Last Name";
            // 
            // textBox_address
            // 
            this.textBox_address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_address.Location = new System.Drawing.Point(89, 138);
            this.textBox_address.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_address.Multiline = true;
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(175, 77);
            this.textBox_address.TabIndex = 5;
            // 
            // lbl_gender
            // 
            this.lbl_gender.AutoSize = true;
            this.lbl_gender.BackColor = System.Drawing.Color.Transparent;
            this.lbl_gender.Location = new System.Drawing.Point(23, 102);
            this.lbl_gender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(42, 13);
            this.lbl_gender.TabIndex = 4;
            this.lbl_gender.Text = "Gender";
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.BackColor = System.Drawing.Color.Transparent;
            this.lbl_address.Location = new System.Drawing.Point(23, 140);
            this.lbl_address.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(42, 13);
            this.lbl_address.TabIndex = 6;
            this.lbl_address.Text = "Adress:";
            // 
            // comboBox_gender
            // 
            this.comboBox_gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_gender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_gender.FormattingEnabled = true;
            this.comboBox_gender.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.comboBox_gender.Location = new System.Drawing.Point(89, 103);
            this.comboBox_gender.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_gender.Name = "comboBox_gender";
            this.comboBox_gender.Size = new System.Drawing.Size(176, 21);
            this.comboBox_gender.TabIndex = 7;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(20, 272);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(244, 183);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // btn_createUser
            // 
            this.btn_createUser.Location = new System.Drawing.Point(20, 219);
            this.btn_createUser.Margin = new System.Windows.Forms.Padding(2);
            this.btn_createUser.Name = "btn_createUser";
            this.btn_createUser.Size = new System.Drawing.Size(244, 40);
            this.btn_createUser.TabIndex = 9;
            this.btn_createUser.Text = "Save User";
            this.btn_createUser.UseVisualStyleBackColor = true;
            this.btn_createUser.Click += new System.EventHandler(this.btn_createUser_Click);
            // 
            // pictureBox_camera
            // 
            this.pictureBox_camera.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pictureBox_camera.Location = new System.Drawing.Point(281, 79);
            this.pictureBox_camera.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_camera.Name = "pictureBox_camera";
            this.pictureBox_camera.Size = new System.Drawing.Size(579, 375);
            this.pictureBox_camera.TabIndex = 10;
            this.pictureBox_camera.TabStop = false;
            this.pictureBox_camera.DragDrop += new System.Windows.Forms.DragEventHandler(this.pictureBox_camera_DragDrop);
            this.pictureBox_camera.DragEnter += new System.Windows.Forms.DragEventHandler(this.pictureBox_camera_DragEnter);
            // 
            // button_startCamera
            // 
            this.button_startCamera.Location = new System.Drawing.Point(601, 34);
            this.button_startCamera.Margin = new System.Windows.Forms.Padding(2);
            this.button_startCamera.Name = "button_startCamera";
            this.button_startCamera.Size = new System.Drawing.Size(107, 23);
            this.button_startCamera.TabIndex = 11;
            this.button_startCamera.Text = "Start";
            this.button_startCamera.UseVisualStyleBackColor = true;
            this.button_startCamera.Click += new System.EventHandler(this.button_startCamera_Click);
            // 
            // comboBox_Camara
            // 
            this.comboBox_Camara.FormattingEnabled = true;
            this.comboBox_Camara.Location = new System.Drawing.Point(281, 34);
            this.comboBox_Camara.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_Camara.Name = "comboBox_Camara";
            this.comboBox_Camara.Size = new System.Drawing.Size(307, 21);
            this.comboBox_Camara.TabIndex = 12;
            // 
            // button_Camera
            // 
            this.button_Camera.Location = new System.Drawing.Point(721, 34);
            this.button_Camera.Margin = new System.Windows.Forms.Padding(2);
            this.button_Camera.Name = "button_Camera";
            this.button_Camera.Size = new System.Drawing.Size(107, 23);
            this.button_Camera.TabIndex = 13;
            this.button_Camera.Text = "Take photo";
            this.button_Camera.UseVisualStyleBackColor = true;
            this.button_Camera.Click += new System.EventHandler(this.button_Camera_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(281, 471);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(244, 40);
            this.button1.TabIndex = 14;
            this.button1.Text = "Save Picture";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_userInfo
            // 
            this.btn_userInfo.Location = new System.Drawing.Point(616, 471);
            this.btn_userInfo.Margin = new System.Windows.Forms.Padding(2);
            this.btn_userInfo.Name = "btn_userInfo";
            this.btn_userInfo.Size = new System.Drawing.Size(244, 40);
            this.btn_userInfo.TabIndex = 15;
            this.btn_userInfo.Text = "Save User Info";
            this.btn_userInfo.UseVisualStyleBackColor = true;
            this.btn_userInfo.Click += new System.EventHandler(this.btn_userInfo_Click);
            // 
            // btn_readfile
            // 
            this.btn_readfile.Location = new System.Drawing.Point(21, 471);
            this.btn_readfile.Margin = new System.Windows.Forms.Padding(2);
            this.btn_readfile.Name = "btn_readfile";
            this.btn_readfile.Size = new System.Drawing.Size(244, 40);
            this.btn_readfile.TabIndex = 16;
            this.btn_readfile.Text = "Find User";
            this.btn_readfile.UseVisualStyleBackColor = true;
            this.btn_readfile.Click += new System.EventHandler(this.btn_readfile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(883, 533);
            this.Controls.Add(this.btn_readfile);
            this.Controls.Add(this.btn_userInfo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_Camera);
            this.Controls.Add(this.comboBox_Camara);
            this.Controls.Add(this.button_startCamera);
            this.Controls.Add(this.pictureBox_camera);
            this.Controls.Add(this.btn_createUser);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.comboBox_gender);
            this.Controls.Add(this.lbl_address);
            this.Controls.Add(this.textBox_address);
            this.Controls.Add(this.lbl_gender);
            this.Controls.Add(this.textBox_lastname);
            this.Controls.Add(this.lbl_lastname);
            this.Controls.Add(this.textBox_firstname);
            this.Controls.Add(this.lbl_firstname);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_Closing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_camera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_firstname;
        private System.Windows.Forms.TextBox textBox_firstname;
        private System.Windows.Forms.TextBox textBox_lastname;
        private System.Windows.Forms.Label lbl_lastname;
        private System.Windows.Forms.TextBox textBox_address;
        private System.Windows.Forms.Label lbl_gender;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.ComboBox comboBox_gender;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btn_createUser;
        private System.Windows.Forms.PictureBox pictureBox_camera;
        private System.Windows.Forms.Button button_startCamera;
        private System.Windows.Forms.ComboBox comboBox_Camara;
        private System.Windows.Forms.Button button_Camera;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_userInfo;
        private System.Windows.Forms.Button btn_readfile;
    }
}

