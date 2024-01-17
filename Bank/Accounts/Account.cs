using System;
using System.CodeDom;
using System.Diagnostics.Contracts;

namespace Bank.Accounts
{
    public abstract class Account
    {
        public int Number { get; internal set; }
        public double Balance { get; protected set; }
        internal Client Title { get; set; }

        private static int AccountNumber;

        public Account()
        {
            Account.AccountNumber++;
            Number = Account.AccountNumber;
        }

        public Account(int number, double balance)
        {
            Number = number;
            Balance = balance;
        }

        public abstract void Deposit(double value);
        

        public abstract void Withdraw(double value);
        

        public virtual void TransferAccount(Account a1, Account a2, double balance)
        {
            a1.Withdraw(balance);
            a2.Deposit(balance);
      
        }

        public static int NextNumber()
        {
            return AccountNumber + 1;   
        }

        public override string ToString()
        {
            return "Title: " + Title.Name;
        }
    }
}