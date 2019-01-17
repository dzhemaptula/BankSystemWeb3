using Banking.Models;
using System;
using Xunit;

namespace Banking.Tests.Models
{
    public class BankAccountTransactionTest
    {
        private static string _bankAccountNumber = "123-4567890-02";
        private BankAccount _bankAccount;
        private DateTime _yesterday = DateTime.Today.AddDays(-1);
        private DateTime _tomorrow = DateTime.Today.AddDays(1);

        public BankAccountTransactionTest()
        {
            _bankAccount = new BankAccount(_bankAccountNumber);
        }

        [Fact(Skip="Not yet implemented")]
        public void NewAccount_HasZeroTransactions()
        {
            Assert.Equal(0, _bankAccount.NumberOfTransactions);
        }

        [Fact(Skip = "Not yet implemented")]
        public void Deposit_Amount_AddsTransaction()
        {
            _bankAccount.Deposit(100);
        }

        [Fact(Skip = "Not yet implemented")]
        public void WithDraw_Amount_AddsTransaction()
        {
            _bankAccount.Withdraw(100);
        }


        [Fact(Skip = "Not yet implemented")]
        public void GetTransactions_NoParameters_ReturnsAllTransactions()
        {
            _bankAccount.Deposit(100);
            _bankAccount.Deposit(100);
        }

        [Fact(Skip = "Not yet implemented")]
        public void GetTransactions_NoTransactions_ReturnsEmptyList()
        {

        }

        [Fact(Skip = "Not yet implemented")]
        public void GetTransactions_WithinAPeriodThatHasTransactions_ReturnsTransactions()
        {
            _bankAccount.Deposit(100);
            _bankAccount.Deposit(100);
        }

        [Fact(Skip = "Not yet implemented")]
        public void GetTransactions_WithinAPeriodThatHasNoTransactions_ReturnsNoTransactions()
        {
            _bankAccount.Deposit(100);
            _bankAccount.Deposit(100);
        }

        [Fact(Skip = "Not yet implemented")]
        public void GetTransactions_BeforeADateWithTransactions_ReturnsTransactions()
        {
            _bankAccount.Deposit(100);
            _bankAccount.Deposit(100);
        }

        [Fact(Skip = "Not yet implemented")]
        public void GetTransactions_BeforeADateWithoutTransactions_ReturnsNoTransactions()
        {
            _bankAccount.Deposit(100);
            _bankAccount.Deposit(100);
        }

        [Fact(Skip = "Not yet implemented")]
        public void GetTransactions_AfterADateWithTransactions_ReturnsTransactions()
        {
            _bankAccount.Deposit(100);
            _bankAccount.Deposit(100);
        }

        [Fact(Skip = "Not yet implemented")]
        public void GetTransactions_AfterADateWithoutTransactions_ReturnsNoTransactions()
        {
            _bankAccount.Deposit(100);
            _bankAccount.Deposit(100);
       }


    }
}