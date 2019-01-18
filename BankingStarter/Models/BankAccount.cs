using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

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
            foreach (Transaction ts in _transactions) {
                if (ts.DateOfTrans >= from && ts.DateOfTrans <= till)
                    transList.Add(ts);
            }
            return transList;
        }

        public string AccountNumber {
            get { return _accountNumber; }
            set {
                if (value == null) {
                    throw new ArgumentNullException();
                }

                Regex regex = new Regex(@"(\d{3})-(\d{7})-(\d{2})");
                Match match = regex.Match(value);
                if (!match.Success) {
                    throw new ArgumentException("Verkeerde format");
                }
                if (int.Parse(match.Groups[1] +
                    match.Groups[2].ToString()) % 97 !=
                    int.Parse(match.Groups[3].ToString()))
                    throw new ArgumentException("97 test of the bank account number failed");
                _accountNumber = value;
            }
        }
        public decimal Balance {
            get;set;
        }

        public const decimal _WithdrawCost = 0.25M;
        #endregion

        #region Constructors
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="accountNumber">Number of the account</param>
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
