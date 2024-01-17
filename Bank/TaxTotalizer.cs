using Bank.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public class TaxTotalizer
    {
        public double Total { get; set; }  
        
        public void AddTax(ITaxable t)
        {
            Total += t.TaxableCalculate();
        }
    }
}
