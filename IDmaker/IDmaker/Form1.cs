using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using AForge.Video;
using AForge.Video.DirectShow;

namespace IDmaker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        private void btn_createUser_Click(object sender, EventArgs e)
        {
            //string filePath = @"C:\Users\yingg\source\repos\IDmaker\IDmaker\Employees" + ".txt";
            //List<string> newStaff = new List<string>();

            //foreach (String line in newStaff)
            //{
            //    Console.WriteLine(line);
            //}
            //newStaff.Add("First Name: " + textBox_firstname.Text
            //  + "\r\n Last Name: " + textBox_lastname.Text
            //  + "\r\n Gender: " + comboBox_gender.Text
            //  + "\r\nAddress: " + textBox_address.Text);
            //File.WriteAllLines(filePath, newStaff);


            //string toRead = @"C:\Users\yingg\source\repos\IDmaker\IDmaker\Employees\Employeesying.txt";

            

            //Console.ReadLine();
            StreamWriter newFile = new StreamWriter(@"F:\YingYing\CsharpOOP-WindowsForm\IDmaker\IDmaker\usersInfo\" + textBox_firstname.Text + ".txt"); // file to write the txt file for each user
            newFile.WriteLine(lbl_firstname.Text + " " + textBox_firstname.Text + " "
                + "\r\n" + lbl_lastname.Text + " " + textBox_lastname.Text + " " 
                + "\r\n" + lbl_gender.Text + " " + comboBox_gender.Text + " "
                + "\r\n" + lbl_address.Text + " " + textBox_address.Text);

            newFile.Close();

            StreamReader currentFile = new StreamReader(@"F:\YingYing\CsharpOOP-WindowsForm\IDmaker\IDmaker\usersInfo\" + textBox_firstname.Text + ".txt");
            richTextBox1.Text = currentFile.ReadToEnd();
            currentFile.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
            {
                comboBox_Camara.Items.Add(filterInfo.Name);
                comboBox_Camara.SelectedIndex = 0;
                videoCaptureDevice = new VideoCaptureDevice();
                pictureBox_camera.AllowDrop = true;
            }
        }

        private void button_startCamera_Click(object sender, EventArgs e)
        {
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[comboBox_Camara.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();
        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox_camera.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void Form1_Closing(object sender, FormClosedEventArgs e)
        {
            if (videoCaptureDevice.IsRunning == true)
            {
                videoCaptureDevice.Stop();
            }
        }
        Image img;

        private void button_Camera_Click(object sender, EventArgs e)
        {
            if (videoCaptureDevice.IsRunning == true)
            {
                videoCaptureDevice.Stop();
            }
            img = pictureBox_camera.Image;
            SaveFileDialog profile = new SaveFileDialog();
            profile.Filter = "JPG(*.JPG)|*.jpg";
            if (profile.ShowDialog() == DialogResult.OK)
            {
                img.Save(profile.FileName);
            }

        }
        private void pictureBox_camera_DragDrop(object sender, DragEventArgs e)
        {
            foreach (string pic in ((string[])e.Data.GetData(DataFormats.FileDrop)))
            {
                img = Image.FromFile(pic);
                pictureBox_camera.Image = img;
            }
        }

        private void pictureBox_camera_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "JPG(*.JPG)|*.jpg";

            if (sf.ShowDialog() == DialogResult.OK)
            {
                img.Save(sf.FileName);
            }
        }

        private void btn_userInfo_Click(object sender, EventArgs e)
        {
            StreamWriter newFile = new StreamWriter(@"F:\YingYing\CsharpOOP-WindowsForm\IDmaker\IDmaker\usersInfo\" + textBox_firstname.Text + ".txt"); // file to write the txt file for each user
            newFile.WriteLine(lbl_firstname.Text + " " + textBox_firstname.Text + " "
                + "\r\n" + lbl_lastname.Text + " " + textBox_lastname.Text + " "
                + "\r\n" + lbl_gender.Text + " " + comboBox_gender.Text + " "
                + "\r\n" + lbl_address.Text + " " + textBox_address.Text);

            newFile.Close();
            StreamReader userInfo = new StreamReader(@"F:\YingYing\CsharpOOP-WindowsForm\IDmaker\IDmaker\usersInfo\" + textBox_firstname.Text + ".txt");

            richTextBox1.Text = userInfo.ReadToEnd();
            userInfo.Close();
            pictureBox_camera.Image.Save(@"F:\YingYing\CsharpOOP-WindowsForm\IDmaker\IDmaker\usersInfo\" + textBox_firstname.Text + ".jpg");
            
        }

        private void btn_readfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog findPeople = new OpenFileDialog();
            if (findPeople.ShowDialog() == DialogResult.OK)
            {
     
                StreamReader userInfo = new StreamReader(findPeople.FileName);
                richTextBox1.Text = userInfo.ReadToEnd();
                userInfo.Close();
            }
        }
    }
}
