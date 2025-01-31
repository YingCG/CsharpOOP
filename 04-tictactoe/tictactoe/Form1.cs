﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictactoe
{
    public partial class Form1 : Form
    {
        bool turn = true; //when true = xturn; false = yturn
        int turn_count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Ying", "About Tic Tac Toe");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (turn)
                btn.Text = "X";
            else
                btn.Text = "O";

            turn = !turn;
            btn.Enabled = false;
            turn_count++;

            checkForWinner();
        }

        private void checkForWinner()
        {
            bool somebodywin = false;

            //horizontal checks
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
                somebodywin = true;
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                somebodywin = true;
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
                somebodywin = true;

            //vertical checks
            if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
                somebodywin = true;
            else if ((A2.Text == B2.Text) && (B2.Text == C3.Text) && (!A2.Enabled))
                somebodywin = true;
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
                somebodywin = true;

            //diagonal checks
            if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
                somebodywin = true;
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled))
                somebodywin = true;


            if (somebodywin)
            {
                String winner = "";
                if (turn)
                    winner = "O";
                else
                    winner = "X";
                MessageBox.Show(winner + " Wins!");
                disableButtons();
            }
            else
            {
                if (turn_count == 9)
                    MessageBox.Show("It is a Draw!");
            }
        }

        private void disableButtons()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button btn = (Button)c;
                    btn.Enabled = false;
                }
            }
            catch { }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;

            try
            {
                foreach (Control c in Controls)
                {
                    Button btn = (Button)c;
                    btn.Enabled = true;
                    btn.Text = "";
                }
            }
            catch { }
        }
    }
}
