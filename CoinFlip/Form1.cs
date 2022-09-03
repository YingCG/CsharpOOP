using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoinFlip
{
    public partial class Form1 : Form
    {
        Coin[] coins = new Coin[5];
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFlipCoins_Click(object sender, EventArgs e)
        {
            //label1.Text = coins[0].isHead + "," + coins[1].isHead + "," + coins[2].isHead + "," + coins[3].isHead + "," + coins[4].isHead;
            Random r = new Random();
            label1.Text = "";

            // display the labels
            for (int i = 0; i < coins.Length; i++)
            {
                label1.Text += coins[i].isHead + ",";
                coins[i].flipCoin(r);
            }

            // display the pictures
            if (coins[0].isHead == true)
            {
                pictureBox1.Image = coins[0].isHead ? Properties.Resources.Obverse: Properties.Resources.Reverse;
                pictureBox2.Image = coins[1].isHead ? Properties.Resources.Obverse : Properties.Resources.Reverse;
                pictureBox3.Image = coins[2].isHead ? Properties.Resources.Obverse : Properties.Resources.Reverse;
                pictureBox4.Image = coins[3].isHead ? Properties.Resources.Obverse : Properties.Resources.Reverse;
                pictureBox5.Image = coins[4].isHead ? Properties.Resources.Obverse : Properties.Resources.Reverse;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //coins[0] = new Coin(true);
            //coins[1] = new Coin(true);
            //coins[2] = new Coin(true);
            //coins[3] = new Coin(true);
            //coins[4] = new Coin(true);

            for (int i = 0; i < coins.Length; i++)
            {
                coins[i] = new Coin(false);
            }
        }
    }
}
