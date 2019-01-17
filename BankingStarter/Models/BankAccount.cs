using System;
using System.Collections.Generic;
using System.Text;

namespace BankingStarter.Models {
    public class BankAccount : IBankAccount {
        #region Properties
        private IList<Transaction> _transactions;
        private string _accountNumber;
        public int NumberOfTransaction {
            get { return _transactions.Count; }
        }
        public IEnumerable<Transaction> GetTransactions(DateTime? from, DateTime? till) {
            IList<Transaction> transList = new List<Transaction>();
            foreach(Transaction ts in _transactions) {
                if(ts.DateOfTrans>= from&& ts.DateOfTrans <= till)
                transList.Add(ts);
            }
            return transList;
        }

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
            _transactions = new List<Transaction>();
            Balance = Decimal.Zero;
        }
        #endregion
        
        #region Methods
        public void Deposit(decimal amount) {
            _transactions.Add(new Transaction(amount, TransactionType.Deposit));
            Balance += amount;
        }
        public virtual void Withdraw(decimal amount) {
            _transactions.Add(new Transaction(amount, TransactionType.Withdraw));
            Balance -= amount;
        }

        public override string ToString() {
            return $"{AccountNumber} - {Balance}";
        }
        #endregion

    }
}
