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
    public partial class DisplayBankAccount : Form
    {
        /// <summary>
        /// Bank Account info card to store details from class.
        /// </summary>
        private BankAccountCard bankAccount;
        /// <summary>
        /// A form to display bank account info card details.
        /// </summary>
        /// <param name="bankAccountCard">Bank account info card to get details from.</param>
        public DisplayBankAccount(BankAccountCard bankAccountCard)
        {
            bankAccount = bankAccountCard;
            InitializeComponent();
        }

        /// <summary>
        /// Populates the labels with the bank account details.
        /// </summary>
        private void DisplayBankAccount_Load(object sender, EventArgs e)
        {
            nameLabel.Text = bankAccount.Name.ToString();
            sortCodeLabel.Text = bankAccount.SortCode.ToString();
            accountNumberLabel.Text = bankAccount.AccountNumber.ToString();
            nameOnAccountLabel.Text = bankAccount.NameOnAccount.ToString();
            overdraftLabel.Text = bankAccount.Overdraft.ToString();
        }
    }
}
