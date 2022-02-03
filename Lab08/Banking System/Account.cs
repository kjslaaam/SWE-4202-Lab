using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System
{
    public class Account
    {
        public virtual void Withdraw(double amount)
        { }
        public virtual void Deposit(double amount)
        { }
    }
}
