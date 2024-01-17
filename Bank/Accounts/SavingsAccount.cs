using Bank.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Accounts 
{
    public class SavingsAccount : Account
    {
        public override void Deposit(double value)
        {
            if (value < 0.0)
            {
                throw new ArgumentException();
            }
            else
            {
                Balance += value;
            }
        }

        public override void Withdraw(double value)
        {
            if (value + 0.10 > Balance)
            {
                throw new InsufficientBalance();
            }
            else
            {
                Balance -= value + 0.10;
            }
        }
    }
}
