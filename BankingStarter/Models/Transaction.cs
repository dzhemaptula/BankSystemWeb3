using System;
using System.Collections.Generic;
using System.Text;

namespace BankingStarter {
    class Transaction {
        public decimal Amount { get; private set; }
        public DateTime DateOfTrans { get; private set; }
        public TransactionType TransactionType { get; private set; }
        public bool isDeposit {
            get { return TransactionType == TransactionType.Withdraw; }
        }
        public bool isWithdraw { get { return TransactionType == TransactionType.Deposit; } }

        public Transaction(decimal amount, TransactionType type) {
            Amount = amount;
            TransactionType = type;
            DateOfTrans = DateTime.Today;
        }

    }
}
