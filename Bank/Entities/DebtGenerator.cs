using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Entities
{
    public class DebtGenerator
    {
        public SortedSet<string> ListGenerator()
        {
            SortedSet<string> names = new SortedSet<string>(); 
            for ( int i = 0; i < 30000; i++)
            {
                names.Add("Debt: " + i);
            }
            return names;
        }
    }
}
