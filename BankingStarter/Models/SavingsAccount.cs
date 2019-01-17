using System;
using System.Collections.Generic;
using System.Text;

namespace BankingStarter.Models {
    public class SavingsAccount : BankAccount {
        protected const decimal WithdrawCost = 0.25M;
        public decimal InterestRate { get; private set; }

        public SavingsAccount(string nummer, decimal interestrate)
            : base(nummer) {
            InterestRate = interestrate;
        }
        public void AddInterest() {
            Deposit(Balance * InterestRate);
        }

        public override void Withdraw(decimal amount) {
            base.Withdraw(amount);
            base.Withdraw(WithdrawCost);
        }

    }
}
