using System;
using System.Collections.Generic;
using System.Text;

namespace Banking {

    class Account {

        public string AccountNumber { get; private set; }
        public string Description { get; set; }
        public decimal Balance { get; private set; } = 0;

        public void Deposit(decimal amount) {
            if(amount > 0) {
                Balance += amount;

            }
        }
        public void Withdraw(decimal amount) {
            if(amount < 0) {
                return;
            }
            if(Balance >= amount) {
                Balance -= amount;
            } else {
                Console.WriteLine($"Insufficient funds!");
            }
        }
        public Account() : this("DefAcct0", "Default Account Description") { }

        public Account(string acctNbr, string desc = "New Account") {
            AccountNumber = acctNbr;
            Description = desc;
        }
    }
}
