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
        public double Withdraw(double amount)
        {
            if (balance > amount) { balance -= amount; }
            return balance;
        }
        public double Deposit(double amount)
        {
            balance += amount;
            return balance;
        }
        public double GetBalance() { return balance; }
    }
}
