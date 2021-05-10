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
        /// <summary>
        /// Bank account info card to store details from form.
        /// </summary>
        public BankAccountCard BankAccount { get; set; }
        public NewBankAccountCard()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Validate and save details inputted in form.
        /// </summary>
        private void saveButton_Click(object sender, EventArgs e)
        {
            // Reset textbox colours.
            overdraftTextBox.BackColor = Color.White;
            nameTextBox.BackColor = Color.White;
            sortCodeTextBox.BackColor = Color.White;
            accountNumberTextBox.BackColor = Color.White;
            nameOnAccountTextBox.BackColor = Color.White;

            bool validationFailed = false;

            string name = nameTextBox.Text;
            string sortCode = sortCodeTextBox.Text.Replace("-","");
            string accountNumber = accountNumberTextBox.Text;
            string nameOnAccount = nameOnAccountTextBox.Text;

            // Validate decimal.
            if(!decimal.TryParse(overdraftTextBox.Text, out decimal overdraft) || overdraft % 50 != 0 || overdraft < 0)
            {
                overdraftTextBox.BackColor = Color.Red;
                validationFailed = true;
            }

            // Validate strings.
            if (!CheckInput(name))
            {
                nameTextBox.BackColor = Color.Red;
                validationFailed = true;
            }
            if (!CheckInput(sortCode) || sortCode.Length != 6 || !int.TryParse(sortCode,out _))
            {
                sortCodeTextBox.BackColor = Color.Red;
                validationFailed = true;
            }
            if (!CheckInput(accountNumber) || accountNumber.Length != 8 || !int.TryParse(accountNumber, out _))
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
                // Save validated details to properties.
                BankAccount.Name = name;
                BankAccount.SortCode = sortCode;
                BankAccount.AccountNumber = accountNumber;
                BankAccount.NameOnAccount = nameOnAccount;
                BankAccount.Overdraft = overdraft;
                DialogResult = DialogResult.OK;
            }
        }

        /// <summary>
        /// Closes form without saving details.
        /// </summary>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// Populate the text boxes when form is loaded.
        /// </summary>
        private void NewBankAccountCard_Load(object sender, EventArgs e)
        {            
            // Populate the text boxes with details if the
            // passed bank account info card isn't null.
            if (BankAccount.Name != null)
            {
                nameTextBox.Text = BankAccount.Name.ToString();
                sortCodeTextBox.Text = BankAccount.SortCode.ToString();
                accountNumberTextBox.Text = BankAccount.AccountNumber.ToString();
                nameOnAccountTextBox.Text = BankAccount.NameOnAccount.ToString();
                overdraftTextBox.Text = BankAccount.Overdraft.ToString();
            }
        }

        /// <summary>
        /// Checks if input is empty or contains |.
        /// </summary>
        /// <param name="input">String to be checked.</param>
        /// <returns>If the string was empty or contained |.</returns>
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
