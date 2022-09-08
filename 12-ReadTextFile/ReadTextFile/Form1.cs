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

namespace ReadTextFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\Ying\Desktop\CsharpOOP-WindowsForm\12ReadTextFile\ReadTextFile\MyText.txt";
            StreamReader stream = new StreamReader(path);
            string fileData = stream.ReadToEnd();
            richTextBox1.Text = fileData.ToString();
            stream.Close();
        }
    }
}
