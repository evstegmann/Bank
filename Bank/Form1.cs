using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using Bank.Interfaces;
using Bank.Exceptions;
using Bank.Accounts;

namespace Bank
{
    public partial class Form1 : Form
    {
        private Dictionary<string, Account> dictionary;
        private List<Account> accounts;
        private int accountNumbers;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            dictionary = new Dictionary<string, Account>();
            accounts = new List<Account>();

            Account acc1 = new CurrentAccount();
            acc1.Title = new Client("John");
            acc1.Number = 1;
            acc1.Deposit(100.0);
            this.RegisterAccount(acc1);

            Account acc2 = new CurrentAccount();
            acc2.Title = new Client("Mary");
            acc2.Number = 2;
            this.RegisterAccount(acc2);

            Account acc3 = new SavingsAccount();
            acc3.Title = new Client("Terry");
            acc3.Number = 3;
            this.RegisterAccount(acc3);





        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            try
            {
                Account ac = (Account)accountCombo.SelectedItem;
                string value = valueText.Text;
                double valueOperation = Convert.ToDouble(value);
                ac.Deposit(valueOperation);
                balanceText.Text = Convert.ToString(ac.Balance.ToString("F2"));
                MessageBox.Show("Sucess!");
            }

            catch (ArgumentException)
            {
                MessageBox.Show("Deposit Error: Negative Value!");
            }


        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            try
            {
                int index = Convert.ToInt32(accountCombo.SelectedIndex);
                string value = valueText.Text;
                Account acc = accounts[index];
                double valueOperation = Convert.ToDouble(value);
                acc.Withdraw(valueOperation);
                balanceText.Text = Convert.ToString(acc.Balance);
                MessageBox.Show("Withdraw Sucess!");

            }

            catch (InsufficientBalance)
            {
                MessageBox.Show("Withdraw Error: Insufficient Balance!");
            }


        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(accountCombo.SelectedIndex);

            titleText.Text = Convert.ToString(accounts[index].Title.Name);
            numberText.Text = Convert.ToString(accounts[index].Number);
            balanceText.Text = Convert.ToString(accounts[index].Balance.ToString("F2"));
            valueText.Text = Convert.ToString(accounts[index].Balance);

        }

        private void accountCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Account ac = (Account)accountCombo.SelectedItem;

            titleText.Text = ac.Title.Name;
            balanceText.Text = Convert.ToString(ac.Balance.ToString("F2"));
            numberText.Text = Convert.ToString(ac.Number);
            valueText.Text = Convert.ToString("0");

        }

        private void transferCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void transferButton_Click(object sender, EventArgs e)
        {
            int index = accountCombo.SelectedIndex;
            Account acc1 = accounts[index];
            index = transferCombo.SelectedIndex;
            Account acc2 = accounts[index];
            double value = Convert.ToDouble(valueText.Text);

            acc1.TransferAccount(acc1, acc2, value);

            balanceText.Text = Convert.ToString(acc1.Balance.ToString("F2"));
            valueText.Text = Convert.ToString("0");
        }

        public void RegisterAccount(Account acc)
        {
            try
            {
                accounts.Add(acc);
                accountCombo.Items.Add(acc);
                dictionary.Add(acc.Title.Name, acc);
                transferCombo.DisplayMember = "Title";
                transferCombo.Items.Add(acc);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("This name already exist!");
            }


        }

        private void newAccountButton_Click(object sender, EventArgs e)
        {
            FormRegisterAccount formRegisterAccount = new FormRegisterAccount(this);
            formRegisterAccount.ShowDialog();
        }

        private void taxableButton_Click(object sender, EventArgs e)
        {

            TaxTotalizer taxTotal = new TaxTotalizer();

            for (int i = 0; i < accounts.Count; i++)
            {
                if (accounts[i] is CurrentAccount)
                {
                    CurrentAccount ca = accounts[i] as CurrentAccount;
                    ca.TaxableCalculate();
                    MessageBox.Show("Current Account: " + ca.Title.Name + ", " + ca.TaxableCalculate().ToString("F2"));
                }
            }
        }

        private void searchTitleButton_Click(object sender, EventArgs e)
        {
            try
            {
                string title = searchTitleText.Text;
                Account acc = dictionary[title];
                accountCombo.SelectedItem = acc;



                titleText.Text = acc.Title.Name;
                numberText.Text = Convert.ToString(acc.Number);
                balanceText.Text = Convert.ToString(acc.Balance);

            }

            catch (KeyNotFoundException)
            {
                MessageBox.Show("Title not found!");
                searchTitleText.Clear();
            }




        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormReport form = new FormReport(accounts);
            form.ShowDialog();

        }
    }
}
