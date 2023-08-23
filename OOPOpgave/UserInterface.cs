using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOpgave
{
    internal class UserInterface : BankAccount
    {
        public string name;
        public bool loggedIn;
        public UserInterface(string name)
        {
            this.name = name;
            ShowMenu();
        }
        public void ShowMenu()
        {
            Console.Clear();
            loggedIn = true;
            while (loggedIn)
            {
                DisplayBalance();
                Console.WriteLine($"Logged in as {name}");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("0. Logout");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        DisplayDeposit();
                        break;
                    case "2":
                        DisplayWithdraw();
                        break;
                    case "0":
                        loggedIn = false;
                        Console.WriteLine("Logging Out...");
                        Console.WriteLine("Press Enter to Continue...");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Unknown command");
                        break;
                }
            }
        }
        private void DisplayDeposit()
        {
            Console.WriteLine("----------------------");
            Console.Write("Deposit: ");
            double amount;
            double.TryParse(Console.ReadLine(), out amount);
            Deposit(amount);
        }
        private void DisplayWithdraw()
        {
            Console.WriteLine("----------------------");
            Console.Write("Withdraw: ");
            double amount;
            double.TryParse(Console.ReadLine(), out amount);
            if (amount > GetBalance())
            {
                Console.WriteLine($"Amount: {amount} exeeds current balance.");
            }
            else
            {
                Withdraw(amount);
            }
        }
        private void DisplayBalance()
        {
            Console.Clear();
            Console.WriteLine("----------------------");
            Console.WriteLine($"Current Balance: {GetBalance()}");
            Console.WriteLine("----------------------");
        }
    }
}
