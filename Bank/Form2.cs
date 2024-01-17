using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Text;
using System.Windows.Forms;
using Bank.Accounts;

namespace Bank
{
    public partial class Form2 : Form
    {
        private Account acc;
        public Form2()
        {
            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Account acc = new CurrentAccount();
            Client client = new Client("Victor");
            acc.Title = client;


            txtTitle.Text = acc.Title.Name;
            txtBalance.Text = Convert.ToString(acc.Balance);
            txtNumber.Text = Convert.ToString(acc.Number);



        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            double value = Convert.ToDouble(txtValue.Text);
            acc = new CurrentAccount();
            acc.Deposit(value);
            if (acc.Balance > 0.0)
            {
                txtBalance.Text = Convert.ToString(acc.Balance);
                MessageBox.Show("Sucess! Deposit was made it!");
            }
            else
            {
                MessageBox.Show("Failed! Insuficcient Balance!");
            }

        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            double value = Convert.ToDouble(txtValue.Text);
            acc = new CurrentAccount();


            acc.Withdraw(value);

            txtBalance.Text = Convert.ToString(acc.Balance);

        }


    }
}
