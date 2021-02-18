using Banking.Exceptions;

using System;

namespace Banking {
    class Program {
        static void Main(string[] args) {

            //var sav1 = new SavingsComposition();
            var sav1 = new SavingsInheritance();
            sav1.InterestRate = 0.13m;
            sav1.Deposit(50);
            sav1.Withdraw(20);
            try {
                //sav1.Withdraw(50);
                //sav1.Deposit(-10);
                sav1.Withdraw(-10);
            } catch (AmountMustBePositiveException ambpex) {
                Console.WriteLine(ambpex.Message);
            } catch (InsufficientFundsException ifex) {
                Console.WriteLine(ifex.Message);
                return;
            } finally {

            }
            sav1.Deposit(70);
            Console.WriteLine($"Savings balance is {sav1.Balance}");
            sav1.PayInterest(3);
            Console.WriteLine($"Savings balance is {sav1.Balance}");

            /*
            var acct1 = new Account("Acct101", "Greg's Account");
            Console.WriteLine($"Account {acct1.AccountNumber} balance is {acct1.Balance}");
            acct1.Deposit(200);
            Console.WriteLine($"Account {acct1.AccountNumber} balance is {acct1.Balance}");
            acct1.Withdraw(30);
            Console.WriteLine($"Account {acct1.AccountNumber} balance is {acct1.Balance}");
            acct1.Withdraw(230);
            Console.WriteLine($"Account {acct1.AccountNumber} balance is {acct1.Balance}");
            acct1.Deposit(-200);
            Console.WriteLine($"Account {acct1.AccountNumber} balance is {acct1.Balance}");
            acct1.Withdraw(-200);
            Console.WriteLine($"Account {acct1.AccountNumber} balance is {acct1.Balance}");
            */
        }
    }
}
