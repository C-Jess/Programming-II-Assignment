using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment.BankAccount
{
    public partial class NewBankAccountCard : Form
    {
        public BankAccountCard BankAccount { get; set; }
        public NewBankAccountCard()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            overdraftTextBox.BackColor = Color.White;
            nameTextBox.BackColor = Color.White;
            sortCodeTextBox.BackColor = Color.White;
            accountNumberTextBox.BackColor = Color.White;
            nameOnAccountTextBox.BackColor = Color.White;

            bool validationFailed = false;

            string name = nameTextBox.Text;
            string sortCode = sortCodeTextBox.Text;
            string accountNumber = accountNumberTextBox.Text;
            string nameOnAccount = nameOnAccountTextBox.Text;

            if(!decimal.TryParse(overdraftTextBox.Text, out decimal overdraft))
            {
                overdraftTextBox.BackColor = Color.Red;
                validationFailed = true;
            }
            if (!CheckInput(name))
            {
                nameTextBox.BackColor = Color.Red;
                validationFailed = true;
            }
            if (!CheckInput(sortCode))
            {
                sortCodeTextBox.BackColor = Color.Red;
                validationFailed = true;
            }
            if (!CheckInput(accountNumber))
            {
                accountNumberTextBox.BackColor = Color.Red;
                validationFailed = true;
            }
            if (!CheckInput(nameOnAccount))
            {
                nameOnAccountTextBox.BackColor = Color.Red;
                validationFailed = true;
            }

            if (!validationFailed)
            {
                BankAccount.Name = name;
                BankAccount.SortCode = sortCode;
                BankAccount.AccountNumber = accountNumber;
                BankAccount.NameOnAccount = nameOnAccount;
                BankAccount.Overdraft = overdraft;
                DialogResult = DialogResult.OK;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void NewBankAccountCard_Load(object sender, EventArgs e)
        {
            if (BankAccount.Name != null)
            {
                nameTextBox.Text = BankAccount.Name.ToString();
                sortCodeTextBox.Text = BankAccount.SortCode.ToString();
                accountNumberTextBox.Text = BankAccount.AccountNumber.ToString();
                nameOnAccountTextBox.Text = BankAccount.NameOnAccount.ToString();
                overdraftTextBox.Text = BankAccount.Overdraft.ToString();
            }
        }

        private bool CheckInput(string input)
        {
            if (input == "")
            {
                return false;
            }
            else if (input.Contains("|"))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
