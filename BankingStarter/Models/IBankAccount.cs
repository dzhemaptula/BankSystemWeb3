using System;
using System.Collections.Generic;

namespace BankingStarter.Models {
    public interface IBankAccount {
        string AccountNumber { get; set; }
        decimal Balance { get; set; }
        int NumberOfTransaction { get; }

        void Deposit(decimal amount);
        IEnumerable<Transaction> GetTransactions(DateTime? from, DateTime? till);
        void Withdraw(decimal amount);
    }
}