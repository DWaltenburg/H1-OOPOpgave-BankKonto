using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOpgave
{
    public class BankAccount
    {
        private double balance;
        public BankAccount(double amount = 0)
        {
            balance = amount;
        }
        public bool Withdraw(double amount)
        {
            if (amount <= 0 || balance - amount < 0) { return false; }
            balance -= amount;
            return true;

        }
        public bool Deposit(double amount)
        {
            if (amount <= 0) { return false; }
            balance += amount;
            return true;
        }
        public double GetBalance() { return balance; }
    }
}
