using System;
using System.Collections.Generic;
using System.Text;

namespace BankingStarter {
    class BankAccount {
        #region Properties
        private string _accountNumber;
        public string AccountNumber {
            get { return _accountNumber; }
            set { _accountNumber = value; }
        }
        private decimal _balance;
        public decimal Balance { get; set; }

        public const decimal _WithdrawCost = 0.25M;
        #endregion

        #region Constructors
        public BankAccount(string accountNumber) {
            AccountNumber = accountNumber;
        }
        #endregion
        
        #region Methods
        public void Deposit(decimal amount) {
            Balance += amount;
        }
        public void Withdraw(decimal amount) {
            Balance -= amount;
            Balance = Decimal.Zero;
        }
        #endregion

    }
}
