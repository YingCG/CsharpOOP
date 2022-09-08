using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marketplace
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Hide other user controls
            userControl21.Hide();
            userControl31.Hide();

            // Show current user controls
            userControl11.Show();
            userControl11.BringToFront();
        }

        private void Account_Load(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl21.Hide();
            userControl31.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Hide other user controls
            userControl11.Hide();
            userControl31.Hide();

            // Show current user controls
            userControl21.Show();
            userControl21.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Hide other user controls
            userControl11.Hide();
            userControl21.Hide();

            // Show current user controls
            userControl31.Show();
            userControl31.BringToFront();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
