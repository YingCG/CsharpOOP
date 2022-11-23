
namespace WindowsFormsHeroApp
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
            this.lbl_name = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.checkbox_group = new System.Windows.Forms.GroupBox();
            this.chk_time = new System.Windows.Forms.CheckBox();
            this.chk_plants = new System.Windows.Forms.CheckBox();
            this.chk_heal = new System.Windows.Forms.CheckBox();
            this.chk_see = new System.Windows.Forms.CheckBox();
            this.chk_soft = new System.Windows.Forms.CheckBox();
            this.chk_strong = new System.Windows.Forms.CheckBox();
            this.chk_invisible = new System.Windows.Forms.CheckBox();
            this.chk_fly = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lst_city = new System.Windows.Forms.ListBox();
            this.btn_create = new System.Windows.Forms.Button();
            this.preferred_transport = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hScrollBar3 = new System.Windows.Forms.HScrollBar();
            this.hScrollBar2 = new System.Windows.Forms.HScrollBar();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTime_depart = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTime_arrive = new System.Windows.Forms.DateTimePicker();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lbl_tracking = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.lbl_progress = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.checkbox_group.SuspendLayout();
            this.preferred_transport.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(31, 37);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(35, 13);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(77, 31);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(185, 26);
            this.txtName.TabIndex = 1;
            // 
            // checkbox_group
            // 
            this.checkbox_group.Controls.Add(this.chk_time);
            this.checkbox_group.Controls.Add(this.chk_plants);
            this.checkbox_group.Controls.Add(this.chk_heal);
            this.checkbox_group.Controls.Add(this.chk_see);
            this.checkbox_group.Controls.Add(this.chk_soft);
            this.checkbox_group.Controls.Add(this.chk_strong);
            this.checkbox_group.Controls.Add(this.chk_invisible);
            this.checkbox_group.Controls.Add(this.chk_fly);
            this.checkbox_group.Location = new System.Drawing.Point(34, 62);
            this.checkbox_group.Margin = new System.Windows.Forms.Padding(2);
            this.checkbox_group.Name = "checkbox_group";
            this.checkbox_group.Padding = new System.Windows.Forms.Padding(2);
            this.checkbox_group.Size = new System.Drawing.Size(228, 114);
            this.checkbox_group.TabIndex = 3;
            this.checkbox_group.TabStop = false;
            this.checkbox_group.Text = "Checklist";
            // 
            // chk_time
            // 
            this.chk_time.AutoSize = true;
            this.chk_time.Location = new System.Drawing.Point(93, 86);
            this.chk_time.Margin = new System.Windows.Forms.Padding(2);
            this.chk_time.Name = "chk_time";
            this.chk_time.Size = new System.Drawing.Size(85, 17);
            this.chk_time.TabIndex = 10;
            this.chk_time.Text = "Time Control";
            this.chk_time.UseVisualStyleBackColor = true;
            // 
            // chk_plants
            // 
            this.chk_plants.AutoSize = true;
            this.chk_plants.Location = new System.Drawing.Point(93, 66);
            this.chk_plants.Margin = new System.Windows.Forms.Padding(2);
            this.chk_plants.Name = "chk_plants";
            this.chk_plants.Size = new System.Drawing.Size(90, 17);
            this.chk_plants.TabIndex = 9;
            this.chk_plants.Text = "Talk to plants";
            this.chk_plants.UseVisualStyleBackColor = true;
            // 
            // chk_heal
            // 
            this.chk_heal.AutoSize = true;
            this.chk_heal.Location = new System.Drawing.Point(93, 45);
            this.chk_heal.Margin = new System.Windows.Forms.Padding(2);
            this.chk_heal.Name = "chk_heal";
            this.chk_heal.Size = new System.Drawing.Size(82, 17);
            this.chk_heal.TabIndex = 8;
            this.chk_heal.Text = "Sound Heal";
            this.chk_heal.UseVisualStyleBackColor = true;
            // 
            // chk_see
            // 
            this.chk_see.AutoSize = true;
            this.chk_see.Location = new System.Drawing.Point(93, 25);
            this.chk_see.Margin = new System.Windows.Forms.Padding(2);
            this.chk_see.Name = "chk_see";
            this.chk_see.Size = new System.Drawing.Size(91, 17);
            this.chk_see.TabIndex = 7;
            this.chk_see.Text = "Good memory";
            this.chk_see.UseVisualStyleBackColor = true;
            // 
            // chk_soft
            // 
            this.chk_soft.AutoSize = true;
            this.chk_soft.Location = new System.Drawing.Point(16, 86);
            this.chk_soft.Margin = new System.Windows.Forms.Padding(2);
            this.chk_soft.Name = "chk_soft";
            this.chk_soft.Size = new System.Drawing.Size(45, 17);
            this.chk_soft.TabIndex = 6;
            this.chk_soft.Text = "Soft";
            this.chk_soft.UseVisualStyleBackColor = true;
            // 
            // chk_strong
            // 
            this.chk_strong.AutoSize = true;
            this.chk_strong.Location = new System.Drawing.Point(16, 66);
            this.chk_strong.Margin = new System.Windows.Forms.Padding(2);
            this.chk_strong.Name = "chk_strong";
            this.chk_strong.Size = new System.Drawing.Size(73, 17);
            this.chk_strong.TabIndex = 5;
            this.chk_strong.Text = "Learn fast";
            this.chk_strong.UseVisualStyleBackColor = true;
            // 
            // chk_invisible
            // 
            this.chk_invisible.AutoSize = true;
            this.chk_invisible.Location = new System.Drawing.Point(16, 45);
            this.chk_invisible.Margin = new System.Windows.Forms.Padding(2);
            this.chk_invisible.Name = "chk_invisible";
            this.chk_invisible.Size = new System.Drawing.Size(64, 17);
            this.chk_invisible.TabIndex = 4;
            this.chk_invisible.Text = "Invisible";
            this.chk_invisible.UseVisualStyleBackColor = true;
            // 
            // chk_fly
            // 
            this.chk_fly.AutoSize = true;
            this.chk_fly.Location = new System.Drawing.Point(16, 25);
            this.chk_fly.Margin = new System.Windows.Forms.Padding(2);
            this.chk_fly.Name = "chk_fly";
            this.chk_fly.Size = new System.Drawing.Size(39, 17);
            this.chk_fly.TabIndex = 3;
            this.chk_fly.Text = "Fly";
            this.chk_fly.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 190);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Locations";
            // 
            // lst_city
            // 
            this.lst_city.FormattingEnabled = true;
            this.lst_city.Items.AddRange(new object[] {
            "Auckland",
            "Wellington",
            "Chrischurch"});
            this.lst_city.Location = new System.Drawing.Point(34, 205);
            this.lst_city.Margin = new System.Windows.Forms.Padding(2);
            this.lst_city.Name = "lst_city";
            this.lst_city.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lst_city.Size = new System.Drawing.Size(228, 56);
            this.lst_city.TabIndex = 5;
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(361, 635);
            this.btn_create.Margin = new System.Windows.Forms.Padding(2);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(137, 32);
            this.btn_create.TabIndex = 6;
            this.btn_create.Text = "Create Hero";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // preferred_transport
            // 
            this.preferred_transport.Controls.Add(this.radioButton4);
            this.preferred_transport.Controls.Add(this.radioButton3);
            this.preferred_transport.Controls.Add(this.radioButton2);
            this.preferred_transport.Controls.Add(this.radioButton1);
            this.preferred_transport.Location = new System.Drawing.Point(34, 279);
            this.preferred_transport.Margin = new System.Windows.Forms.Padding(2);
            this.preferred_transport.Name = "preferred_transport";
            this.preferred_transport.Padding = new System.Windows.Forms.Padding(2);
            this.preferred_transport.Size = new System.Drawing.Size(229, 72);
            this.preferred_transport.TabIndex = 11;
            this.preferred_transport.TabStop = false;
            this.preferred_transport.Text = "Radio Button";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(104, 44);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(52, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.Text = "Flying";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(104, 18);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(80, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "Skateboard";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(15, 41);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(59, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Cycling";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(15, 18);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(64, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Walking";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.hScrollBar3);
            this.groupBox1.Controls.Add(this.hScrollBar2);
            this.groupBox1.Controls.Add(this.hScrollBar1);
            this.groupBox1.Location = new System.Drawing.Point(34, 373);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 166);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Scroll bar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 118);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "33";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 118);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Strenght: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 71);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "33";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 71);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Stamina: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "33";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Speed: ";
            // 
            // hScrollBar3
            // 
            this.hScrollBar3.Location = new System.Drawing.Point(11, 131);
            this.hScrollBar3.Name = "hScrollBar3";
            this.hScrollBar3.Size = new System.Drawing.Size(204, 24);
            this.hScrollBar3.TabIndex = 2;
            // 
            // hScrollBar2
            // 
            this.hScrollBar2.Location = new System.Drawing.Point(11, 87);
            this.hScrollBar2.Name = "hScrollBar2";
            this.hScrollBar2.Size = new System.Drawing.Size(204, 24);
            this.hScrollBar2.TabIndex = 1;
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(11, 38);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(204, 24);
            this.hScrollBar1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTime_arrive);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.dateTime_depart);
            this.groupBox2.Location = new System.Drawing.Point(279, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(241, 158);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Date Picker";
            // 
            // dateTime_depart
            // 
            this.dateTime_depart.Location = new System.Drawing.Point(6, 42);
            this.dateTime_depart.Name = "dateTime_depart";
            this.dateTime_depart.Size = new System.Drawing.Size(200, 20);
            this.dateTime_depart.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 26);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Depart Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 77);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Arrival Date";
            // 
            // dateTime_arrive
            // 
            this.dateTime_arrive.Location = new System.Drawing.Point(8, 97);
            this.dateTime_arrive.Name = "dateTime_arrive";
            this.dateTime_arrive.Size = new System.Drawing.Size(200, 20);
            this.dateTime_arrive.TabIndex = 3;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(8, 42);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 14;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.numericUpDown1);
            this.groupBox3.Location = new System.Drawing.Point(279, 205);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(241, 78);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Number Picker";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 26);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Check-in Luggage";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pictureBox1);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Location = new System.Drawing.Point(279, 297);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(241, 78);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Color Picker";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 26);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Color choice:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(82, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.lbl_progress);
            this.groupBox5.Controls.Add(this.trackBar1);
            this.groupBox5.Controls.Add(this.lbl_tracking);
            this.groupBox5.Location = new System.Drawing.Point(279, 396);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(241, 98);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Progress Bar";
            // 
            // lbl_tracking
            // 
            this.lbl_tracking.AutoSize = true;
            this.lbl_tracking.Location = new System.Drawing.Point(5, 26);
            this.lbl_tracking.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_tracking.Name = "lbl_tracking";
            this.lbl_tracking.Size = new System.Drawing.Size(0, 13);
            this.lbl_tracking.TabIndex = 1;
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 3;
            this.trackBar1.Location = new System.Drawing.Point(10, 19);
            this.trackBar1.Maximum = 5;
            this.trackBar1.Minimum = -5;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(225, 45);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // lbl_progress
            // 
            this.lbl_progress.AutoSize = true;
            this.lbl_progress.Location = new System.Drawing.Point(193, 75);
            this.lbl_progress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_progress.Name = "lbl_progress";
            this.lbl_progress.Size = new System.Drawing.Size(13, 13);
            this.lbl_progress.TabIndex = 4;
            this.lbl_progress.Text = "5";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(122, 75);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Progress:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(532, 689);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.preferred_transport);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.lst_city);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkbox_group);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lbl_name);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Hero App";
            this.checkbox_group.ResumeLayout(false);
            this.checkbox_group.PerformLayout();
            this.preferred_transport.ResumeLayout(false);
            this.preferred_transport.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox checkbox_group;
        private System.Windows.Forms.CheckBox chk_time;
        private System.Windows.Forms.CheckBox chk_plants;
        private System.Windows.Forms.CheckBox chk_heal;
        private System.Windows.Forms.CheckBox chk_see;
        private System.Windows.Forms.CheckBox chk_soft;
        private System.Windows.Forms.CheckBox chk_strong;
        private System.Windows.Forms.CheckBox chk_invisible;
        private System.Windows.Forms.CheckBox chk_fly;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lst_city;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.GroupBox preferred_transport;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.HScrollBar hScrollBar3;
        public System.Windows.Forms.HScrollBar hScrollBar2;
        public System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTime_arrive;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTime_depart;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl_progress;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label lbl_tracking;
    }
}

