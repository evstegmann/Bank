using Bank.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    internal class LifeEnsurance : ITaxable
    {
        const double value = 42.00;
        public double TaxableCalculate()
        {
            return value;   
        }
    }
}
