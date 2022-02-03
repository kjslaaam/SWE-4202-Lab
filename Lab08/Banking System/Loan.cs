using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System
{
    class Loan:Account
    {
        public double balance;
        public string ACNumber;
        public int nTransactions = 0;
        public string GetACNum(int num)
        {
            return num.ToString()+"400";
        }
        public override void Deposit(double amount)
        {
            if (amount < 0)
                throw new Exception("Amount cannot be negative");
            else if (amount > this.balance)
                throw new Exception("More amount eposited than required");
            else
            {
                this.balance -= amount;
                this.nTransactions++;
            }
        }
    }
}
