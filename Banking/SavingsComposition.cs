using System;
using System.Collections.Generic;
using System.Text;

namespace Banking {
    class SavingsComposition {

        public decimal InterestRate { get; set; } = 0.12m;

        public Account account { get; set; }

        private decimal Interest(int months) {
            return account.Balance * (InterestRate / 12) * months;
        }
        public void PayInterest(int months) {
            var interest = Interest(months);
            Deposit(interest);
        }

        public decimal Balance {
            get { return account.Balance;  }
        }

        public void Deposit(decimal amount) {
            account.Deposit(amount);
        }
        public void Withdraw(decimal amount) {
            account.Withdraw(amount);
        }

        public SavingsComposition() {
            this.account = new Account("4", "Savings Account");
        }
    }
}
