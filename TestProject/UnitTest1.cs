using OOPOpgave;

namespace TestProject
{
    public class BankAccountTest
    {
        [Fact]
        public void WithdrawTest()
        {
            //withdrawing over current balance
            double x = 100;
            BankAccount BA = new(x);
            double z = 200;
            BA.Withdraw(z);
            double y = BA.GetBalance();
            Assert.Equal(x, y);

            // withdrawing under current balance
            double x2 = 100.1224;
            BankAccount BA2 = new(x2);
            double z2 = 50.4562;
            BA2.Withdraw(z2);
            double y2 = BA2.GetBalance();
            Assert.Equal(x2 - z2, y2);
        }
        [Fact]
        public void DepositTest()
        {
            BankAccount BA = new();
            double x = 1234.5;
            BA.Deposit(x);
            double y = BA.GetBalance();
            Assert.Equal(x, y);
        }
        [Fact]
        public void GetBalanceTest()
        {
            double x = 1234.5;
            BankAccount BA = new(x);
            double y = BA.GetBalance();
            Assert.Equal(x, y);
        }
    }
}