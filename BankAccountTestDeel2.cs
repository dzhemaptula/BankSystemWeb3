using System;
using Banking.Models;
using Xunit;

namespace Banking.Tests.Models
{
    public class BankAccountTestDeel2
    {
        private BankAccount _bankAccount;

        public BankAccountTestDeel2()
        {
            string accountNumber = "123-4567890-02";
            _bankAccount = new BankAccount(accountNumber);
        }

        [Fact]
        public void NewAccount_Null_Fails()
        {
            Assert.Throws<ArgumentNullException>(() => new BankAccount(null));
        }

        [Fact]
        public void NewAccount_TooLong_Fails()
        {
            string number = "123-4567890-0333";
            Assert.Throws<ArgumentException>(() => new BankAccount(number));
        }

        [Fact]
        public void NewAccount_WrongFormat_Fails()
        {
            string number = "123-1547563@60";
            Assert.Throws<ArgumentException>(() => new BankAccount(number));
        }

        [Fact]
        public void NewAccount_NoDivisionBy97_Fails()
        {
            string number = "123-4567890-03";
            Assert.Throws<ArgumentException>(() => new BankAccount(number));
        }

        //stort 200
        [Fact]
        public void Deposit_Amount_ChangesBalance()
        {
            _bankAccount.Deposit(200);
            Assert.Equal(200, _bankAccount.Balance);
        }

        //stort 200, haal dan 110 af
        [Fact]
        public void Withdraw_Amount_ChangesBalance()
        {
            _bankAccount.Deposit(200);
            _bankAccount.Withdraw(110);
            Assert.Equal(90, _bankAccount.Balance);
        }

        ////haal 100 af 
        [Fact]
        public void Withdraw_NegativeBalance_Allowed()
        {
            _bankAccount.Withdraw(100);
            Assert.Equal(-100, _bankAccount.Balance);
        }
        
    }
}