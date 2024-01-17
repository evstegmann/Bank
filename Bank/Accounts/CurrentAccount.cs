using Bank.Exceptions;
using Bank.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Accounts
{
    public class CurrentAccount : Account, ITaxable
    {
        public override void Deposit(double value)
        {
            if (value < 0.0)
            {
                throw new ArgumentException();
            }
            else
            {
                Balance += (value - 0.10);
            }
        }

        public double TaxableCalculate()
        {
            return Balance * 0.05;
        }

        public override void Withdraw(double value)
        {
            if (value + 0.05 > Balance)
            {
                throw new InsufficientBalance();
            }
            else
            {
                Balance -= value + 0.05;
            }
        }
    }
}
