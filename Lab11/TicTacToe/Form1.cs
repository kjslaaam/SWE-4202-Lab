using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int Player1Score = 0;
        int Player2Score = 0;
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if((textBox11.Text ==textBox12.Text)&&(textBox12.Text==textBox13.Text))
            {
                if (textBox11.Text == "x")
                {
                    MessageBox.Show("Player 1 wins");
                    Player1Score++;
                    Player1ScoreLabel.Text ="Player 1: "+Player1Score.ToString();
                    textBox11.Clear();
                    textBox12.Clear();
                    textBox13.Clear();
                    textBox21.Clear();
                    textBox22.Clear();
                    textBox23.Clear();
                    textBox31.Clear();
                    textBox32.Clear();
                    textBox33.Clear();
                }
                else if (textBox11.Text == "o")
                {
                    MessageBox.Show("Player 2 wins");
                    Player2Score++;
                    Player2ScoreLabel.Text = "Player 2: " + Player2Score.ToString();
                    textBox11.Clear();
                    textBox12.Clear();
                    textBox13.Clear();
                    textBox21.Clear();
                    textBox22.Clear();
                    textBox23.Clear();
                    textBox31.Clear();
                    textBox32.Clear();
                    textBox33.Clear();
                }
            }
            else if ((textBox21.Text == textBox22.Text) && (textBox22.Text == textBox23.Text))
            {
                if (textBox21.Text == "x")
                {
                    MessageBox.Show("Player 1 wins");
                    Player1Score++;
                    Player1ScoreLabel.Text = "Player 1: " + Player1Score.ToString();
                    textBox11.Clear();
                    textBox12.Clear();
                    textBox13.Clear();
                    textBox21.Clear();
                    textBox22.Clear();
                    textBox23.Clear();
                    textBox31.Clear();
                    textBox32.Clear();
                    textBox33.Clear();
                }
                else if (textBox21.Text == "o")
                {
                    MessageBox.Show("Player 2 wins");
                    Player2Score++;
                    Player2ScoreLabel.Text = "Player 2: " + Player2Score.ToString();
                    textBox11.Clear();
                    textBox12.Clear();
                    textBox13.Clear();
                    textBox21.Clear();
                    textBox22.Clear();
                    textBox23.Clear();
                    textBox31.Clear();
                    textBox32.Clear();
                    textBox33.Clear();
                }
            }
            else if ((textBox31.Text == textBox32.Text) && (textBox32.Text == textBox33.Text))
            {
                if (textBox31.Text == "x")
                {
                    MessageBox.Show("Player 1 wins");
                    Player1Score++;
                    Player1ScoreLabel.Text = "Player 1: " + Player1Score.ToString();
                    textBox11.Clear();
                    textBox12.Clear();
                    textBox13.Clear();
                    textBox21.Clear();
                    textBox22.Clear();
                    textBox23.Clear();
                    textBox31.Clear();
                    textBox32.Clear();
                    textBox33.Clear();
                }
                else if (textBox31.Text == "o")
                {
                    MessageBox.Show("Player 2 wins");
                    Player2Score++;
                    Player2ScoreLabel.Text = "Player 2: " + Player2Score.ToString();
                    textBox11.Clear();
                    textBox12.Clear();
                    textBox13.Clear();
                    textBox21.Clear();
                    textBox22.Clear();
                    textBox23.Clear();
                    textBox31.Clear();
                    textBox32.Clear();
                    textBox33.Clear();
                }
            }
            else if ((textBox11.Text == textBox21.Text) && (textBox21.Text == textBox31.Text))
            {
                if (textBox11.Text == "x")
                {
                    MessageBox.Show("Player 1 wins");
                    Player1Score++;
                    Player1ScoreLabel.Text = "Player 1: " + Player1Score.ToString();
                    textBox11.Clear();
                    textBox12.Clear();
                    textBox13.Clear();
                    textBox21.Clear();
                    textBox22.Clear();
                    textBox23.Clear();
                    textBox31.Clear();
                    textBox32.Clear();
                    textBox33.Clear();
                }
                else if (textBox11.Text == "o")
                {
                    MessageBox.Show("Player 2 wins");
                    Player2Score++;
                    Player2ScoreLabel.Text = "Player 2: " + Player2Score.ToString();
                    textBox11.Clear();
                    textBox12.Clear();
                    textBox13.Clear();
                    textBox21.Clear();
                    textBox22.Clear();
                    textBox23.Clear();
                    textBox31.Clear();
                    textBox32.Clear();
                    textBox33.Clear();
                }
            }
            else if ((textBox12.Text == textBox22.Text) && (textBox22.Text == textBox32.Text))
            {
                if (textBox12.Text == "x")
                {
                    MessageBox.Show("Player 1 wins");
                    Player1Score++;
                    Player1ScoreLabel.Text = "Player 1: " + Player1Score.ToString();
                    textBox11.Clear();
                    textBox12.Clear();
                    textBox13.Clear();
                    textBox21.Clear();
                    textBox22.Clear();
                    textBox23.Clear();
                    textBox31.Clear();
                    textBox32.Clear();
                    textBox33.Clear();
                }
                else if (textBox12.Text == "o")
                {
                    MessageBox.Show("Player 2 wins");
                    Player2Score++;
                    Player2ScoreLabel.Text = "Player 2: " + Player2Score.ToString();
                    textBox11.Clear();
                    textBox12.Clear();
                    textBox13.Clear();
                    textBox21.Clear();
                    textBox22.Clear();
                    textBox23.Clear();
                    textBox31.Clear();
                    textBox32.Clear();
                    textBox33.Clear();
                }
            }
            else if ((textBox13.Text == textBox23.Text) && (textBox23.Text == textBox33.Text))
            {
                if (textBox13.Text == "x")
                {
                    MessageBox.Show("Player 1 wins");
                    Player1Score++;
                    Player1ScoreLabel.Text = "Player 1: " + Player1Score.ToString();
                    textBox11.Clear();
                    textBox12.Clear();
                    textBox13.Clear();
                    textBox21.Clear();
                    textBox22.Clear();
                    textBox23.Clear();
                    textBox31.Clear();
                    textBox32.Clear();
                    textBox33.Clear();
                }
                else if (textBox13.Text == "o")
                {
                    MessageBox.Show("Player 2 wins");
                    Player2Score++;
                    Player2ScoreLabel.Text = "Player 2: " + Player2Score.ToString();
                    textBox11.Clear();
                    textBox12.Clear();
                    textBox13.Clear();
                    textBox21.Clear();
                    textBox22.Clear();
                    textBox23.Clear();
                    textBox31.Clear();
                    textBox32.Clear();
                    textBox33.Clear();
                }
            }
            else if((textBox11.Text == textBox22.Text)&&(textBox22.Text==textBox33.Text))
            {
                if (textBox11.Text == "x")
                {
                    MessageBox.Show("Player 1 wins");
                    Player1Score++;
                    Player1ScoreLabel.Text = "Player 1: " + Player1Score.ToString();
                    textBox11.Clear();
                    textBox12.Clear();
                    textBox13.Clear();
                    textBox21.Clear();
                    textBox22.Clear();
                    textBox23.Clear();
                    textBox31.Clear();
                    textBox32.Clear();
                    textBox33.Clear();
                }
                else if (textBox11.Text == "o")
                {
                    MessageBox.Show("Player 2 wins");
                    Player2Score++;
                    Player2ScoreLabel.Text = "Player 2: " + Player2Score.ToString();
                    textBox11.Clear();
                    textBox12.Clear();
                    textBox13.Clear();
                    textBox21.Clear();
                    textBox22.Clear();
                    textBox23.Clear();
                    textBox31.Clear();
                    textBox32.Clear();
                    textBox33.Clear();
                }
            }
            else if ((textBox31.Text == textBox22.Text) && (textBox22.Text == textBox13.Text))
            {
                if (textBox31.Text == "x")
                {
                    MessageBox.Show("Player 1 wins");
                    Player1Score++;
                    Player1ScoreLabel.Text = "Player 1: " + Player1Score.ToString();
                    textBox11.Clear();
                    textBox12.Clear();
                    textBox13.Clear();
                    textBox21.Clear();
                    textBox22.Clear();
                    textBox23.Clear();
                    textBox31.Clear();
                    textBox32.Clear();
                    textBox33.Clear();
                }
                else if (textBox31.Text == "o")
                {
                    MessageBox.Show("Player 2 wins");
                    Player2Score++;
                    Player2ScoreLabel.Text = "Player 2: " + Player2Score.ToString();
                    textBox11.Clear();
                    textBox12.Clear();
                    textBox13.Clear();
                    textBox21.Clear();
                    textBox22.Clear();
                    textBox23.Clear();
                    textBox31.Clear();
                    textBox32.Clear();
                    textBox33.Clear();
                }
            }
        }
    }
}
