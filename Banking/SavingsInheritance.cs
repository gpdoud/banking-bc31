using System;
using System.Collections.Generic;
using System.Text;

namespace Banking {

    class SavingsInheritance : Account {

        public decimal InterestRate { get; set; } = 0.12m;

        public void PayInterest(int months) {
            var interest = Balance * (InterestRate / 12) * months;
            Deposit(interest);
        }

        public SavingsInheritance() 
            : base() { }

        public SavingsInheritance(string AcctNbr, string Desc) 
            : base(AcctNbr, Desc) {
        }

        public SavingsInheritance(string AcctNbr, decimal IntRate) : base(AcctNbr, "New Savings Account") {
            this.InterestRate = IntRate;
        }
    }
}
