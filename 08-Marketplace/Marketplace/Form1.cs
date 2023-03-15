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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            List<User> users = new List<User>();
            users.Add(new User()
            {
                Username = "Staff",
                Password = "@dmin123"
            });

            users.Add(new User()
            {
                Username = "Banana",
                Password = "Test123"
            });

            users.Add(new User()
            {
                Username = "Carrot",
                Password = "maybe12"
            });

            try
            {
                User user = null;

                foreach (User candidate in users)
                {
                    if (txt_user.Text == candidate.Username && txt_passward.Text == candidate.Password)
                    {
                        user = candidate;
                        break;
                    }
                }


                if (user != null)
                {
                    this.Hide();
                    Dashboard login = new Dashboard();
                    login.Show();
                }
                else
                {
                    throw new Exception("User not found");
                }
            }
            catch
            {
                MessageBox.Show("username or password is not correct");
            }
        }
    }
}
