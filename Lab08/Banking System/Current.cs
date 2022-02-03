using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System
{
    class Current:Account
    {
        public double balance;
        public string ACNumber;
        public int nTransactions = 0;
        public string GetACNum(int num)
        {
            return num.ToString() + "300";
        }
        public override void Deposit(double amount)
        {
            if (amount < 0)
                throw new Exception("Amount cannot be negative");
            else if (amount > 10000)
                throw new Exception("Maximum transaction amount exceeded");
            else
            {
                this.balance += amount;
                this.nTransactions++;
            }
        }
        public override void Withdraw(double amount)
        {
            if (amount < 0)
                throw new Exception("Amount cannot be negative");
            else if ((this.balance-amount)<500)
                throw new Exception("Insufficient funds available to withdraw");
            else if(amount >10000)
                throw new Exception("Maximum transaction amount exceeded");
            else
            {
                this.balance-= amount;
                this.nTransactions++;
            }
        }
    }
}
