using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe_using_Buttons
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int P1Score = 0;
        int P2Score = 0;
        int turnnumber = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            if (turnnumber % 2 == 1)
                button1.Text = "x";
            else
                button1.Text = "o";
            if ((button1.Text == button2.Text) && (button2.Text == button3.Text))
            {
                if (button1.Text == "x")
                {
                    MessageBox.Show("Player 1 wins");
                    P1Score++;
                    label1.Text = "Player 1: " + P1Score.ToString();
                    button1.Text=String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
                else if (button1.Text == "o")
                {
                    MessageBox.Show("Player 2 wins");
                    P2Score++;
                    label2.Text = "Player 2: " + P2Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
                turnnumber++;
            }
            else if ((button4.Text == button5.Text) && (button5.Text == button6.Text))
            {
                if (button4.Text == "x")
                {
                    MessageBox.Show("Player 1 wins");
                    P1Score++;
                    label1.Text = "Player 1: " + P1Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
                else if (button4.Text == "o")
                {
                    MessageBox.Show("Player 2 wins");
                    P2Score++;
                    label2.Text = "Player 2: " + P2Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
            }
            else if ((button7.Text == button8.Text) && (button8.Text == button9.Text))
            {
                if (button7.Text == "x")
                {
                    MessageBox.Show("Player 1 wins");
                    P1Score++;
                    label1.Text = "Player 1: " + P1Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
                else if (button7.Text == "o")
                {
                    MessageBox.Show("Player 2 wins");
                    P2Score++;
                    label2.Text = "Player 2: " + P2Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
            }
            else if ((button1.Text == button4.Text) && (button4.Text == button7.Text))
            {
                if (button7.Text == "x")
                {
                    MessageBox.Show("Player 1 wins");
                    P1Score++;
                    label1.Text = "Player 1: " + P1Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
                else if (button7.Text == "o")
                {
                    MessageBox.Show("Player 2 wins");
                    P2Score++;
                    label2.Text = "Player 2: " + P2Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
            }
            else if ((button2.Text == button5.Text) && (button5.Text == button8.Text))
            {
                if (button2.Text == "x")
                {
                    MessageBox.Show("Player 1 wins");
                    P1Score++;
                    label1.Text = "Player 1: " + P1Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
                else if (button2.Text == "o")
                {
                    MessageBox.Show("Player 2 wins");
                    P2Score++;
                    label2.Text = "Player 2: " + P2Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
            }
            else if ((button3.Text == button6.Text) && (button6.Text == button9.Text))
            {
                if (button3.Text == "x")
                {
                    MessageBox.Show("Player 1 wins");
                    P1Score++;
                    label1.Text = "Player 1: " + P1Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
                else if (button3.Text == "o")
                {
                    MessageBox.Show("Player 2 wins");
                    P2Score++;
                    label2.Text = "Player 2: " + P2Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
            }
            else if ((button1.Text == button5.Text) && (button5.Text == button9.Text))
            {
                if (button1.Text == "x")
                {
                    MessageBox.Show("Player 1 wins");
                    P1Score++;
                    label1.Text = "Player 1: " + P1Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
                else if (button1.Text == "o")
                {
                    MessageBox.Show("Player 2 wins");
                    P2Score++;
                    label2.Text = "Player 2: " + P2Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
            }
            else if ((button7.Text == button5.Text) && (button5.Text == button3.Text))
            {
                if (button7.Text == "x")
                {
                    MessageBox.Show("Player 1 wins");
                    P1Score++;
                    label1.Text = "Player 1: " + P1Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
                else if (button7.Text == "o")
                {
                    MessageBox.Show("Player 2 wins");
                    P2Score++;
                    label2.Text = "Player 2: " + P2Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
            }
            turnnumber++;
            if (turnnumber == 9)
                MessageBox.Show("Draw");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (turnnumber % 2 == 1)
                button2.Text = "x";
            else
                button2.Text = "o";
            if ((button1.Text == button2.Text) && (button2.Text == button3.Text))
            {
                if (button1.Text == "x")
                {
                    MessageBox.Show("Player 1 wins");
                    P1Score++;
                    label1.Text = "Player 1: " + P1Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
                else if (button1.Text == "o")
                {
                    MessageBox.Show("Player 2 wins");
                    P2Score++;
                    label2.Text = "Player 2: " + P2Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
                turnnumber++;
            }
            else if ((button4.Text == button5.Text) && (button5.Text == button6.Text))
            {
                if (button4.Text == "x")
                {
                    MessageBox.Show("Player 1 wins");
                    P1Score++;
                    label1.Text = "Player 1: " + P1Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
                else if (button4.Text == "o")
                {
                    MessageBox.Show("Player 2 wins");
                    P2Score++;
                    label2.Text = "Player 2: " + P2Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
            }
            else if ((button7.Text == button8.Text) && (button8.Text == button9.Text))
            {
                if (button7.Text == "x")
                {
                    MessageBox.Show("Player 1 wins");
                    P1Score++;
                    label1.Text = "Player 1: " + P1Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
                else if (button7.Text == "o")
                {
                    MessageBox.Show("Player 2 wins");
                    P2Score++;
                    label2.Text = "Player 2: " + P2Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
            }
            else if ((button1.Text == button4.Text) && (button4.Text == button7.Text))
            {
                if (button7.Text == "x")
                {
                    MessageBox.Show("Player 1 wins");
                    P1Score++;
                    label1.Text = "Player 1: " + P1Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
                else if (button7.Text == "o")
                {
                    MessageBox.Show("Player 2 wins");
                    P2Score++;
                    label2.Text = "Player 2: " + P2Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
            }
            else if ((button2.Text == button5.Text) && (button5.Text == button8.Text))
            {
                if (button2.Text == "x")
                {
                    MessageBox.Show("Player 1 wins");
                    P1Score++;
                    label1.Text = "Player 1: " + P1Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
                else if (button2.Text == "o")
                {
                    MessageBox.Show("Player 2 wins");
                    P2Score++;
                    label2.Text = "Player 2: " + P2Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
            }
            else if ((button3.Text == button6.Text) && (button6.Text == button9.Text))
            {
                if (button3.Text == "x")
                {
                    MessageBox.Show("Player 1 wins");
                    P1Score++;
                    label1.Text = "Player 1: " + P1Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
                else if (button3.Text == "o")
                {
                    MessageBox.Show("Player 2 wins");
                    P2Score++;
                    label2.Text = "Player 2: " + P2Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
            }
            else if ((button1.Text == button5.Text) && (button5.Text == button9.Text))
            {
                if (button1.Text == "x")
                {
                    MessageBox.Show("Player 1 wins");
                    P1Score++;
                    label1.Text = "Player 1: " + P1Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
                else if (button1.Text == "o")
                {
                    MessageBox.Show("Player 2 wins");
                    P2Score++;
                    label2.Text = "Player 2: " + P2Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
            }
            else if ((button7.Text == button5.Text) && (button5.Text == button3.Text))
            {
                if (button7.Text == "x")
                {
                    MessageBox.Show("Player 1 wins");
                    P1Score++;
                    label1.Text = "Player 1: " + P1Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
                else if (button7.Text == "o")
                {
                    MessageBox.Show("Player 2 wins");
                    P2Score++;
                    label2.Text = "Player 2: " + P2Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
            }
            turnnumber++;
            if (turnnumber == 9)
                MessageBox.Show("Draw");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (turnnumber % 2 == 1)
                button3.Text = "x";
            else
                button3.Text = "o";
            if ((button1.Text == button2.Text) && (button2.Text == button3.Text))
            {
                if (button1.Text == "x")
                {
                    MessageBox.Show("Player 1 wins");
                    P1Score++;
                    label1.Text = "Player 1: " + P1Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
                else if (button1.Text == "o")
                {
                    MessageBox.Show("Player 2 wins");
                    P2Score++;
                    label2.Text = "Player 2: " + P2Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
                turnnumber++;
            }
            else if ((button4.Text == button5.Text) && (button5.Text == button6.Text))
            {
                if (button4.Text == "x")
                {
                    MessageBox.Show("Player 1 wins");
                    P1Score++;
                    label1.Text = "Player 1: " + P1Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
                else if (button4.Text == "o")
                {
                    MessageBox.Show("Player 2 wins");
                    P2Score++;
                    label2.Text = "Player 2: " + P2Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
            }
            else if ((button7.Text == button8.Text) && (button8.Text == button9.Text))
            {
                if (button7.Text == "x")
                {
                    MessageBox.Show("Player 1 wins");
                    P1Score++;
                    label1.Text = "Player 1: " + P1Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
                else if (button7.Text == "o")
                {
                    MessageBox.Show("Player 2 wins");
                    P2Score++;
                    label2.Text = "Player 2: " + P2Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
            }
            else if ((button1.Text == button4.Text) && (button4.Text == button7.Text))
            {
                if (button7.Text == "x")
                {
                    MessageBox.Show("Player 1 wins");
                    P1Score++;
                    label1.Text = "Player 1: " + P1Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
                else if (button7.Text == "o")
                {
                    MessageBox.Show("Player 2 wins");
                    P2Score++;
                    label2.Text = "Player 2: " + P2Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
            }
            else if ((button2.Text == button5.Text) && (button5.Text == button8.Text))
            {
                if (button2.Text == "x")
                {
                    MessageBox.Show("Player 1 wins");
                    P1Score++;
                    label1.Text = "Player 1: " + P1Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
                else if (button2.Text == "o")
                {
                    MessageBox.Show("Player 2 wins");
                    P2Score++;
                    label2.Text = "Player 2: " + P2Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
            }
            else if ((button3.Text == button6.Text) && (button6.Text == button9.Text))
            {
                if (button3.Text == "x")
                {
                    MessageBox.Show("Player 1 wins");
                    P1Score++;
                    label1.Text = "Player 1: " + P1Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
                else if (button3.Text == "o")
                {
                    MessageBox.Show("Player 2 wins");
                    P2Score++;
                    label2.Text = "Player 2: " + P2Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
            }
            else if ((button1.Text == button5.Text) && (button5.Text == button9.Text))
            {
                if (button1.Text == "x")
                {
                    MessageBox.Show("Player 1 wins");
                    P1Score++;
                    label1.Text = "Player 1: " + P1Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
                else if (button1.Text == "o")
                {
                    MessageBox.Show("Player 2 wins");
                    P2Score++;
                    label2.Text = "Player 2: " + P2Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
            }
            else if ((button7.Text == button5.Text) && (button5.Text == button3.Text))
            {
                if (button7.Text == "x")
                {
                    MessageBox.Show("Player 1 wins");
                    P1Score++;
                    label1.Text = "Player 1: " + P1Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
                else if (button7.Text == "o")
                {
                    MessageBox.Show("Player 2 wins");
                    P2Score++;
                    label2.Text = "Player 2: " + P2Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
            }
            turnnumber++;
            if (turnnumber == 9)
                MessageBox.Show("Draw");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (turnnumber % 2 == 1)
                button4.Text = "x";
            else
                button4.Text = "o";
            if ((button1.Text == button2.Text) && (button2.Text == button3.Text))
            {
                if (button1.Text == "x")
                {
                    MessageBox.Show("Player 1 wins");
                    P1Score++;
                    label1.Text = "Player 1: " + P1Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
                else if (button1.Text == "o")
                {
                    MessageBox.Show("Player 2 wins");
                    P2Score++;
                    label2.Text = "Player 2: " + P2Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
                turnnumber++;
            }
            else if ((button4.Text == button5.Text) && (button5.Text == button6.Text))
            {
                if (button4.Text == "x")
                {
                    MessageBox.Show("Player 1 wins");
                    P1Score++;
                    label1.Text = "Player 1: " + P1Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
                else if (button4.Text == "o")
                {
                    MessageBox.Show("Player 2 wins");
                    P2Score++;
                    label2.Text = "Player 2: " + P2Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
            }
            else if ((button7.Text == button8.Text) && (button8.Text == button9.Text))
            {
                if (button7.Text == "x")
                {
                    MessageBox.Show("Player 1 wins");
                    P1Score++;
                    label1.Text = "Player 1: " + P1Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
                else if (button7.Text == "o")
                {
                    MessageBox.Show("Player 2 wins");
                    P2Score++;
                    label2.Text = "Player 2: " + P2Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
            }
            else if ((button1.Text == button4.Text) && (button4.Text == button7.Text))
            {
                if (button7.Text == "x")
                {
                    MessageBox.Show("Player 1 wins");
                    P1Score++;
                    label1.Text = "Player 1: " + P1Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
                else if (button7.Text == "o")
                {
                    MessageBox.Show("Player 2 wins");
                    P2Score++;
                    label2.Text = "Player 2: " + P2Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
            }
            else if ((button2.Text == button5.Text) && (button5.Text == button8.Text))
            {
                if (button2.Text == "x")
                {
                    MessageBox.Show("Player 1 wins");
                    P1Score++;
                    label1.Text = "Player 1: " + P1Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
                else if (button2.Text == "o")
                {
                    MessageBox.Show("Player 2 wins");
                    P2Score++;
                    label2.Text = "Player 2: " + P2Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
            }
            else if ((button3.Text == button6.Text) && (button6.Text == button9.Text))
            {
                if (button3.Text == "x")
                {
                    MessageBox.Show("Player 1 wins");
                    P1Score++;
                    label1.Text = "Player 1: " + P1Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
                else if (button3.Text == "o")
                {
                    MessageBox.Show("Player 2 wins");
                    P2Score++;
                    label2.Text = "Player 2: " + P2Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
            }
            else if ((button1.Text == button5.Text) && (button5.Text == button9.Text))
            {
                if (button1.Text == "x")
                {
                    MessageBox.Show("Player 1 wins");
                    P1Score++;
                    label1.Text = "Player 1: " + P1Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
                else if (button1.Text == "o")
                {
                    MessageBox.Show("Player 2 wins");
                    P2Score++;
                    label2.Text = "Player 2: " + P2Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
            }
            else if ((button7.Text == button5.Text) && (button5.Text == button3.Text))
            {
                if (button7.Text == "x")
                {
                    MessageBox.Show("Player 1 wins");
                    P1Score++;
                    label1.Text = "Player 1: " + P1Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
                else if (button7.Text == "o")
                {
                    MessageBox.Show("Player 2 wins");
                    P2Score++;
                    label2.Text = "Player 2: " + P2Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
            }
            turnnumber++;
            if (turnnumber == 9)
                MessageBox.Show("Draw");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (turnnumber % 2 == 1)
                button5.Text = "x";
            else
                button5.Text = "o";
            if ((button1.Text == button2.Text) && (button2.Text == button3.Text))
            {
                if (button1.Text == "x")
                {
                    MessageBox.Show("Player 1 wins");
                    P1Score++;
                    label1.Text = "Player 1: " + P1Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
                else if (button1.Text == "o")
                {
                    MessageBox.Show("Player 2 wins");
                    P2Score++;
                    label2.Text = "Player 2: " + P2Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
                turnnumber++;
            }
            else if ((button4.Text == button5.Text) && (button5.Text == button6.Text))
            {
                if (button4.Text == "x")
                {
                    MessageBox.Show("Player 1 wins");
                    P1Score++;
                    label1.Text = "Player 1: " + P1Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
                else if (button4.Text == "o")
                {
                    MessageBox.Show("Player 2 wins");
                    P2Score++;
                    label2.Text = "Player 2: " + P2Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
            }
            else if ((button7.Text == button8.Text) && (button8.Text == button9.Text))
            {
                if (button7.Text == "x")
                {
                    MessageBox.Show("Player 1 wins");
                    P1Score++;
                    label1.Text = "Player 1: " + P1Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
                else if (button7.Text == "o")
                {
                    MessageBox.Show("Player 2 wins");
                    P2Score++;
                    label2.Text = "Player 2: " + P2Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
            }
            else if ((button1.Text == button4.Text) && (button4.Text == button7.Text))
            {
                if (button7.Text == "x")
                {
                    MessageBox.Show("Player 1 wins");
                    P1Score++;
                    label1.Text = "Player 1: " + P1Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
                else if (button7.Text == "o")
                {
                    MessageBox.Show("Player 2 wins");
                    P2Score++;
                    label2.Text = "Player 2: " + P2Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
            }
            else if ((button2.Text == button5.Text) && (button5.Text == button8.Text))
            {
                if (button2.Text == "x")
                {
                    MessageBox.Show("Player 1 wins");
                    P1Score++;
                    label1.Text = "Player 1: " + P1Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
                else if (button2.Text == "o")
                {
                    MessageBox.Show("Player 2 wins");
                    P2Score++;
                    label2.Text = "Player 2: " + P2Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
            }
            else if ((button3.Text == button6.Text) && (button6.Text == button9.Text))
            {
                if (button3.Text == "x")
                {
                    MessageBox.Show("Player 1 wins");
                    P1Score++;
                    label1.Text = "Player 1: " + P1Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
                else if (button3.Text == "o")
                {
                    MessageBox.Show("Player 2 wins");
                    P2Score++;
                    label2.Text = "Player 2: " + P2Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
            }
            else if ((button1.Text == button5.Text) && (button5.Text == button9.Text))
            {
                if (button1.Text == "x")
                {
                    MessageBox.Show("Player 1 wins");
                    P1Score++;
                    label1.Text = "Player 1: " + P1Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
                else if (button1.Text == "o")
                {
                    MessageBox.Show("Player 2 wins");
                    P2Score++;
                    label2.Text = "Player 2: " + P2Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
            }
            else if ((button7.Text == button5.Text) && (button5.Text == button3.Text))
            {
                if (button7.Text == "x")
                {
                    MessageBox.Show("Player 1 wins");
                    P1Score++;
                    label1.Text = "Player 1: " + P1Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
                else if (button7.Text == "o")
                {
                    MessageBox.Show("Player 2 wins");
                    P2Score++;
                    label2.Text = "Player 2: " + P2Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
            }
            turnnumber++;
            if (turnnumber == 9)
                MessageBox.Show("Draw");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (turnnumber % 2 == 1)
                button6.Text = "x";
            else
                button6.Text = "o";
            if ((button1.Text == button2.Text) && (button2.Text == button3.Text))
            {
                if (button1.Text == "x")
                {
                    MessageBox.Show("Player 1 wins");
                    P1Score++;
                    label1.Text = "Player 1: " + P1Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
                else if (button1.Text == "o")
                {
                    MessageBox.Show("Player 2 wins");
                    P2Score++;
                    label2.Text = "Player 2: " + P2Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
                turnnumber++;
            }
            else if ((button4.Text == button5.Text) && (button5.Text == button6.Text))
            {
                if (button4.Text == "x")
                {
                    MessageBox.Show("Player 1 wins");
                    P1Score++;
                    label1.Text = "Player 1: " + P1Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
                else if (button4.Text == "o")
                {
                    MessageBox.Show("Player 2 wins");
                    P2Score++;
                    label2.Text = "Player 2: " + P2Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
            }
            else if ((button7.Text == button8.Text) && (button8.Text == button9.Text))
            {
                if (button7.Text == "x")
                {
                    MessageBox.Show("Player 1 wins");
                    P1Score++;
                    label1.Text = "Player 1: " + P1Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
                else if (button7.Text == "o")
                {
                    MessageBox.Show("Player 2 wins");
                    P2Score++;
                    label2.Text = "Player 2: " + P2Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
            }
            else if ((button1.Text == button4.Text) && (button4.Text == button7.Text))
            {
                if (button7.Text == "x")
                {
                    MessageBox.Show("Player 1 wins");
                    P1Score++;
                    label1.Text = "Player 1: " + P1Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
                else if (button7.Text == "o")
                {
                    MessageBox.Show("Player 2 wins");
                    P2Score++;
                    label2.Text = "Player 2: " + P2Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
            }
            else if ((button2.Text == button5.Text) && (button5.Text == button8.Text))
            {
                if (button2.Text == "x")
                {
                    MessageBox.Show("Player 1 wins");
                    P1Score++;
                    label1.Text = "Player 1: " + P1Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
                else if (button2.Text == "o")
                {
                    MessageBox.Show("Player 2 wins");
                    P2Score++;
                    label2.Text = "Player 2: " + P2Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
            }
            else if ((button3.Text == button6.Text) && (button6.Text == button9.Text))
            {
                if (button3.Text == "x")
                {
                    MessageBox.Show("Player 1 wins");
                    P1Score++;
                    label1.Text = "Player 1: " + P1Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
                else if (button3.Text == "o")
                {
                    MessageBox.Show("Player 2 wins");
                    P2Score++;
                    label2.Text = "Player 2: " + P2Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
            }
            else if ((button1.Text == button5.Text) && (button5.Text == button9.Text))
            {
                if (button1.Text == "x")
                {
                    MessageBox.Show("Player 1 wins");
                    P1Score++;
                    label1.Text = "Player 1: " + P1Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
                else if (button1.Text == "o")
                {
                    MessageBox.Show("Player 2 wins");
                    P2Score++;
                    label2.Text = "Player 2: " + P2Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
            }
            else if ((button7.Text == button5.Text) && (button5.Text == button3.Text))
            {
                if (button7.Text == "x")
                {
                    MessageBox.Show("Player 1 wins");
                    P1Score++;
                    label1.Text = "Player 1: " + P1Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
                else if (button7.Text == "o")
                {
                    MessageBox.Show("Player 2 wins");
                    P2Score++;
                    label2.Text = "Player 2: " + P2Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
            }
            turnnumber++;
            if (turnnumber == 9)
                MessageBox.Show("Draw");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (turnnumber % 2 == 1)
                button7.Text = "x";
            else
                button7.Text = "o";
            if ((button1.Text == button2.Text) && (button2.Text == button3.Text))
            {
                if (button1.Text == "x")
                {
                    MessageBox.Show("Player 1 wins");
                    P1Score++;
                    label1.Text = "Player 1: " + P1Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
                else if (button1.Text == "o")
                {
                    MessageBox.Show("Player 2 wins");
                    P2Score++;
                    label2.Text = "Player 2: " + P2Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
                turnnumber++;
            }
            else if ((button4.Text == button5.Text) && (button5.Text == button6.Text))
            {
                if (button4.Text == "x")
                {
                    MessageBox.Show("Player 1 wins");
                    P1Score++;
                    label1.Text = "Player 1: " + P1Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
                else if (button4.Text == "o")
                {
                    MessageBox.Show("Player 2 wins");
                    P2Score++;
                    label2.Text = "Player 2: " + P2Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
            }
            else if ((button7.Text == button8.Text) && (button8.Text == button9.Text))
            {
                if (button7.Text == "x")
                {
                    MessageBox.Show("Player 1 wins");
                    P1Score++;
                    label1.Text = "Player 1: " + P1Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
                else if (button7.Text == "o")
                {
                    MessageBox.Show("Player 2 wins");
                    P2Score++;
                    label2.Text = "Player 2: " + P2Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
            }
            else if ((button1.Text == button4.Text) && (button4.Text == button7.Text))
            {
                if (button7.Text == "x")
                {
                    MessageBox.Show("Player 1 wins");
                    P1Score++;
                    label1.Text = "Player 1: " + P1Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
                else if (button7.Text == "o")
                {
                    MessageBox.Show("Player 2 wins");
                    P2Score++;
                    label2.Text = "Player 2: " + P2Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
            }
            else if ((button2.Text == button5.Text) && (button5.Text == button8.Text))
            {
                if (button2.Text == "x")
                {
                    MessageBox.Show("Player 1 wins");
                    P1Score++;
                    label1.Text = "Player 1: " + P1Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
                else if (button2.Text == "o")
                {
                    MessageBox.Show("Player 2 wins");
                    P2Score++;
                    label2.Text = "Player 2: " + P2Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
            }
            else if ((button3.Text == button6.Text) && (button6.Text == button9.Text))
            {
                if (button3.Text == "x")
                {
                    MessageBox.Show("Player 1 wins");
                    P1Score++;
                    label1.Text = "Player 1: " + P1Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
                else if (button3.Text == "o")
                {
                    MessageBox.Show("Player 2 wins");
                    P2Score++;
                    label2.Text = "Player 2: " + P2Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
            }
            else if ((button1.Text == button5.Text) && (button5.Text == button9.Text))
            {
                if (button1.Text == "x")
                {
                    MessageBox.Show("Player 1 wins");
                    P1Score++;
                    label1.Text = "Player 1: " + P1Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
                else if (button1.Text == "o")
                {
                    MessageBox.Show("Player 2 wins");
                    P2Score++;
                    label2.Text = "Player 2: " + P2Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
            }
            else if ((button7.Text == button5.Text) && (button5.Text == button3.Text))
            {
                if (button7.Text == "x")
                {
                    MessageBox.Show("Player 1 wins");
                    P1Score++;
                    label1.Text = "Player 1: " + P1Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
                else if (button7.Text == "o")
                {
                    MessageBox.Show("Player 2 wins");
                    P2Score++;
                    label2.Text = "Player 2: " + P2Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
            }
            turnnumber++;
            if (turnnumber == 9)
                MessageBox.Show("Draw");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (turnnumber % 2 == 1)
                button8.Text = "x";
            else
                button8.Text = "o";
            if ((button1.Text == button2.Text) && (button2.Text == button3.Text))
            {
                if (button1.Text == "x")
                {
                    MessageBox.Show("Player 1 wins");
                    P1Score++;
                    label1.Text = "Player 1: " + P1Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
                else if (button1.Text == "o")
                {
                    MessageBox.Show("Player 2 wins");
                    P2Score++;
                    label2.Text = "Player 2: " + P2Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
                turnnumber++;
            }
            else if ((button4.Text == button5.Text) && (button5.Text == button6.Text))
            {
                if (button4.Text == "x")
                {
                    MessageBox.Show("Player 1 wins");
                    P1Score++;
                    label1.Text = "Player 1: " + P1Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
                else if (button4.Text == "o")
                {
                    MessageBox.Show("Player 2 wins");
                    P2Score++;
                    label2.Text = "Player 2: " + P2Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
            }
            else if ((button7.Text == button8.Text) && (button8.Text == button9.Text))
            {
                if (button7.Text == "x")
                {
                    MessageBox.Show("Player 1 wins");
                    P1Score++;
                    label1.Text = "Player 1: " + P1Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
                else if (button7.Text == "o")
                {
                    MessageBox.Show("Player 2 wins");
                    P2Score++;
                    label2.Text = "Player 2: " + P2Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
            }
            else if ((button1.Text == button4.Text) && (button4.Text == button7.Text))
            {
                if (button7.Text == "x")
                {
                    MessageBox.Show("Player 1 wins");
                    P1Score++;
                    label1.Text = "Player 1: " + P1Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
                else if (button7.Text == "o")
                {
                    MessageBox.Show("Player 2 wins");
                    P2Score++;
                    label2.Text = "Player 2: " + P2Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
            }
            else if ((button2.Text == button5.Text) && (button5.Text == button8.Text))
            {
                if (button2.Text == "x")
                {
                    MessageBox.Show("Player 1 wins");
                    P1Score++;
                    label1.Text = "Player 1: " + P1Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
                else if (button2.Text == "o")
                {
                    MessageBox.Show("Player 2 wins");
                    P2Score++;
                    label2.Text = "Player 2: " + P2Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
            }
            else if ((button3.Text == button6.Text) && (button6.Text == button9.Text))
            {
                if (button3.Text == "x")
                {
                    MessageBox.Show("Player 1 wins");
                    P1Score++;
                    label1.Text = "Player 1: " + P1Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
                else if (button3.Text == "o")
                {
                    MessageBox.Show("Player 2 wins");
                    P2Score++;
                    label2.Text = "Player 2: " + P2Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
            }
            else if ((button1.Text == button5.Text) && (button5.Text == button9.Text))
            {
                if (button1.Text == "x")
                {
                    MessageBox.Show("Player 1 wins");
                    P1Score++;
                    label1.Text = "Player 1: " + P1Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
                else if (button1.Text == "o")
                {
                    MessageBox.Show("Player 2 wins");
                    P2Score++;
                    label2.Text = "Player 2: " + P2Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
            }
            else if ((button7.Text == button5.Text) && (button5.Text == button3.Text))
            {
                if (button7.Text == "x")
                {
                    MessageBox.Show("Player 1 wins");
                    P1Score++;
                    label1.Text = "Player 1: " + P1Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
                else if (button7.Text == "o")
                {
                    MessageBox.Show("Player 2 wins");
                    P2Score++;
                    label2.Text = "Player 2: " + P2Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
            }
            turnnumber++;
            if (turnnumber == 9)
                MessageBox.Show("Draw");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (turnnumber % 2 == 1)
                button9.Text = "x";
            else
                button9.Text = "o";
            if ((button1.Text == button2.Text) && (button2.Text == button3.Text))
            {
                if (button1.Text == "x")
                {
                    MessageBox.Show("Player 1 wins");
                    P1Score++;
                    label1.Text = "Player 1: " + P1Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
                else if (button1.Text == "o")
                {
                    MessageBox.Show("Player 2 wins");
                    P2Score++;
                    label2.Text = "Player 2: " + P2Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
                turnnumber++;
            }
            else if ((button4.Text == button5.Text) && (button5.Text == button6.Text))
            {
                if (button4.Text == "x")
                {
                    MessageBox.Show("Player 1 wins");
                    P1Score++;
                    label1.Text = "Player 1: " + P1Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
                else if (button4.Text == "o")
                {
                    MessageBox.Show("Player 2 wins");
                    P2Score++;
                    label2.Text = "Player 2: " + P2Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
            }
            else if ((button7.Text == button8.Text) && (button8.Text == button9.Text))
            {
                if (button7.Text == "x")
                {
                    MessageBox.Show("Player 1 wins");
                    P1Score++;
                    label1.Text = "Player 1: " + P1Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
                else if (button7.Text == "o")
                {
                    MessageBox.Show("Player 2 wins");
                    P2Score++;
                    label2.Text = "Player 2: " + P2Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
            }
            else if ((button1.Text == button4.Text) && (button4.Text == button7.Text))
            {
                if (button7.Text == "x")
                {
                    MessageBox.Show("Player 1 wins");
                    P1Score++;
                    label1.Text = "Player 1: " + P1Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
                else if (button7.Text == "o")
                {
                    MessageBox.Show("Player 2 wins");
                    P2Score++;
                    label2.Text = "Player 2: " + P2Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
            }
            else if ((button2.Text == button5.Text) && (button5.Text == button8.Text))
            {
                if (button2.Text == "x")
                {
                    MessageBox.Show("Player 1 wins");
                    P1Score++;
                    label1.Text = "Player 1: " + P1Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
                else if (button2.Text == "o")
                {
                    MessageBox.Show("Player 2 wins");
                    P2Score++;
                    label2.Text = "Player 2: " + P2Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
            }
            else if ((button3.Text == button6.Text) && (button6.Text == button9.Text))
            {
                if (button3.Text == "x")
                {
                    MessageBox.Show("Player 1 wins");
                    P1Score++;
                    label1.Text = "Player 1: " + P1Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
                else if (button3.Text == "o")
                {
                    MessageBox.Show("Player 2 wins");
                    P2Score++;
                    label2.Text = "Player 2: " + P2Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
            }
            else if ((button1.Text == button5.Text) && (button5.Text == button9.Text))
            {
                if (button1.Text == "x")
                {
                    MessageBox.Show("Player 1 wins");
                    P1Score++;
                    label1.Text = "Player 1: " + P1Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
                else if (button1.Text == "o")
                {
                    MessageBox.Show("Player 2 wins");
                    P2Score++;
                    label2.Text = "Player 2: " + P2Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
            }
            else if ((button7.Text == button5.Text) && (button5.Text == button3.Text))
            {
                if (button7.Text == "x")
                {
                    MessageBox.Show("Player 1 wins");
                    P1Score++;
                    label1.Text = "Player 1: " + P1Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
                else if (button7.Text == "o")
                {
                    MessageBox.Show("Player 2 wins");
                    P2Score++;
                    label2.Text = "Player 2: " + P2Score.ToString();
                    button1.Text = String.Empty;
                    button2.Text = String.Empty;
                    button3.Text = String.Empty;
                    button4.Text = String.Empty;
                    button5.Text = String.Empty;
                    button6.Text = String.Empty;
                    button7.Text = String.Empty;
                    button8.Text = String.Empty;
                    button9.Text = String.Empty;
                }
            }
            turnnumber++;
            if (turnnumber == 9)
                MessageBox.Show("Draw");
        }
    }
}
