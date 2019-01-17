using BankingStarter.Models;
using System;
using Xunit;

namespace BankingStarter.Tests.Models {
    public class BankAccountTest {
        private BankAccount _account;
        private string _accountNumber;
        public BankAccountTest() {
            _accountNumber = "“063-1547563-60";
            _account = new BankAccount(_accountNumber);
        }
        [Fact]
        public void NewAccount_BalanceZero() {
            //Assert
            Assert.Equal(0, _account.Balance);
        }
        [Fact]
        public void NewAccount_SetAccountNumber() {
            //Assert
            Assert.Equal(_accountNumber, _account.AccountNumber);
        }
        [Fact]
        public void NewAccount_EmptyString_Fails() {
            Assert.Throws<ArgumentException>(
                () => new BankAccount(String.Empty));
        }
        [Fact]
        public void NewAccount_Null_Fails() {
            Assert.Throws<ArgumentNullException>(
                () => new BankAccount(null));
        }
        [Theory]
        [InlineData("133-4567890-0333")]
        [InlineData("063-1547563@60")]
        [InlineData("133-4567890-03")]
        public void NewAccount_WrongAccountNumber_Fails(string accountNumber) {
            Assert.Throws<ArgumentException>(() => new BankAccount(accountNumber));
        }
        [Fact]
        public void NewAccount_Amount_ChangesBalance() {
            _account.Deposit(200);
            Assert.Equal(200, _account.Balance);
            _account.Withdraw(100);
            Assert.Equal(100, _account.Balance);
        }

    }
}
