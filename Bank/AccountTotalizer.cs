using System;
using System.Collections.Generic;
using System.Text;
using Bank.Accounts;

namespace Bank
{
    public class AccountTotalizer
    {
        public double TotalBalance { get; private set; }


        public void TotalFee(Account acc, Account acc2)
        {
            TotalBalance += (acc.Balance + acc2.Balance);    
        }   

    }
}