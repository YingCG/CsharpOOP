using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsHeroApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            bool[] skills = { false, false, false, false, false, false, false, false };

            skills[1] = chk_invisible.Checked;
            skills[2] = chk_strong.Checked;
            skills[3] = chk_soft.Checked;
            skills[4] = chk_see.Checked;
            skills[5] = chk_heal.Checked;
            skills[6] = chk_plants.Checked;
            skills[7] = chk_time.Checked;

            // cities
            List<String> cities = new List<string>();

            //add the selected items to cities
            foreach(String c in lst_city.SelectedItems)
            {
                cities.Add(c);
            }

            string preferred_transport = "";
            if (radioButton1.Checked)
                preferred_transport = "Walking";
            if (radioButton2.Checked)
                preferred_transport = "Cycling";
            if (radioButton3.Checked)
                preferred_transport = "Skateboard";
            if (radioButton4.Checked)
                preferred_transport = "Flying";

            string status_message = "You have register a new hero: " + txtName.Text + "\r\n Special ablities: " ;
            if (skills[0])
                status_message += "Fly ";
            if (skills[1])
                status_message += "Invisible ";
            if (skills[2])
                status_message += "Learn fast";
            if (skills[3])
                status_message += "Soft ";
            if (skills[4])
                status_message += "Good memory";
            if (skills[5])
                status_message += "Sound Healing ";
            if (skills[6])
                status_message += "Talk to plants ";
            if (skills[7])
                status_message += "Time Control ";

            status_message += " \n location : ";
            foreach(String city in cities)
            {
                status_message += city + " ";
            }

            status_message += "\n The hero prefer to travel by " + preferred_transport;

            MessageBox.Show(status_message);

        }
    }
}
