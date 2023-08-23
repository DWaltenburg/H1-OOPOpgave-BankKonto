using OOPOpgave;

namespace TestProject
{
    public class BankAccountTest
    {
        [Fact]
        public void WithdrawTest()
        {
            BankAccount account = new BankAccount(1000);
            // normal withdraw
            Assert.True(account.Withdraw(100));

            // withdraw negative
            Assert.False(account.Withdraw(-100));

            // withdraw zero
            Assert.False(account.Withdraw(0));

            // withdraw more than balance
            Assert.False(account.Withdraw(1000));
        }
        [Fact]
        public void DepositTest()
        {
            BankAccount BA = new();
            double x = 1234.5;
            BA.Deposit(x);
            double y = BA.GetBalance();
            Assert.Equal(x, y);

            // correct deposit
            Assert.True(BA.Deposit(1000));

            // wrong deposit
            Assert.False(BA.Deposit(-1000));
            Assert.False(BA.Deposit(0));
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