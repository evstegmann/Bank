using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bank.Accounts;

namespace Bank
{
    public partial class FormReport : Form
    {
        private List<Account> accounts;

        public FormReport(List<Account> acc)
        {
            InitializeComponent();
            accounts = acc;
        }

        private void resultButton_Click(object sender, EventArgs e)
        {
            listResult.Items.Clear();
            var result = accounts.Where(a => a.Balance > 500.00).OrderByDescending(a => a.Title.Name).ThenBy(a => a.Number);
            

            foreach (var c in result)
            {
                listResult.Items.Add(c);
            }

            double totalBalance = accounts.Sum(a => a.Balance);
            double biggestBalance = accounts.Max(a => a.Balance);

            labelTotalBalance.Text = Convert.ToString(totalBalance.ToString("F2"));
            labelBiggestBalance.Text = Convert.ToString(biggestBalance.ToString("F2"));

        }

        private void olderButton_Click(object sender, EventArgs e)
        {
            listResult.Items.Clear();
            var result = accounts.Where(a => a.Number < 10 && a.Balance > 1000.00);

            foreach (var c in result)
            {
                listResult.Items.Add(c);
            }
        }
    }
}
