using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System
{
    class Savings:Account
    {
        public double balance;
        public string ACNumber;
        public int nTransactions = 0;
        public string GetACNum(int num)
        {
            return num.ToString() + "314";
        }
        public override void Deposit(double amount)
        {
            if (amount < 0)
                throw new Exception("Amount cannot be negative");
            else if (this.nTransactions > 5)
                throw new Exception("Maximum number of transactions reached.");
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
            else if (this.nTransactions > 5)
                throw new Exception("Maximum number of transactions reached.");
            else if (this.balance < (amount+15))
                throw new Exception("Insufficient balance.");
            else
            {
                this.balance -= (amount+15);
                this.nTransactions++;
            }
        }
    }
}
