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
        private BankAccountCard bankAccount;
        public DisplayBankAccount(BankAccountCard bankAccountCard)
        {
            bankAccount = bankAccountCard;
            InitializeComponent();
        }

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
