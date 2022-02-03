using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banking_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Loan> loans = new List<Loan>();
        List<Current> currents = new List<Current>();
        List<Savings> savings = new List<Savings>();
        int nuser = 1;
        private void createAccountButton_Click(object sender, EventArgs e)
        {
            if(typeSelectTextBox.Text=="Savings")
            {
                if (Convert.ToDouble(initialAmountTextBox.Text) < 0)
                    throw new Exception("Initial deposit amount must greater or equal 0");
                else
                {
                    Savings s= new Savings();
                    s.balance += Convert.ToDouble(initialAmountTextBox.Text);
                    s.ACNumber = s.GetACNum(nuser);
                    nuser++;
                    savings.Add(s);
                    MessageBox.Show("Account number:" + s.ACNumber);
                }
            }
            else if (typeSelectTextBox.Text == "Current")
            {
                if (Convert.ToDouble(initialAmountTextBox.Text) < 50000)
                    throw new Exception("Initial deposit amount must greater or equal 50000");
                else
                {
                    Current c = new Current();
                    c.balance += Convert.ToDouble(initialAmountTextBox.Text);
                    c.ACNumber = c.GetACNum(nuser);
                    nuser++;
                    currents.Add(c);
                    MessageBox.Show("Account number:" + c.ACNumber);
                }
            }
            else if (typeSelectTextBox.Text == "Loan")
            {
                if (Convert.ToDouble(initialAmountTextBox.Text) < 0)
                    throw new Exception("Initial loan amount must greater or equal 0");
                else
                {
                    Loan l = new Loan();
                    l.balance += Convert.ToDouble(initialAmountTextBox.Text);
                    l.ACNumber = l.GetACNum(nuser);
                    nuser++;
                    loans.Add(l);
                    MessageBox.Show("Account number:" + l.ACNumber);
                }
            }
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            foreach (Loan l in loans)
            {
                if (ACNumberTextBox.Text == l.ACNumber)
                    l.Deposit(Convert.ToDouble(depositTextBox.Text));
            }
            foreach(Savings s in savings)
            {
                if(ACNumberTextBox.Text == s.ACNumber)
                    s.Deposit(Convert.ToDouble(depositTextBox.Text));
            }
            foreach(Current c in currents)
            {
                if (ACNumberTextBox.Text == c.ACNumber)
                    c.Deposit(Convert.ToDouble(depositTextBox.Text));
            }
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            foreach (Loan l in loans)
            {
                if (ACNumberTextBox1.Text == l.ACNumber)
                    l.Withdraw(Convert.ToDouble(withdrawTextBox.Text));
            }
            foreach (Savings s in savings)
            {
                if (ACNumberTextBox1.Text == s.ACNumber)
                    s.Withdraw(Convert.ToDouble(withdrawTextBox.Text));
            }
            foreach (Current c in currents)
            {
                if (ACNumberTextBox1.Text == c.ACNumber)
                    c.Withdraw(Convert.ToDouble(withdrawTextBox.Text));
            }
        }

        private void checkDetailsButton_Click(object sender, EventArgs e)
        {
            foreach (Loan l in loans)
            {
                if (ACNumberTextBox2.Text == l.ACNumber)
                {
                    balanceLabel.Text = balanceLabel.Text + Convert.ToString(l.balance);
                    numberOfTransactionsLabel.Text = numberOfTransactionsLabel.Text + Convert.ToString(l.nTransactions);
                }
            }
            foreach (Savings s in savings)
            {
                if (ACNumberTextBox2.Text == s.ACNumber)
                {
                    balanceLabel.Text = balanceLabel.Text + Convert.ToString(s.balance);
                    numberOfTransactionsLabel.Text = numberOfTransactionsLabel.Text + Convert.ToString(s.nTransactions);
                }
            }
            foreach (Current c in currents)
            {
                if (ACNumberTextBox2.Text == c.ACNumber)
                {
                    balanceLabel.Text = balanceLabel.Text + Convert.ToString(c.balance);
                    numberOfTransactionsLabel.Text = numberOfTransactionsLabel.Text + Convert.ToString(c.nTransactions);
                }
            }
        }
    }
}
