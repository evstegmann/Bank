using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Bank.Accounts;
using Bank.Entities;

namespace Bank
{
    public partial class FormRegisterAccount : Form
    {
        private ICollection<string> debtors;
        private Form1 formPrincipal;
        private Account[] typeAccounts;
        public FormRegisterAccount(Form1 formPrincipal)
        {
            this.formPrincipal = formPrincipal;
            InitializeComponent();

            DebtGenerator generator = new DebtGenerator();
            debtors = generator.ListGenerator();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            string title = titleText.Text;
            bool isDebtor = debtors.Contains(title);

            if (!isDebtor)
            {
                Account acc = null;
                if (typeCombo.SelectedIndex == 0)
                {
                    acc = new CurrentAccount();
                }
                else
                {
                    acc = new SavingsAccount();
                }

                acc.Title = new Client(titleText.Text);
                formPrincipal.RegisterAccount(acc);


                MessageBox.Show("Sucessifully Registered!");

                this.Close();
            }
            else
            {
                MessageBox.Show("Title is debtor!");

                this.Close();
            }

        }

        private void FormRegisterAccount_Load(object sender, EventArgs e)
        {
            typeCombo.Items.Add("Current Account");
            typeCombo.Items.Add("Savings Account");
            numberText.Text = Convert.ToString(Account.NextNumber());
        }
    }
}
